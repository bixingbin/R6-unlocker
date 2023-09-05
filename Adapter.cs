using Microsoft.Win32;
using System;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SumTing_Special
{
    public class NetworkAdapter
    {
        private readonly ManagementObject _Adapter;
        private readonly string _AdapterName;
        private readonly string _CustomName;
        private readonly int _DeviceNumber;

        

        public NetworkAdapter(NetworkInterface networkInterface) : this(networkInterface.Description) { }

        private NetworkAdapter(string name)
        {
            _AdapterName = name;

            var searcher = new ManagementObjectSearcher($"SELECT * FROM Win32_NetworkAdapter WHERE Name='{_AdapterName}'");
            var found = searcher.Get();
            _Adapter = found.Cast<ManagementObject>().FirstOrDefault();

            try
            {
                var match = Regex.Match(_Adapter.Path.RelativePath, "\\\"(\\d+)\\\"$");
                _DeviceNumber = int.Parse(match.Groups[1].Value);
            }
            catch
            {
                return;
            }

            _CustomName = NetworkInterface.GetAllNetworkInterfaces()
                .Where(o => o.Description == _AdapterName)
                .Select(o => " (" + o.Name + ")")
                .FirstOrDefault();
        }

        private NetworkInterface ManagedAdapter => NetworkInterface.GetAllNetworkInterfaces()
            .Where(ani => ani.Description == _AdapterName)
            .FirstOrDefault();

        public string PhysicalAddress
        {
            get
            {
                try
                {
                    return BitConverter.ToString(ManagedAdapter.GetPhysicalAddress().GetAddressBytes()).Replace("-", "").ToUpper();
                }
                catch
                {
                    return null;
                }
            }
        }

        private string RegistryKey => $@"SYSTEM\ControlSet001\Control\Class\{{4D36E972-E325-11CE-BFC1-08002BE10318}}\{_DeviceNumber:D4}";

        public string RegistryPhysicalAddress
        {
            get
            {
                try
                {
                    using (var regKey = Registry.LocalMachine.OpenSubKey(RegistryKey, false))
                    {
                        return regKey?.GetValue("NetworkAddress")?.ToString();
                    }
                }
                catch
                {
                    return null;
                }
            }
        }

        public bool SetRegistryPhysicalAddress(string value, string title)
        {
            bool shouldReenable = false;
            try
            {

                using (var regKey = Registry.LocalMachine.OpenSubKey(RegistryKey, true))
                {
                    if (regKey == null)
                    {
                        throw new Exception("Registry Key Failed to Open");
                    }
                    else if (regKey.GetValue("AdapterModel") as string != _AdapterName && regKey.GetValue("DriverDesc") as string != _AdapterName)
                    {
                        throw new Exception("Adapter Not Found in Registry!");
                    }
                    else
                    {
                        uint result = (uint)_Adapter.InvokeMethod("Disable", null);
                        if (result != 0)
                        {
                            throw new Exception("Adapter Could Not Be Disabled!");
                        }
                        else
                        {
                            shouldReenable = true;

                            if (value.Length > 0)
                            {
                                regKey.SetValue("NetworkAddress", value, RegistryValueKind.String);
                            }
                            else if (!string.IsNullOrEmpty(regKey.GetValue("NetworkAddress") as string))
                            {
                                regKey.DeleteValue("NetworkAddress");
                            }

                            return true;
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                if (shouldReenable)
                {
                    uint result = (uint)_Adapter.InvokeMethod("Enable", null);
                    if (result != 0)
                    {
                        MessageBox.Show("Adapter Could Not Be Reactivated!");
                    }
                }
            }
        }

        public override string ToString()
        {
            return _AdapterName + _CustomName;
        }

        public static string GenerateRandomMAC()
        {
            var random = new Random();

            var bytes = new byte[6];
            random.NextBytes(bytes);

            bytes[0] = (byte)(bytes[0] | 0x02);
            bytes[0] = (byte)(bytes[0] & 0xfe);

            return ConvertMACToString(bytes);
        }

        public static bool IsValidMAC(string mac, bool actual)
        {
            if (mac.Length != 12)
            {
                return false;
            }
            else if (mac != mac.ToUpper())
            {
                return false;
            }
            else if (!Regex.IsMatch(mac, "^[0-9A-F]*$"))
            {
                return false;
            }
            else if (actual)
            {
                return true;
            }
            else
            {
                char c = mac[1];
                return c == 'A' || c == 'E' || c == '2' || c == '6';
            }
        }

        public static bool IsValidMAC(byte[] bytes, bool actual)
        {
            return IsValidMAC(ConvertMACToString(bytes), actual);
        }

        private static string ConvertMACToString(byte[] bytes)
        {
            return BitConverter.ToString(bytes).Replace("-", "").ToUpper();
        }
    }
}

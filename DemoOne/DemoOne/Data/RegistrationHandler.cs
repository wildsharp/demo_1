
namespace DemoOne.Data
{
    public class RegistrationHandler : IRegistrationHandler
    {
        private static Dictionary<string, DateTime> _registeredIps = new Dictionary<string, DateTime>();

        // Add IP to list if it doesn't already exist
        public bool AddRegistration(string ip)
        {
            if (_registeredIps.ContainsKey(ip)) { return false; }

            _registeredIps.Add(ip, DateTime.Now);
            return true;
        }

        // return full list of IPs as list
        public List<(string, DateTime)> GetRegistrations()
        {
            return _registeredIps.Select(x => (x.Key, x.Value)).ToList();
        }
        
        // remove registered IP
        public bool RemoveRegistration(string ip)
        {
            return _registeredIps.Remove(ip);
        }
    }
}

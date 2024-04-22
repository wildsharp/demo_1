
namespace DemoOne.Data
{
    public class RegistrationHandler : IRegistrationHandler
    {
        private static Dictionary<string, DateTime> _registeredIps = new Dictionary<string, DateTime>();

        public bool AddRegistration(string ip)
        {
            if (_registeredIps.ContainsKey(ip)) { return false; }

            _registeredIps.Add(ip, DateTime.Now);
            return true;
        }

        public List<(string, DateTime)> GetRegistrations()
        {
            return _registeredIps.Select(x => (x.Key, x.Value)).ToList();
        }

        public bool RemoveRegistration(string ip)
        {
            if ( !_registeredIps.ContainsKey(ip)) { return false; }

            _registeredIps.Remove(ip);
            return true;
        }
    }
}

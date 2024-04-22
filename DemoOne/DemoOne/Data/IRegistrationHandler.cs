namespace DemoOne.Data
{
    public interface IRegistrationHandler
    {
        bool AddRegistration(string Ip);
        bool RemoveRegistration(string Ip);
        List<(string, DateTime)> GetRegistrations();
    }
}

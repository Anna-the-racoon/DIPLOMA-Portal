namespace SecurityService.Password
{
    public interface IEncryptor
    {
        string Execute(string password);
    }
}
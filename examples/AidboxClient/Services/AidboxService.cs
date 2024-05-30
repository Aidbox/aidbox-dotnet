using Aidbox;

public interface IAidboxClientService {
    public Client GetClient();
};

public class AidboxClientService : IAidboxClientService
{
    private readonly Client _sdkClient;

    public AidboxClientService()
    {
        Auth auth = new()
        {
            Method = AuthMethods.BASIC,
            Credentials = new() { Username = "basic", Password = "secret" }
        };

        _sdkClient = new("http://localhost:8765", auth);
    }

    public Client GetClient()
    {
        return _sdkClient;
    }
}
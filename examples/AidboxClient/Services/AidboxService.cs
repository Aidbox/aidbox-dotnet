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

        _sdkClient = new("https://dotnetsdkdemo.aidbox.app", auth);
    }

    public Client GetClient()
    {
        return _sdkClient;
    }
}
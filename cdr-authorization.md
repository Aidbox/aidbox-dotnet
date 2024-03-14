```C#
Auth authorization = new()
{
    Method = AuthMethods.BASIC,
    Credentials = new() { Username = "basic", Password = "secret" }
};

Client client = new("https://genacodex.aidbox.app", authorization);

Console.WriteLine(await client.GetInfo());
```

```JSON
{
    "version": "2402",
    "channel": "latest",
    "commit": "141264a88",
    "timestamp":"2024-03-13T09:51:18Z"
}
```

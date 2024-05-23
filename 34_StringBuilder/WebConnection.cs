public class WebConnection : IDisposable
{
    private readonly string _url;

    public WebConnection(string url)
    {
        _url = url;
    }

    public string Read(string data)
    {
        return "Weather data";
    }
    public bool CanRead(string data)
    {
        return true;
    }
    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
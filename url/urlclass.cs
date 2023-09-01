namespace global{
    public class Url{
    public string scheme;
    public string domain;
    public string subdomain;
    public string path;
    public string topleveldomain;
    public string querystring;

    public Url(string _scheme _domain _subdomain _path _toplevedomain _querystring){
        scheme = _scheme;
        domain = _domain;
        subdomain = _subdomain;
        path = _path;
        topleveldomain = _toplevedomain
        querystring = _querystring;
    }
}
}
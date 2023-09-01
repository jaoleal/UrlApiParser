namespace classes{
    public class URL{
        public string ?scheme;
        public string ?domain;
        public string ?subdomain;
        public string ?path;
        public string ?topleveldomain;
        public string ?querystring;
        public string[] allmodules;

        public URL(string _scheme, string _domain, string _subdomain, string _path, string _toplevedomain, string _querystring){
            scheme = _scheme;
            domain = _domain;
            subdomain = _subdomain;
            path = _path;
            topleveldomain = _toplevedomain;
            querystring = _querystring;
            allmodules = new string[] {scheme, domain, subdomain, path, topleveldomain,querystring};
        }
    }
}
using System.ComponentModel.DataAnnotations;

namespace classes{
    public class URL{
        protected string? scheme{ get; set; }
        protected string? domain{ get; set; }
        protected string? subdomain{ get; set; }
        protected string? path{ get; set; }
        public string[]? Allmodules{ get; set; }

        public void parserinput(string[] modules){
            this.scheme = modules[0];
            this.domain = modules[1];
            this.subdomain = modules[2];

            this.Allmodules = modules;

        } 
}
    
    public class YoutubeURL: URL{


        //constructor to inherit from an existing URL object.
        public YoutubeURL(URL inheriter){
            this.Allmodules = inheriter.Allmodules;
        }
        public string VideoId{ get; set; }
        public string? Channel{ get; set; }
        public string? Seconds{ get; set; }
            
    }
}
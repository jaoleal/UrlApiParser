using System.ComponentModel.DataAnnotations;

namespace classes{
    public class URL{
        protected string? scheme{ get; set; }
        protected string? domain{ get; set; }
        protected string? subdomain{ get; set; }
        protected string? path{ get; set; }
        protected string? topleveldomain{ get; set; }
        protected string[]? allmodules{ get; set; }

        public void parserinput(string[] modules){
            this.scheme = modules[0];
            this.domain = modules[1];
            this.topleveldomain = modules[2] + "." + modules[3];
            this.path = modules[4];

            this.allmodules = modules;

        } 
}
    
    public class YoutubeURL: URL{


        public string VideoId{ get; set; }
        public string? Channel{ get; set; }
        public string? Seconds{ get; set; }
            
    }
}
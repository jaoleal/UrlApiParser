using System.ComponentModel.DataAnnotations;

namespace classes{
    public class URL{
        protected string? scheme{ get; set; }
        protected string? domain{ get; set; }
        protected string? subdomain{ get; set; }
        protected string? path{ get; set; }
        public string[] Allmodules{ get; set; }

        public void parserinput(string[] modules){
            this.scheme = modules[0];
            this.domain = modules[1];
            this.subdomain = modules[2];
            this.path = modules[3];

            this.Allmodules = modules;

        } 
}
    
    public class YoutubeURL: URL{


        //constructor to inherit from an existing URL object.
        public YoutubeURL(URL inheriter){
            this.scheme = inheriter.Allmodules[0];
            this.domain = inheriter.Allmodules[1];
            this.subdomain = inheriter.Allmodules[2];
            this.path = inheriter.Allmodules[3];

            this.Allmodules = inheriter.Allmodules;
        }

        public void ParseId(){
            string? cache =  path;
            if(cache ==  null){
                Console.WriteLine("Path is null");
            }else{
                string[] Divisors = {"watch?v=", "&", "-"};
                string[] subcache = cache.Split(Divisors,  StringSplitOptions.RemoveEmptyEntries );
                VideoId = subcache[0]; 
            }
        }
        public string VideoId{ get; set; }
        public string? Channel{ get; set; }
        public string? Seconds{ get; set; }
            
    }
}
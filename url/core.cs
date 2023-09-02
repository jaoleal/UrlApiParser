using System;
using System.Reflection;
using System.Security.AccessControl;
using classes;
namespace core{
public class CoreParseFunc{

        public URL[] urlobjects;
        public CoreParseFunc(string url ){
            
        }
        public CoreParseFunc(string[] urls){

            static URL ParseUrl(string url,ref URL obj){
                
                //divisors group that separate strings.
                string[] Divisors = {"."};

                //index of the modules
                //scheme = 0
                //domain = 1
                //topleveldomain = 2 if has two components + "." + 3
                //path is the rest or 4 

                
                string[] cache = url.Split(Divisors, StringSplitOptions.RemoveEmptyEntries);
                string[] urlmodules = cache;
                if(urlmodules[2].Contains("/")){
                cache = urlmodules[2].Split("/", StringSplitOptions.RemoveEmptyEntries);
                urlmodules = new string[urlmodules.Length +1];
                urlmodules[3] = cache[0];
                } 
                obj = new URL();
                obj.parserinput(urlmodules);
                return obj;
                
               
            }
            urlobjects = new URL[urls.Length];
            var x = 0;
            foreach(var url in urls){
                ParseUrl(url, ref urlobjects[x]);
                x++;
            }
        }
}
}
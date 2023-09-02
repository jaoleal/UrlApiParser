using System;
using System.Security.AccessControl;
using classes;
namespace core{
public class CoreParseFunc{
        public CoreParseFunc(string url ){
            
        }
        public CoreParseFunc(string[] urls, URL[] objects){

            static URL ParseUrl(string url, URL obj){
                
                //divisors group that separate strings.
                string[] Divisors = {"Null"};

                //index of the modules
                //scheme = 0
                //domain = 1
                //topleveldomain = 2 if has two components + "." + 3
                //path is the rest or 4 

                
                string[] cache = url.Split(Divisors, StringSplitOptions.RemoveEmptyEntries);
                string[] urlmodules = cache;
                obj.parserinput(urlmodules);
                return obj;
                
               
            }        
        }
}
}
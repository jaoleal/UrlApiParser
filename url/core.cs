using System;
using System.Globalization;
using System.Reflection;
using System.Security.AccessControl;
using classes;
namespace core{
public class CoreParseFunc{

        public URL[] urlobjects;
        static URL ParseUrl(string url,ref URL obj){
                
                //divisors group that separate strings.
                string[] Divisors = {"."};

                //index of the modules
                //scheme = 0
                //domain = 1
                //topleveldomain = 2 if has two components + "." + 3
                //path is the rest or 4 

                
                string[] cache = url.Split(Divisors, StringSplitOptions.RemoveEmptyEntries);
                
                //saving scheme to urlmodules
                string[] urlmodules =  new string[cache.Length];
                //separates subdomain and path.
                //starts in 1 to ignore scheme.
                string[] stringseparator =  new string[cache.Length -1] ;
                
                for(int i = 1; i < cache.Length; i ++){
                    int pathindex =  0; 
                    stringseparator[i - 1 ] = cache[i]; 
                    if(stringseparator[i - 1].Contains("/")){
                        //splits the path and the subdomain.
                        string[] subcache = stringseparator[i - 1].Split("/", StringSplitOptions.RemoveEmptyEntries);
                        
                        pathindex = i - 1 ;

                        subcache[0] = "." + subcache[0];                        
                        urlmodules = new string[cache.Length + subcache.Length - 1];
                      
                        for (int j  = 0 ;  j <= urlmodules.Length; ++j){
                            if(j < cache.Length){
                                urlmodules[j] = cache[j];
                            }else {
                                urlmodules[j- 1] = subcache[j - cache.Length];
                            }
                        } 

                        break;
                    }
                }


                obj = new URL();
                obj.parserinput(urlmodules);
                return obj;
                
               
            }
        public CoreParseFunc(string url){
            urlobjects = new URL[1];
            ParseUrl(url, ref urlobjects[0]);
            
        }
        public CoreParseFunc(string[] urls){

            
            urlobjects = new URL[urls.Length];
            var x = 0;
            foreach(var url in urls){
                ParseUrl(url, ref urlobjects[x]);
                x++;
            }
        }
}
}
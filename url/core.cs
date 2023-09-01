﻿using classes;
namespace core{
public class CoreParseFunc{
        public URL[] URLObjects= new URL[1];
        public CoreParseFunc(string url ){
            
        }
        public CoreParseFunc(string[] urls){

            static string ParseUrl(string url, string target){   
                
                //divisors group that separate strings.
                string[] Divisors = {"Null"};

                //index of the target in the output.
                int moduleindex = 0;

                switch(target){
                    case "Null":
                    Console.WriteLine("Divisores não configurados corretamente");
                    break;

                    case "domain":
                        Divisors = new string[] {"https://www.", ".com",};
                        moduleindex = 0;
                    break;

                    case "scheme":
                        Divisors = new string[] {"."};
                        moduleindex = 0;
                    break;
                    case "topleveldomain":
                        Divisors = new string[] {"https://www","."};
                        moduleindex = 1; 
                    break;
                    case "path":
                        Divisors = new string[] {"https://wwww.", ".com", "/"};
                        moduleindex = 1;
                    break;
                    case "querystring":
                        Divisors = new string[] {"?"};
                        moduleindex = 1;
                    break;

                }
                string[] cache = url.Split(Divisors, StringSplitOptions.RemoveEmptyEntries);
                string[] urlmodules = cache;
                if(moduleindex+1 > urlmodules.Length){
                    return "null";
                }else{
                     return urlmodules[moduleindex];
                }
               
            }
            URLObjects = new URL[urls.Length];
            int i = 0;
            foreach(string url in urls){
                URLObjects[i] = new URL(ParseUrl(url, "scheme"),ParseUrl(url, "domain"),ParseUrl(url, "subdomain"),ParseUrl(url, "path"),ParseUrl(url, "topleveldomain"),ParseUrl(url, "querystring"));

                i++;
            }

        
        }
}
}
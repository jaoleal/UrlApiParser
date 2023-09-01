using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

public class CoreParseFunc{
        private string scheme;
        public string Scheme
        {
            get{ return scheme;}
        }
        public CoreParseFunc(string url){
            
        }
        public CoreParseFunc(string[] url){

        }
        public string[] TestUrls = {
            "https://www.youtube.com/watch?v=Nj4XO0GPijY&ab_channel=PortadosFundos",
            "https://www.youtube.com/watch?v=PK0_B_6FxAA&ab_channel=MuriloCouto",
            "https://www.youtube.com/watch?v=-U1Gv1b9tXY&ab_channel=Swagger",
            "https://youtu.be/-U1Gv1b9tXY",
            "https://youtu.be/-U1Gv1b9tXY?t=36",
            "https://www.instagram.com/stories/jorgebrandino/3181640852107095422/",
            "https://www.twitter.com"
        };
        protected string[][] ParseUrl(string[] url)
        {
            string[] Divisors = { "https://www", ".", "/", "&ab_channel", "=", "whatch?v=" };
            string[][] urlmodules = new string[url.Length][];
            for (int i = 0; i < url.Length; i++)
            {
                string[] cache = url[i].Split(Divisors, StringSplitOptions.RemoveEmptyEntries);
                urlmodules[i] = new string[cache.Length];
                for (int j = 0; j < cache.Length; j++)
                {

                    urlmodules[i][j] = cache[j];
                }
            }
            return urlmodules;
        }

        protected string[] ParseUrl(string url)
        {
            string[] Divisors = { "https://www", ".", "/", "&ab_channel", "=", "whatch?v=" };
            string[] urlmodules = new string[url.Length];
            for (int i = 0; i < url.Length; i++)
            {
                string[] cache = url.Split(Divisors, StringSplitOptions.RemoveEmptyEntries);
                urlmodules = new string[cache.Length];
                for (int j = 0; j < cache.Length; j++)
                {
                    urlmodules[i] = cache[j];
                }
            }
            return urlmodules;
        }
}

internal class TestSpace{
    static void Main(string[] args){



    }
}
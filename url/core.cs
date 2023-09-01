using System;
using System.Net.Http.Headers;

string[] TestUrls = {
    "https://www.youtube.com/watch?v=Nj4XO0GPijY&ab_channel=PortadosFundos",
    "https://www.youtube.com/watch?v=PK0_B_6FxAA&ab_channel=MuriloCouto",
    "https://www.youtube.com/watch?v=-U1Gv1b9tXY&ab_channel=Swagger",
    "https://youtu.be/-U1Gv1b9tXY",
    "https://youtu.be/-U1Gv1b9tXY?t=36",
    "https://www.instagram.com/stories/jorgebrandino/3181640852107095422/",
    "https://www.twitter.com"
};
 string[][] ParseUrl(string[] url){
    string[] Divisors = {"https://www", ".","/","&ab_channel","=","whatch?v="};
    string [][] urlmodules = new string[url.Length][];
    for(int i = 0; i < TestUrls.Length; i++){
        string[] cache = url[i].Split(Divisors, System.StringSplitOptions.RemoveEmptyEntries);
        urlmodules[i] = new string[cache.Length];
        for(int j = 0; j < cache.Length; j++){

            urlmodules[i][j] = cache[j]; 
        }
    }
    return urlmodules;
}
string[][] algout = IdentifyUrl(TestUrls);

// just displays the output
for( int i = 0 ;i < algout.Length; i++ ){
    for(int j = 0;j < algout[i].Length; j++){
            Console.WriteLine(algout[i][j]);
    }
}

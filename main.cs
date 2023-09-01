using classes;
using core;
internal class TestSpace{
    static void Main(string[] args){
         string[] TestUrls = {
            "https://www.youtube.com/watch?v=Nj4XO0GPijY&ab_channel=PortadosFundos",
            "https://www.youtube.com/watch?v=PK0_B_6FxAA&ab_channel=MuriloCouto",
            "https://www.youtube.com/watch?v=-U1Gv1b9tXY&ab_channel=Swagger",
            "https://youtu.be/-U1Gv1b9tXY",
            "https://youtu.be/-U1Gv1b9tXY?t=36", 
            "https://www.instagram.com/stories/jorgebrandino/3181640852107095422/",
            "https://www.twitter.com"};

        CoreParseFunc Parseador = new CoreParseFunc(TestUrls);
        foreach(var s in Parseador.URLObjects){
            foreach(var t in s.allmodules){
                Console.WriteLine(t);
            }
            
        }

        

    }
}    

using classes;
using core;
internal class TestSpace{
    static void Main(string[] args){
         string[] TestUrls = {
            "https://www.youtube.com/watch?v=Nj4XO0GPijY&ab_channel=PortadosFundos",
            "https://www.youtube.com/watch?v=PK0_B_6FxAA&ab_channel=MuriloCouto",
            "https://www.youtube.com/watch?v=-U1Gv1b9tXY&ab_channel=Swagger",
/*             "https://youtu.be/-U1Gv1b9tXY",
            "https://youtu.be/-U1Gv1b9tXY?t=36", */
            "https://www.instagram.com/stories/jorgebrandino/3181640852107095422/",
            "https://www.twitter.com"};

        CoreParseFunc funcionaporfavor = new CoreParseFunc(TestUrls);
        Console.WriteLine(funcionaporfavor.URLObjects[2].scheme);

    }
}    

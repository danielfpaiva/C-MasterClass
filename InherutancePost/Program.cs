using System;

namespace InheritancePost
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Cenas","Me",true);
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check this image","Me","https://cenas.com/shoes",true);

            Console.WriteLine(imagePost1.ToString());


            VideoPost videoPost = new VideoPost("Olá", "Daniel", "https://www.youtube.com/watch?v=ZIVE0zYFIrs", 32, true);
            Console.WriteLine(videoPost.ToString());

            videoPost.Play();
            Console.ReadKey();
            videoPost.Stop();
        }
    }
}

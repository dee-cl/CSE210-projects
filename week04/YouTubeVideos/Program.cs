using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title ="Creative video name!!! 1 ";
        video1._author = "The poor writer";
        video1._length = 124;

        Comment vid1comment1 = new Comment();
        vid1comment1._name = "MrBeast";
        vid1comment1._comment = "Can someone explain this part?";
        Comment vid1comment2 = new Comment();
        vid1comment2._name = "Derek";
        vid1comment2._comment = "Great video! Thanks for sharing";
        Comment vid1comment3 = new Comment();
        vid1comment3._name = "The LAd";
        vid1comment3._comment = "This deserves more views.";
        Comment vid1comment4 = new Comment();
        vid1comment4._name = "UbErNiNjA";
        vid1comment4._comment = "This made my day!";

        video1._comments.Add(vid1comment1);
        video1._comments.Add(vid1comment2);
        video1._comments.Add(vid1comment3);
        video1._comments.Add(vid1comment4);


        Video video2 = new Video();
        video2._title ="Fantastic video name!!";
        video2._author = "The amazing writer";
        video2._length = 350;


        Comment vid2comment1 = new Comment();
        vid2comment1._name = "Rift Master";
        vid2comment1._comment = "Who else is watching in 2025?";
        Comment vid2comment2 = new Comment();
        vid2comment2._name = "NachoCheeseWhiz";
        vid2comment2._comment = "Keep up the good work!";
        Comment vid2comment3 = new Comment();
        vid2comment3._name = "SirLaughsALot";
        vid2comment3._comment = "Awesome content!";
        Comment vid2comment4 = new Comment();
        vid2comment4._name = "SirLaughsALot";
        vid2comment4._comment = "Can someone explain this part?";

        video2._comments.Add(vid2comment1);
        video2._comments.Add(vid2comment2);
        video2._comments.Add(vid2comment3);
        video2._comments.Add(vid2comment4);


        Video video3 = new Video();
        video3._title ="Boring video name";
        video3._author = "Steven King";
        video3._length = 10;


        Comment vid3comment1 = new Comment();
        vid3comment1._name = "James";
        vid3comment1._comment = "Great video! Thanks for sharing";
        Comment vid3comment2 = new Comment();
        vid3comment2._name = "CaptainObvious";
        vid3comment2._comment = "Awesome content!";
        Comment vid3comment3 = new Comment();
        vid3comment3._name = "PunnyBunny";
        vid3comment3._comment = "I have a question about this topic.";
        Comment vid3comment4 = new Comment();
        vid3comment4._name = "MemeQueen";
        vid3comment4._comment = "First!";

        video3._comments.Add(vid3comment1);
        video3._comments.Add(vid3comment2);
        video3._comments.Add(vid3comment3);
        video3._comments.Add(vid3comment4);

        Video video4 = new Video();
        video4._title ="Last video name";
        video4._author = "Patrick";
        video4._length = 9000;


        Comment vid4comment1 = new Comment();
        vid4comment1._name = "DadJokeDealer";
        vid4comment1._comment = "This deserves more views.";
        Comment vid4comment2 = new Comment();
        vid4comment2._name = "SnackAttackJack";
        vid4comment2._comment = "Who else is watching in 2025?";
        Comment vid4comment3 = new Comment();
        vid4comment3._name = "TheRealFakeUser";
        vid4comment3._comment = "This made my day!";
        Comment vid4comment4 = new Comment();
        vid4comment4._name = "LOLcano";
        vid4comment4._comment = "I learned a lot from this.";

        video4._comments.Add(vid4comment1);
        video4._comments.Add(vid4comment2);
        video4._comments.Add(vid4comment3);
        video4._comments.Add(vid4comment4);

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"{video._title}: by {video._author}. {video._length} Seconds. {video._count}");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"{comment._name} | {comment._comment}");
            }
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        Comment c1 = new Comment("StealurGoat", "This was honestly wayyy ahead of its time, woven into the fabric of YouTube itself.");
        Comment c2 = new Comment("jaydox3836", "i've been quoting 'shun the non-believer' every chance i've gotten since this came out 16 years ago, and i won't stop");
        Comment c3 = new Comment("Luna", "this brings me back.");
        List<Comment> commentList1 = new List<Comment>();
        commentList1.Add(c1);
        commentList1.Add(c2);
        commentList1.Add(c3);

        Video vid1 = new Video("Charlie the Unicorn", "FilmCow", 225, commentList1);
        videoList.Add(vid1);

        Comment c4 = new Comment("dell_pepper", "This was my generation’s brainrot");
        Comment c5 = new Comment("prettysunflower3268", "Awww it makes me feel so warm inside");
        Comment c6 = new Comment("ProfessorPher", "When I watch this video, I feel like I'm staring into eternity.");
        List<Comment> commentList2 = new List<Comment>();
        commentList2.Add(c4);
        commentList2.Add(c5);
        commentList2.Add(c6);

        Video vid2 = new Video("NyanCat! [Official]", "NyanCat", 216, commentList2);
        videoList.Add(vid2);

        Comment c7 = new Comment("crabosity", "If this dont play at my funeral, I aint coming");
        Comment c8 = new Comment("rebeccasample1514", "I cant believe they didnt use this in the minecraft movie credits 😔");
        Comment c9 = new Comment("JaMaar", "Imagine getting your famous song beaten in views because of a Minecraft parady");
        List<Comment> commentList3 = new List<Comment>();
        commentList3.Add(c7);
        commentList3.Add(c8);
        commentList3.Add(c9);

        Video vid3 = new Video("'Revenge' - A Minecraft Parody of Usher's DJ Got Us Fallin' In Love (Music Video)", "CaptainSparklez", 264, commentList3);
        videoList.Add(vid3);

        foreach (Video video in videoList)
        {
            Console.WriteLine(video.GetDisplayText());
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine(video.GetAllCommentsDisplayText());
        }

    }
}
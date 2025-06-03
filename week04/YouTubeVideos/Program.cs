using System;

class Program
{
    static void Main(string[] args)
    {
        //First Video
        Video video1 = new Video();
        video1.author = "Matthew";
        video1.title = "Mountain Climbing";
        video1.length = 1680;

        //Second Video
        Video video2 = new Video();
        video2.author = "Mark";
        video2.title = "Easter Morning";
        video2.length = 960;

        //Third Video
        Video video3 = new Video();
        video3.author = "Luke";
        video3.title = "Sheep Finding";
        video3.length = 1440;

        //Fourth Video
        Video video4 = new Video();
        video4.author = "John";
        video4.title = "Nightly Stroll";
        video4.length = 1260;

        //1st video comments
        Comment c11 = new Comment();
        c11.authorName = "F0llower125";
        c11.comment = "Thank You!";
        video1.addComment(c11);

        Comment c12 = new Comment();
        c12.authorName = "RealestPharisee";
        c12.comment = "Sounds like heresy";
        video1.addComment(c12);

        Comment c13 = new Comment();
        c13.authorName = "JusticeSeeker";
        c13.comment = "Feeling hungry";
        video1.addComment(c13);

        Comment c14 = new Comment();
        c14.authorName = "SavourlessSalt";
        c14.comment = "I feel called out.";
        video1.addComment(c14);

        //Video 1 stats, comments
        video1.displayVideoStats();
        video1.displayComments();

        //2nd video comments
        Comment c21 = new Comment();
        c21.authorName = "Joodas";
        c21.comment = "Fake";
        video2.addComment(c21);

        Comment c22 = new Comment();
        c22.authorName = "RealestPharisee";
        c22.comment = "Didn't this guy break the law of Moses?";
        video2.addComment(c22);

        Comment c23 = new Comment();
        c23.authorName = "PeopleFisher";
        c23.comment = "We are so back";
        video2.addComment(c23);

        Comment c24 = new Comment();
        c24.authorName = "Magdaller";
        c24.comment = "Halleluiah!";
        video2.addComment(c24);

        //Video 2 stats, comments
        video2.displayVideoStats();
        video2.displayComments();

        //3rd video comments
        Comment c31 = new Comment();
        c31.authorName = "BadSh3pard";
        c31.comment = "I don't really think the sheep are worth the sacrifice ¯_('-')_/¯";
        video3.addComment(c31);
        Comment c32 = new Comment();
        c32.authorName = "Pr0digalS0n";
        c32.comment = "I have the best dad ever ;-;";
        video3.addComment(c32);
        Comment c33 = new Comment();
        c33.authorName = "Pr0digalBr0";
        c33.comment = "I have the worst dad ever ;-;";
        video3.addComment(c33);
        Comment c34 = new Comment();
        c34.authorName = "BroomWoman";
        c34.comment = "Found my coin! Let's party!!!";
        video3.addComment(c34);

        //Video 3 stats, comments
        video3.displayVideoStats();
        video3.displayComments();

        //4th video comments
        Comment c41 = new Comment();
        c41.authorName = "N1co";
        c41.comment = "What if my mom already died?";
        video4.addComment(c41);

        Comment c42 = new Comment();
        c42.authorName = "B4pt1st";
        c42.comment = "The water feels really nice this time of year :D";
        video4.addComment(c42);

        Comment c43 = new Comment();
        c43.authorName = "B0rnAg4in";
        c43.comment = "Feeling pretty nice recently!";
        video4.addComment(c43);

        Comment c44 = new Comment();
        c44.authorName = "M0s3s";
        c44.comment = "My arm's getting tired guys";
        video4.addComment(c44);

        //Video 4 stats, comments
        video4.displayVideoStats();
        video4.displayComments();
    }
}
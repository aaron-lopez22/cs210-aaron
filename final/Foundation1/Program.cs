using System;

class Program
{
    static void Main(string[] args)
    {
        Videos video1 = new Videos();
        video1._title = "Inside the Navy's Indoor Ocean";
        video1._author = "Veritasium";
        video1._length = "20:24";

        Comments comments1 = new Comments();
        comments1._nameCommenter = "tacowolf";
        comments1._comment = "This videos is great! I wish I could visit the Navy's indoor Ocean";

        Comments comments2 = new Comments();
        comments2._nameCommenter = "anotherBear";
        comments2._comment = "Indoor oceans can be scary like this. I have always been scared of wave pools after a bad incident as a kid.";

        Comments comments3 = new Comments();
        comments3._nameCommenter = "ronaldmuggle";
        comments3._comment = "Its so cool to see how we build these types of facilities to test out our Navy";

        video1._comments.Add(comments1);
        video1._comments.Add(comments2);
        video1._comments.Add(comments3);

        Videos video2 = new Videos();
        video2._title = "Big Boi Shoulder Workout W. Ian Valliere";
        video2._author = "Chris Bumstead";
        video2._length = "20:15";

        Comments commentsVideo2 = new Comments();
        commentsVideo2._nameCommenter = "cheeseMaster22";
        commentsVideo2._comment = "Solid shoulder video that is awesome";

        Comments commentsVideo2_2 = new Comments();
        commentsVideo2_2._nameCommenter = "Travelkit35";
        commentsVideo2_2._comment = "Video is fantastic thanks for the tips";

        Comments commentsVideo2_3 = new Comments();
        commentsVideo2_3._nameCommenter = "pr5401";
        commentsVideo2_3._comment = "I am copying the workout next time I go to the gym";

        video2._comments.Add(commentsVideo2);
        video2._comments.Add(commentsVideo2_2);
        video2._comments.Add(commentsVideo2_3);

        Videos video3 = new Videos();
        video3._title = "How to keep Indoor Cats Happy";
        video3._author = "Jackson Galaxy";
        video3._length = "18:48";

        Comments commentsVideo3 = new Comments();
        commentsVideo3._nameCommenter = "Gordy654";
        commentsVideo3._comment = "This was really helpful with me and my cat";

        Comments commentsVideo3_2 = new Comments();
        commentsVideo3_2._nameCommenter = "cheerios5";
        commentsVideo3_2._comment = "My cat loves to jump on our furniture and scratch the couch, I will be getting more cardboard for it to play with";

        Comments commentsVideo3_3 = new Comments();
        commentsVideo3_3._nameCommenter = "catenthusiast800";
        commentsVideo3_3._comment = "I thought I knew a lot about cats but this video helped me a lot";





        video1.Display();
        video2.Display();
        video3.Display();
    }
}
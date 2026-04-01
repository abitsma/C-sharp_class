using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> VideoList = new List<Video>();
        Video one = new Video("Fighting Game Clip", "Gamerman", 20);
        Video two = new Video("How to code in C#", "CoderGuy", 43829042);
        Video three = new Video("Can I eat 13 watermelons in one sitting?", "BigEaterMan", 600);
        VideoList.Add(one);
        VideoList.Add(two);
        VideoList.Add(three);

        one.AddComment("Jerry", "Yo that was a sick clip man!");
        one.AddComment("MLGboi420", "This is nothing compared to how good I am. Get Good Scrub.");
        one.AddComment("Grandma", "Good job sweetie! I have cookies here for you.");

        two.AddComment("Nathan", "This video is way too compmlicated. Please make a beginner-friendly video.");
        two.AddComment("DevGuy", "You need to go more into the differences between lists and arrays.");
        two.AddComment("Mikayla", "I don't even program. Why did I watch this?");

        three.AddComment("BigEaterMansWife", "Next time make sure to live stream it. We could use the money.");
        three.AddComment("Redditor", "Atchually, it's physically impossible to fit that much produce into a human stomach.");
        three.AddComment("AverageJoe", "Dude seeing you do that was absolutely wicked. Do this again please!");

        foreach (Video video in VideoList)
        {
            video.Display();
        }
    }
}
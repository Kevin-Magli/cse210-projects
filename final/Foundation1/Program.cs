using System;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();
        
        Video videoGame= new Video(
            "The Legend of Zelda: Ocarina of Time Speedrun WR 33:67",
            "GoronRunner",
            2207
        );

        videoGame.AddComment("What a run! You must have nerves of steel", "Stryder99");     
        videoGame.AddComment("You're an inspiration to all of us gamers out there", "GamerGirl88");
        videoGame.AddComment("I've watched this video like 3 times and I still can't believe you did it", "ZeldaMaster3000");

        videos.Add(videoGame);
        
        
        Video videoEssay= new Video(
            "Why social media is destroying this generation",
            "Steven Matthews",
            2600
        );

        videoEssay.AddComment("This video is so on point, I'm going to go delete my social media accounts", "SocialMediaBurnout101");
        videoEssay.AddComment("I'm so tired of seeing the same things on my news feed all day", "SameOldSameOld");
        videoEssay.AddComment("I can't believe how much time I've wasted on social media", "TimeWaster100");
        videoEssay.AddComment("I disagree. Social media is not the problem, it's the people. We need to revolutionize the usage of social media!", "SocialMediaInnovator101");
        
        videos.Add(videoEssay);

        
        Video videoTech= new Video(
            "Top 5 linux Distros for 2025",
            "TechWizz",
            1800
        );

        videoTech.AddComment("I can't wait to try out Fedora for my next project. Its a great distro for developers", "systemdgarb");
        videoTech.AddComment("Arch is really cool now, even for beginners, just use arch install.", "archbtw101");
        videoTech.AddComment("I'm really excited for this video! I'm going to try out Garuda. The fact that it comes with an entire gaming ecosystem is just too good!", "garudafanboy");
        videoTech.AddComment("I love the fact that Manjaro has a friendly community and is super lightweight", "manjaroLover");
        videoTech.AddComment("I'm really excited to try out Pop!_OS. It's a great distro for beginners and has a really cool look and feel", "poposAdventurer");

        videos.Add(videoTech);
        


        foreach (Video video in videos)
        {
            Console.WriteLine($"{video.GetTitle()} by {video.GetAuthor()} with {video.GetLength()} seconds long");
            Console.WriteLine($"There are currently {video.GetCommentQuantity()} comments on this video");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetAuthor()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
        



    }


}
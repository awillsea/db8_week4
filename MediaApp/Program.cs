
Video video1 = new Video("The Shining", "Horror", "Kubrik", "R");
video1.play();








class Media
{
    public string Title;
    public string Genre;

    public Media(string _title, string _genre)
    {
        Title = _title;
        Genre = _genre; 
    }

    public virtual void play()
    {
        Console.WriteLine("The Media is playing");
    }
}

class Video : Media
{
    public string Director;
    public string Rating;

    public Video(string _title, string _genre, string _director, string _rating) : base(_title, _genre)
    {
        Director = _director;   
        Rating = _rating;

    }
    public override void play()
    {
        Console.WriteLine($"Video {Title} ({Genre}) Directed by {Director} Rated {Rating}");
    }
}
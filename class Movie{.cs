class Movie{
    public string title;
    public int year;

    Movie.Movie(){
        this.title = title;
        this.year = year;
    }

    string GetMovieInfo()
    {
        return $"{title} {year}";
    }
}

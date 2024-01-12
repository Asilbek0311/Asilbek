class Song{
    public String title;
    public String artist;
    public int duration;

    Song.Song(){
        this.title = title;
        this.artist = artist;
        this.duration = duration;
    }

    string GetSongInfo()
    {
        return $"{title} {artist} {duration}";
    }
}

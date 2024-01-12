class Book{
    public String title;
    public String author;
    public int sheets;

    Book.Book(){
        this.title = title;
        this.author = author;
        this.sheets = sheets;
    }

    string GetBookInfo()
    {
        return $"{title} {author} {sheets}";
    }
}
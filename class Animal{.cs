class Animal{
    public string species;
    public int author;
    public int sheets;

    Animal.Animal(){
        this.species = species;
        this.author = author;
        this.sheets = sheets;
    }

    string GetAnimalInfo()
    {
        return $"{species} {author} {sheets}";
    }
}

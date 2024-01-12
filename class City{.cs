class City{
    public string name;
    public double price;
    public int population;
    City.City(){
        this.name = name;
        this.price = price;
        this.population = population;
    }

    public string GetCityInfo()
    {
        return $"{name} {price} {population}";
    }
}
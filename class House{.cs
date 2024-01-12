class House{
    public int surface; //м^2
    public String name;
    public int cost; //$
    public String adress;

    House.House(){
        this.surface = surface;
        this.name = name;
        this.cost = cost;
        this.adress = adress;
    }

    // Метод для получения информации об автомобиле
    string GetHouseInfo()
    {
        return $"{surface} {name} {cost} {adress}";
    }
}

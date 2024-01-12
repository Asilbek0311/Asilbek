class Computer{
    public String brand;
    public String model;
    public int characteristic;

    Computer.Computer(){
        this.brand = brand;
        this.model = model;
        this.characteristic = characteristic;
    }

    string GetComputerInfo()
    {
        return $"{brand} {model} {characteristic}";
    }
}
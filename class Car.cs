class Car
{
    // Поля класса
    public String brand;
    public String model;
    public int year;

    // Конструктор класса Car
    Car.Car(){
        this.brand = brand;
        this.model = model;
        this.year = year;
    }

    // Метод для получения информации об автомобиле
    string GetCarInfo()
    {
        return $"{year} {brand} {model}";
    }
}
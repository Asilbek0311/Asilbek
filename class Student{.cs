class Student{
    public String name;
    public int age; 

    Student.Student(){
        this.name = "Tom";
        this.age = 18;
    }

    string GetStudentInfo()
    {
        return $"{name} {age}";
    }
}

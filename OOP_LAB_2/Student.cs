class Student
{
    public string Name { get; set; }
    public int Grade1 { get; set; }
    public int Grade2 { get; set; }
    public int Grade3 { get; set; }
    public int Group { get; set; }
    public int AverageGrade()
    {
        return (Grade1 + Grade2 + Grade3) / 3;
    }
    public Student()
    {
        Group = 1;
    }
    public Student(int g)
    {
        Group = g;

    }
}
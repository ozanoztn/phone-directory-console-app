class Person
{
    public string name { get; set; }
    public string surname { get; set; }
    public int number { get; set; }

    public Person(string name, string surname, int number)
    {
        this.name = name;
        this.surname = surname;
        this.number = number;
    }
}

class Directory
{
    public List<Person> list = new List<Person>();

    public void add_new_person(Person p)
    {
        this.list.Add(p);
    }

    public void delete_person(int number)
    {
        foreach (Person item in this.list)
        {
            if (item.number == number)
            {
                list.Remove(item);
                Console.WriteLine(item.number + " numarası rehberden silindi");
                break;
            }
        }
    }

    public void write_dir_list()
    {
        foreach (Person item in this.list)
        {
            Console.WriteLine(
                "------ İsim: "
                    + item.name
                    + " ///Soyisim: "
                    + item.surname
                    + " ///Telefon Numarası: "
                    + item.number
            );
        }
    }

    public void search_person(string data, int method)
    {
        if (method == 1)
        {
            foreach (Person item in this.list)
            {
                if (data == (item.name + " " + item.surname))
                {
                    Console.WriteLine(
                        "------ İsim: "
                            + item.name
                            + " ///Soyisim: "
                            + item.surname
                            + " ///Telefon Numarası: "
                            + item.number
                    );
                    return;
                }
            }
        }
        else
        {
            foreach (Person item in this.list)
            {
                if (Convert.ToInt32(data) == item.number)
                {
                    Console.WriteLine(
                        "------ İsim: "
                            + item.name
                            + " ///Soyisim: "
                            + item.surname
                            + " ///Telefon Numarası: "
                            + item.number
                    );
                    return;
                }
            }
        }
        Console.WriteLine("Arama yapmak istediğniz tipi seçiniz: ");
    }
}

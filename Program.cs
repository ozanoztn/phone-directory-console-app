using System;

class Program
{
    static Directory dir = new Directory();
    static bool exit = false;

    public static void Main(string[] args)
    {
        while (!exit)
        {
            write_menu();
            int selection = Convert.ToInt32(Console.ReadLine());
            selection_case(selection);
        }
    }

    static void write_menu()
    {
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
        Console.WriteLine("(1) Yeni Numara Kaydetmek");
        Console.WriteLine("(2) Var Olan Numarayı Silmek");
        Console.WriteLine("(3) Rehberi Listelemek");
        Console.WriteLine("(4) Rehberde Arama Yapmak");
        Console.WriteLine("(5) Çıkış");
    }

    static void selection_case(int s)
    {
        switch (s)
        {
            case 1:
            {
                Console.WriteLine("Lütfen İsim Giriniz: ");
                string name = (Console.ReadLine());
                Console.WriteLine("Lütfen Soyisim Giriniz: ");
                string surname = Console.ReadLine();
                Console.WriteLine("Lütfen Telefon Numarası Giriniz: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Person new_person = new Person(name, surname, number);
                dir.add_new_person(new_person);
                Console.WriteLine("Kullanıcı Başarıyla Oluşturuldu");
                break;
            }
            case 2:
            {
                Console.WriteLine("Silmek istediğiniz numarayı giriniz:");
                int number = Convert.ToInt32(Console.ReadLine());
                dir.delete_person(number);
                break;
            }
            case 3:
            {
                dir.write_dir_list();
                break;
            }
            case 4:
            {
                Console.WriteLine("Arama yapmak istediğniz tipi seçiniz: ");
                Console.WriteLine("(1) İsim ve Soyisim");
                Console.WriteLine("(2) Telefon Numarası");
                Console.WriteLine("(!) Çıkmak için herhangi bir tuşa basınız");
                int search_method = Convert.ToInt32(Console.ReadLine());
                if (search_method == 1)
                {
                    Console.WriteLine("Lütfen isim giriniz:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Lütfen soyisim giriniz:");
                    string surname = Console.ReadLine();
                    dir.search_person((name + " " + surname), search_method);
                }
                else if (search_method == 2)
                {
                    string number = Console.ReadLine();
                    dir.search_person(number, search_method);
                }
                else
                {
                    break;
                }
                break;
            }
            case 5:
            {
                exit = true;
                break;
            }
            default:
            {
                Console.WriteLine("BOYLE BIR KOMUT BULUNMUYOR!!!");
                break;
            }
        }
    }
}

using ClassLibrary;
namespace Task_2
{
    public class Program
    {
        static void Main()
        {
            Car Porsche = new Car(15000000, 1942, 55, 33.22, 33.1);
            Ship Korablik = new Ship(20000, 2007, 34, 1, 3, 177, "Братск");
            Plane Samoletik = new Plane(10000000, 1973, 478, 22.910, 111.4342, 40000, 100);
            Porsche.Print();
            Korablik.Print();
            Samoletik.Print();
        }
    }

}
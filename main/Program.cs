using ClassLibrary;
namespace main
{
    public class Program
    {
        static void Main()
        {
            ExcelentPupil Oleg = new ExcelentPupil("Oleg");
            Oleg.Descrip();
            GoodPupil Bob = new GoodPupil("Bob");
            BadPupil real_Oleg = new BadPupil("Oleg");
            Classroom bam = new Classroom(Oleg, Bob, real_Oleg);
            bam.ClassDescrip();
        }
    }

}
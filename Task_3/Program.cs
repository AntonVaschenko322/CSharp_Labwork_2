using ClassLibrary;
namespace Task_3
{
    public class Program
    {
        static void Main(string[] arg)
        {
            if(arg.Length == 0)
            {
                DocumentWorker x = new DocumentWorker();
                x.OpenDocument();
                x.EditDocument();
                x.SaveDocument();
            }
            else if (arg[0] == "pro")
            {
                ProDocumentWorker x = new ProDocumentWorker();
                x.OpenDocument();
                x.EditDocument();
                x.SaveDocument();
            }
            else if (arg[0] == "exp")
            {
                ExpertDocumentWorker x = new ExpertDocumentWorker();
                x.OpenDocument();
                x.EditDocument();
                x.SaveDocument();
            }
        }
    }

}

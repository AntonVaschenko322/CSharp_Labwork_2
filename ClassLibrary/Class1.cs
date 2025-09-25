namespace ClassLibrary
{
    //Задание 1
    public class Pupil
    {

        public Pupil(string name)
        {
            Name = name;   
        }
        public string Name { get; set; }
        protected virtual void Study()
        {
            Console.WriteLine("");
        }
        protected virtual void Read()
        {
            Console.WriteLine("");
        }
        protected virtual void Write()
        {
            Console.WriteLine("");
        }
        protected virtual void Relax()
        {
            Console.WriteLine("");
        }

        public void Descrip()
        {
            Console.WriteLine($"Name:  {Name} ");
            Console.Write("Studying: ");
            Study();
            Console.Write("Reading skills: ");
            Read();
            Console.Write("Writing skills: ");
            Write();
            Console.Write("Relax ways: ");
            Relax();
        }
    }

    public class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string name) : base(name) { }

        protected override void Read()
        {
            Console.WriteLine("Brilliant!!!");
        }

        protected override void Write()
        {
            Console.WriteLine("Awesome!");
        }

        protected override void Study()
        {
            Console.WriteLine("Delightful!");
        }

        protected override void Relax()
        {
            Console.WriteLine("Go touch some grass bro...");
        }
    }

    public class GoodPupil : Pupil
    {
        public GoodPupil(string name) : base(name) { }
        protected override void Read()
        {
            Console.WriteLine("Norm!!!");
        }

        protected override void Write()
        {
            Console.WriteLine("Ok!");
        }

        protected override void Study()
        {
            Console.WriteLine("Goood!");
        }

        protected override void Relax()
        {
            Console.WriteLine("Playing Deadlock");
        }
    }

    public class BadPupil : Pupil
    {
        public BadPupil(string name) : base(name) { }
        protected override void Read()
        {
            Console.WriteLine("Oh lord...");
        }

        protected override void Write()
        {
            Console.WriteLine("There are no words to describe it");
        }

        protected override void Study()
        {
            Console.WriteLine("Awful!");
        }

        protected override void Relax()
        {
            Console.WriteLine("Oh hell yeah!!! This guy knows how to relax)");
        }
    }


    public class Classroom
    {
        private Pupil[] clas = new Pupil[4]; 
        public Classroom(params Pupil[] arr)
        {
            clas = arr;
        }

        public void ClassDescrip()
        {
            foreach(Pupil x in clas)
            {
                x.Descrip();
            }
        }

    }


    //Задание 2
    public class Vehicle
    {
        protected double[] coord = new double[2];
        public int cost { get; set; }
        public int date { get; set; }
        public float speed { get; set; }

        public virtual void Print()
        {
            Console.WriteLine($"Стоимость: {cost}");
            Console.WriteLine($"Дата выпуска: {date}");
            Console.WriteLine($"Скорость: {speed}");
            Console.WriteLine($"Координаты: {coord[0]}, {coord[1]}");
        }
        public Vehicle(int cost, int date, float speed, double x_coord, double y_coord)
        {
            this.cost = cost;
            this.date = date;
            this.speed = speed;
            coord[0] = x_coord;
            coord[1] = y_coord;
        }
    }

    public class Plane : Vehicle
    {
        public int height { get; set; }
        public int count { get; set; }

        public Plane(int cost, int date, float speed, double x_coord, double y_coord, int height, int count) : base(cost, date, speed, x_coord, y_coord)
        {
            this.height = height;
            this.count = count;
        }

        public override void Print()
        {
            Console.WriteLine("Самолет");
            base.Print();
            Console.WriteLine($"Максимальная высота: {height}");
            Console.WriteLine($"Максимальное кол-во пассажиров: {count}");
        }
    }

    public class Car : Vehicle 
    {
        public Car(int cost, int date, float speed, double x_coord, double y_coord) : base(cost, date, speed, x_coord, y_coord)
        { }
        public override void Print()
        {
            Console.WriteLine("Машина");
            base.Print();
        }
    }

    public class Ship : Vehicle 
    {
        public int count { get; set; }
        public string name { get; set; }
        public Ship(int cost, int date, float speed, double x_coord, double y_coord, int count, string name) : base(cost, date, speed, x_coord, y_coord)
        {
            this.name = name;
            this.count = count;
        }

        public override void Print()
        {
            Console.WriteLine("Корабль");
            base.Print();
            Console.WriteLine($"Максимальное кол-во пассажиров: {count}");
            Console.WriteLine($"Порт приписки: {name}");
        }

    }

    //Задание 3

    public class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии PRO");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии PRO");
        }
    }

    public class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Дoкумент сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert ");
        }
    }

    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }





}
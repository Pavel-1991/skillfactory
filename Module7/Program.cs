namespace Module7
{
    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("A");
        }
    }
    class B:A 
    {
        public new void Display()
        {
            Console.WriteLine("B");
        }
    }
    class C:A 
    {
        public override void Display()
        {
            Console.WriteLine("C");
        }
    }
    class D:B
    {
        public new void Display() { Console.WriteLine("D"); }
    }
    class E:C
    {
        public new void Display() { Console.WriteLine("E"); }
    }

    //class BaseClass
    //{
    //    public int Counter
    //    {
    //        get;
    //        set;
    //    }
    //}

    //class DerivedClass : BaseClass
    //{
    //    public override int Counter
    //    {
    //        get
    //        {
    //            return Counter;
    //        }
    //        set
    //        {
    //            if (value > 0) { }
    //        }
    //    }
    //}
    //class BaseClass
    //{
    //    protected string Name;

    //    public BaseClass(string name)
    //    {
    //        Name = name;
    //    }
    //}

    //class DerivedClass : BaseClass
    //{
    //    public string Description;

    //    public int Counter;
    //    public DerivedClass(string name, string Description);
    //}

    //class SmartHelper
    //{
    //    private string name;

    //    public SmartHelper(string name)
    //    {
    //        this.name = name;
    //    }

    //    public void Greetings(string name)
    //    {
    //        Console.WriteLine("Привет, {0}, я интеллектуальный помощник {1}", name, this.name);
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();
            D d = new D();
            E e = new E();
            ((A)b).Display();
            ((A)c).Display();
            ((A)d).Display();
            ((A)e).Display();
            ((B)b).Display();
            //SmartHelper helper = new SmartHelper("Олег");
            //helper.Greetings("Грег");

            //Console.ReadKey();
        }
        //class Employee
        //{
        //    public string Name;
        //    public int Age;
        //    public int Salary;
        //}
        //class ProjectManager : Employee
        //{
        //    public string ProjectName;
        //}
        //class Developer : Employee
        //{
        //    public string ProgrammingLanguage;
        //}
        //class Obj
        //{
        //    private string name;
        //    private string owner;
        //    private int length;
        //    private int count;

        //    public Obj(string name, string ownerName, int objLength, int count)
        //    {
        //        this.name = name;
        //        owner = ownerName;
        //        length = objLength;
        //        this.count = count;
        //    }
        //}
    }
}
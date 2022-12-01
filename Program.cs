namespace encapsulation;
class Program
{
    static void Main(string[] args)
    {
        Student student=new Student();
        student.Name="Metehan";
        student.Surname="Metinoğlu";
        student.Ogrencino=16541053;
        student.Grade=3;
        student.StudentInformation();

        student.PassGrade();
        student.StudentInformation();

        Student student1=new Student("Ömer Talha","Metinoğlu",1223231,2);
        student1.LostGrade();
        student1.LostGrade();
        student1.StudentInformation();


    }
}
class Student
{
    private string name;
    private string surname;
    private int ogrencino;
    private int grade;

    public string Name { get => name; set => name = value; }
    public string Surname { get => surname; set => surname = value; }
    public int Ogrencino{get => ogrencino;set =>ogrencino=value;}
    public int Grade
    { 
        get => grade; 
        set
        {
            if(value<1)
            {
                Console.WriteLine("Sınıf en düşük 1 olabilir!");
                grade=1;
            }
            else
            {
                grade = value;
            }
            
        }
    }

    public Student(string name, string surname, int ogrencino, int grade)
    {
        Name = name;
        Surname = surname;
        Ogrencino = ogrencino;
        Grade = grade;
    }
    public Student()
    {

    }
    public void StudentInformation(){
        Console.WriteLine("************Öğrenci Bilgileri************");
        Console.WriteLine("Öğrenci Adı   :{0}",this.Name);
        Console.WriteLine("Öğrenci Soyadı:{0}",this.Surname);
        Console.WriteLine("Öğrenci No'su :{0}",this.Ogrencino);
        Console.WriteLine("Öğrenci Sınıfı:{0}",this.Grade);
    }
    public void PassGrade()
    {
        this.Grade+=1;
    }
    public void LostGrade()
    {
        this.Grade-=1;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Person
{
    private string _think;
    private string _name;
    private float _height;
    private float _weight;

    private static int _countPerson;

    protected float Height
    {
        get
        {
            return _height;
        }

        set
        {
            _height = value;
        }
    }

    protected float Weight
    {
        get
        {
            return _weight;
        }

        set
        {
            _weight = value;
        }
    }

    protected string Name
    {
        get
        {
            return _name;
        }

        set
        {
            _name = value;
        }
    }

    protected string Think
    {
        get
        {
            return _think;
        }

        set
        {
            _think = value;
        }
    }

    public Person(float height, float weight, string name, string think)
    {
        Height = height;
        Weight = weight;
        Name = name;
        Think = think;

        _countPerson++;
    }

    public Person(Person person)
    {
        Height = person.Height;
        Weight = person.Weight;
        Name = person.Name;
        Think = person.Think;

        _countPerson++;
    }

    public override bool Equals(Object obj)
    {
        if (!(obj is Person)) return false;
        var person = (Person)obj;

        if (Height == person.Height &&
            Name == person.Name &&
            Weight == person.Weight &&
            Think == person.Think)
            return true;
        else
            return false;
    }

    /*public bool Equals(float height, float weight, string name, string think)
    {
        if (Height == height &&
            Name == name &&
            Weight == weight &&
            Think == think)
            return true;
        else
            return false;
    }*/

    public override string ToString()
    {
        return $" Количество людей: {_countPerson}\n ФИО: {Name}\n Рост: {Height} сантиметров\n Вес: {Weight} килограмм\n О чем думает? {Think}\n";
    }
}

public class Student : Person
{
    private string _teach;
    private string _university;
    private string _faculty;
    private string _group;
    private bool _goToUniversity;

    public string Teach
    {
        get
        {
            return _teach;
        }

        set
        {
            _teach = value;
        }
    }

    public string University
    {
        get
        {
            return _university;
        }

        set
        {
            _university = value;
        }
    }

    public string Faculty
    {
        get
        {
            return _faculty;
        }

        set
        {
            _faculty = value;
        }
    }

    public string Group
    {
        get
        {
            return _group;
        }

        set
        {
            _group = value;
        }
    }

    public bool GoToUniversity
    {
        get
        {
            return _goToUniversity;
        }

        set
        {
            _goToUniversity = value;
        }
    }

    public Student(float height, float weight, string name, string think, string teach, string university, string faculty, string group, bool goToUniversity) : base(height, weight, name, think)
    {
        University = university;
        Faculty = faculty;
        Group = group;
        GoToUniversity = goToUniversity;
    }

    public Student(Student student) : base(student)
    {
        Teach = student.Teach;
        University = student.University;
        Faculty = student.Faculty;
        Group = student.Group;
        GoToUniversity = student.GoToUniversity;
    }

    public override bool Equals(Object obj)
    {
        if (!(obj is Student)) return false;
        var student = (Student)obj;

        if (Teach == student.Teach &&
            University == student.University &&
            Faculty == student.Faculty &&
            GoToUniversity == student.GoToUniversity &&
            base.Equals(obj))
            //base.Equals(student.Height, student.Weight, student.Name, student.Think))
            return true;
        else
            return false;
    }

    public override string ToString()
    {

        return base.ToString() + $" Что учит? {Teach}\n " +
            $"Университет: {University}\n " +
            $"Факультет: {Faculty}\n" +
            $" Группа: {Group}\n " +
            $"Ходит в универ? {GoToUniversity}\n";
    }
}

public class Teacher : Person
{
    private float _salary;
    private int _countWorkingHours;
    private string _power;
    private string _coreDiscipline;


    public float Salary
    {
        get
        {
            return _salary;
        }

        set
        {
            _salary = value;
        }
    }

    public int CountWorkingHours
    {
        get
        {
            return _countWorkingHours;
        }

        set
        {
            _countWorkingHours = value;
        }
    }

    public string Power
    {
        get
        {
            return _power;
        }

        set
        {
            _power = value;
        }
    }

    public string CoreDiscipline
    {
        get
        {
            return _coreDiscipline;
        }

        set
        {
            _coreDiscipline = value;
        }
    }

    public Teacher(float height, float weight, string name, string think, float salary, int countWorkingHours, string power, string coreDiscipline) : base(height, weight, name, think)
    {
        Salary = salary;
        CountWorkingHours = countWorkingHours;
        Power = power;
        CoreDiscipline = coreDiscipline;
    }

    public Teacher(Teacher teacher) : base(teacher)
    {
        Salary = teacher.Salary;
        CountWorkingHours = teacher.CountWorkingHours;
        Power = teacher.Power;
        CoreDiscipline = teacher.CoreDiscipline;
    }

    public override bool Equals(Object obj)
    {
        if (!(obj is Teacher)) return false;
        var teacher = (Teacher)obj;

        if (Salary == teacher.Salary &&
            CountWorkingHours == teacher.CountWorkingHours &&
            Power == teacher.Power &&
            CoreDiscipline == teacher.CoreDiscipline &&
            base.Equals(obj))
            //base.Equals(teacher.Height, teacher.Weight, teacher.Name, teacher.Think))
            return true;
        else
            return false;
    }

    public override string ToString()
    {
        return base.ToString() + $" Зарплата: {Salary} рублей\n" +
            $" Количество рабочих часов в неделю: {CountWorkingHours} часов\n" +
            $" Cтепень: {Power} дней\n" +
            $" Основная дисциплина: {CoreDiscipline}\n";
    }
}

public class HeadOfDepartment : Teacher
{
    private int _countSubordinatess;
    private float _teachingExperience;
    private bool _loveOfWork;
    private string _nameDepartment;

    public int CountSubordinatess
    {
        get
        {
            return _countSubordinatess;
        }

        set
        {
            _countSubordinatess = value;
        }
    }

    public float TeachingExperience
    {
        get
        {
            return _teachingExperience;
        }

        set
        {
            _teachingExperience = value;
        }
    }

    public bool LoveOfWork
    {
        get
        {
            return _loveOfWork;
        }

        set
        {
            _loveOfWork = value;
        }
    }

    public string NameDepartment
    {
        get
        {
            return _nameDepartment;
        }

        set
        {
            _nameDepartment = value;
        }
    }

    public HeadOfDepartment(float height, float weight, string name, string think, float salary, int countWorkingHours, string power, string coreDiscipline, int countSubordinatess, float teachingExperience, bool loveOfWork, string nameDepartment) : base(height, weight, name, think, salary, countWorkingHours, power, coreDiscipline)
    {
        CountSubordinatess = countSubordinatess;
        TeachingExperience = teachingExperience;
        LoveOfWork = loveOfWork;
        NameDepartment = nameDepartment;
    }

    public HeadOfDepartment(HeadOfDepartment headOfDepartment) : base(headOfDepartment)
    {
        CountSubordinatess = headOfDepartment.CountSubordinatess;
        TeachingExperience = headOfDepartment.TeachingExperience;
        LoveOfWork = headOfDepartment.LoveOfWork;
        NameDepartment = headOfDepartment.NameDepartment;
    }

    public override bool Equals(Object obj)
    {
        if (!(obj is HeadOfDepartment)) return false;
        var headOfDepartment = (HeadOfDepartment)obj;

        if (CountSubordinatess == headOfDepartment.CountSubordinatess &&
            TeachingExperience == headOfDepartment.TeachingExperience &&
            LoveOfWork == headOfDepartment.LoveOfWork &&
            NameDepartment == headOfDepartment.NameDepartment &&
            base.Equals(obj))
            //base.Equals(headOfDepartment.Salary, headOfDepartment.CountWorkingHours, headOfDepartment.Power, headOfDepartment.CoreDiscipline))
            //headOfDepartment.Height, headOfDepartment.Weight, headOfDepartment.Name, headOfDepartment.Think))
            return true;
        else
            return false;
    }

    public override string ToString()
    {
        return base.ToString() + $" Количество подчиненных: {CountSubordinatess} человек\n " +
            $"Стаж преподавателем: {TeachingExperience} лет\n " +
            $"Любит ли работу?: {LoveOfWork} лет\n " +
            $"Название кафедры: {NameDepartment}\n";
    }
}

class Program
{
    static void Main(string[] args)
    {
        var persons = new object[10];

        var student1 = new Student(170, 50, "Петров Петр Петрович", "О C#", "ООП", "ПГУ", "ФИТ", "18-ИТ-3", true);
        var student2 = new Student(192, 85, "Михайлов Михаил Милаилович", "О пиве", "СИАОД", "БГЭУ", "ИСФ", "19-ФМ", false);
        //var student3 = new Student("ЯП", "БНТУ", "МТФ", "18-ТР-2", false, 153, 62, "Иванов Иван Иваныч", "О JavaScript");
        var student3 = new Student(176, 56, "Гасан Гаснович Гаснов", "О работе", "C#", "БГУ", "РТФ", "17-РТ", true);
        var studentCopy = new Student(176, 56, "Гасан Гаснович Гаснов", "О работе", "C#", "БГУ", "РТФ", "17-РТ", true);

        var teacher1 = new Teacher(180, 60, "Давыдов Давыдович Давыденко", "О многом", 1000, 45, "Бакалавр", "Математика");
        var teacher2 = new Teacher(169, 56, "Петров Барис Иванович", "О детях", 600, 75, "Профессор", "Физика");
        var teacher3 = new Teacher(188, 74, "Галеева Борина Адамовна", "О деньгах", 800, 120, "Магистр", "Языки программирования");

        var headOfDepartment1 = new HeadOfDepartment(199, 91, "Поздняков Весемир Игорьевич", "О власти", 800, 120, "Магистр", "Языки программирования", 4, 10, true, "Кафедра ИСФ");
        var headOfDepartment2 = new HeadOfDepartment(157, 75, "Азаренко Борислав Валерьевич", "О многом", 800, 120, "Магистр", "Языки программирования", 5, 20, false, "Кафедра РТФ");
        var headOfDepartment3 = new HeadOfDepartment(183, 72, "Комарович Анжей Максимович", "О пиве", 800, 120, "Магистр", "Языки программирования", 8, 15, true, "Кафедра ГФ");
        var headOfDepartment4 = new HeadOfDepartment(155, 45, "Фетченко Владислава Кирилловна", "О JavaScript", 800, 120, "Магистр", "Языки программирования", 10, 30, false, "Кафедра ФИТ");

        var headOfteacherCopy = new Teacher(180, 60, "Давыдов Давыдович Давыденко", "О многом", 1000, 45, "Бакалавр", "Математика");

        persons[0] = student1;
        persons[1] = student2;
        persons[2] = student3;

        persons[3] = teacher1;
        persons[4] = teacher2;
        persons[5] = teacher3;

        persons[6] = headOfDepartment1;
        persons[7] = headOfDepartment2;
        persons[8] = headOfDepartment3;
        persons[9] = headOfDepartment4;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(persons[i]);
        }
        HeadOfDepartment naiti = new HeadOfDepartment(155, 45, "Фетченко Владислава Кирилловна", "О JavaScript", 800, 120, "Магистр", "Языки программирования", 10, 30, false, "Кафедра ФИТ");
        for (int i = 0; i < 10; i++)
        {
            if (persons[i].Equals(naiti) == true)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("найденный объект");
                Console.WriteLine(persons[i]);

            }
        }

        /*foreach (var person in persons)
        {
            Console.WriteLine(person);

            if (person is Student)
            {
                var teacher = (Student)person;
                Console.WriteLine($" Объекты равны? { teacher.Equals(new Student(176, 56, "Гасан Гаснович Гаснов", "О работе", "C#", "БГУ", "РТФ", "17-РТ", true))}");
                Console.WriteLine();
            }
        }*/

        Console.ReadKey();
    }
}


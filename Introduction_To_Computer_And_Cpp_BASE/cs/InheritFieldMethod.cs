using System;
public class Person
{
    public string name;//定义域
    public int age;
    virtual public void SayHello(){//定义方法 //virtual 表示可以被子类override
        
        Console.WriteLine("Hello! My name is" + name);

    }

    public void SayHello(Person another){//构造方法重载同名的sayHello方法
        Console.WriteLine("Hello" + another.name +
        "! My name is" + name);

    }

    public bool IsOlderThan(int anAge){//定义方法
        bool flg;
        if (age > anAge) flg = true; else flg = false;
        return flg;

    }

    public Person(string n, int a){//构造方法
        name = n;
        age = a;

    }

    public Person(string n){//构造方法重载
        name = n;
        age = -1;

    }

    public Person() : this("", 0)//调用其他构造方法
    {

    }

    public class Student : Person //定义子类
    {
        public string school; //增加的字段
        public int score = 0;

        public bool isGoodStudent() //增加的方法
        {
            return score >= 90;

        }

        public override void SayHello() //override覆盖父类的方法
        {
            base.SayHello();

            Console.WriteLine("My school is" + school);

        }

        public void SayHello(Student another) //增加的方法
        {
            Console.WriteLine("Hi!");

            if (school == another.school)

                Console.WriteLine("schoolmate");

        }

        public Student(){//构造方法

        }

        public Student(string name, int age, string school)
        :base(name, age) //调用父类的构造方法
        {
            this.school = school;
        }

        public void TestThisSuper()
        {
            int a;
            a = age; //本句与一下两句效果相同

            a = this.age; //使用this

            a = base.age; //使用base

        }

        public static void Main(string[] arggs)
        {
            Person p = new Person("Liming", 50);
            Student s = new Student("Wangqiang", 20, "PKU");
            Person p2 = new Student("Zhangye", 18, "THU");
            Student s2 = (Student)p2;
        }

    }
}

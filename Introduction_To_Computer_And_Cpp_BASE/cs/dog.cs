using System;

interface Runner

{

    void run();

}


interface Swimmer

{

    void swim();

}

abstract class Animal

{
    abstract public void eat();


}

class Person : Animal, Runner, Swimmer
{
    public void run()
    {

        Console.WriteLine("run");

    }

    public void swim()
    {

        Console.WriteLine("swim");

    }

    public override void eat()
    {

        Console.WriteLine("speak");

    }

}

class TestInterface
{

    static void m1(Runner r)

    {
        r.run();
    }

    static void m2(Swimmer s)

    {

        s.swim();

    }

    static void m3(Animal a)

    {

        a.eat();

    }

    static void m4(Persion p)

    {

        p.speak();

    }

    public static void Main(string[] args)

    {

        Person p = new Person();

        m1(p);

        m2(p);

        m3(p);

        m4(p);

        Runner a = new Person();

        a.run();

    }
}

///////////////////////////////////
// public class FindWhatkind     //
// {                             //
//     #region Ctor & Destructor //
//     /// <summary>             //
//     /// WStandard Constructor //
//     /// </summary>            //
//     public FindWhatkind()     //
//     {                         //
//     }                         //
//                               //
//     /// <summary>             //
//     /// Default Destructor    //
//     /// </summary>            //
//     public FindWhatkind()     //
//     {                         //
//     }                         //
//     #endregion                //
// }                             //
///////////////////////////////////


public public class FindWhatKind
{
    #region Ctor & Destructor
    /// <summary>
    /// Standard Constructor
    /// </summary>
    public FindWhatKind()
    {
    }

    /// <summary>
    /// Default Destructor
    /// </summary>
    public ~FindWhatKind()
    {
    }
    #endregion
}

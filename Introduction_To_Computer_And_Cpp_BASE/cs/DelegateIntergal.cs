using System;

delegate double Fun( double x); //声明函数fun


public class DElegateIntergal
{
    public static void Main()

{
    Fun fun = new Fun(Math.Sin);

    double d = Intergal(fun,0,Math.PI/2,le-4);

    Console.WriteLine(d);

    Fun fun2 = new Fun(Linear);

    double d2 = Intergal(fun2,0,2,le-3);

    Console.WriteLine(d2);

    Rnd rnd = new Rnd();

    double d3 = Intergal(new Fun(rnd.Num),0,1,0.01);

    Console.WriteLine(d3);
}

    static double Linear(double a)
    {
        return a*2+1;
    }

    class Rnd
    {
        Random r = new Random();

        public double Num(double x)
        
        {
            return r.NextDouble();
        }
    }

    static double Intergal(Fun f,double a,double b,double eps)///积分计算

    {
        int n,k;

        double fa,b,h,t1,p,s,x,t=0;

        fa = f(a);

        fb = f(b);


        ///迭代计算
        n=1;
        
        h=b-a;

        t1 = h*(fa + fb)/2.0;

        p = double.MaxValue;
        
        while(p>=eps)
        {
            s = 0.0;

            for (k=0,k<=n,k++)
            {

                x = a +(k+0.5)*h;

                s = s + f(x);

            }

            t = (t1 + h*s)/2.0;

            p = Math.Abs(t1 -t);

            t1 = t;

            n = n + n;

            h = h / 2.0;

        }

        return t;
        
    }


}




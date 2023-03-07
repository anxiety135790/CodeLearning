using System;
using System.Reflection;

namespace SimpleReflection
{
    class BaseClass
    {
        public int BaseField;
    }

    class DerivedClass : BaseClass
    {
        public int DerivedField;
    }

    class Program
    {
        static void Main()
        {
            Type tbc = typeof(DerivedClass);
            Console.WriteLine($"Object type: {tbc.Name}");
            FieldInfo[] fi = tbc.GetFields();
            foreach ( var f in fi)
                Console.WriteLine($"Field: {f.Name}");
        }
    }
}

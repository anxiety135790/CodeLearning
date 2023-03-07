class D
{
    /// <summary>
    /// Declare instance fields Mem1 and Mem2
    /// </summary>
    int Mem1;
    static int Mem2;

    public void SetVars(int v1, int v2)
    {
        /// <summary>
        /// Set the values of Mem1 and Mem2
        /// </summary>
        
        Mem1 = v1;
        Mem2 = v2;
    }

    public void Display(string str)
    {
        /// <summary>
        /// Display the values of Mem1 and Mem2
        /// </summary>
        /// <value></value>
        
        Console.WriteLine("Mem1 = {0}, Mem2 = {1}", Mem1, Mem2);
    }

    class Program
    {
        static void Main()
        {
            /// <summary>
            /// d1 and d2 are instance objects
            /// Mem1 is an instance field
            /// Mem2 is a static field
            /// SetVars() is an instance method
            /// Display() is an instance method
            /// </summary>
            /// <returns></returns>
            

            D d1 = new D();
            D d2 = new D();
            d1.SetVars(2, 4);
            d1.Display("d1");
            d2.SetVars(3, 4);
            d2.Display("d2");
        }
    }
}
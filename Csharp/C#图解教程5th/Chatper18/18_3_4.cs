class MyStack<T>
{
    T[] StackArray;
    int StackPointer = 0;

    public void Push(T x) //
    {
        if (!IsStackFull) // StackPointer is not incremented before the assignment
        {
            StackArray[StackPointer++] = x; // StackPointer is incremented after the assignment
        }
    }

    public T Pop()
    {
        return (!IsStackEmpty) ? StackArray[--StackPointer] : StackArray[0];
    }


    const int MaxStack = 10;
    bool IsStackFull { get { return  StackPointer >= MaxStack; } } //
    bool IsStackEmpty { get { return StackPointer <= 0; } }

    public MyStack()
    {
        StackArray = new T[MaxStack];

    }

    public void Print()
    {
        for (int i = StackPointer -1 ; i >= 0; i--)
        {
            Console.WriteLine(StackArray[i]);
        }
    }


}

class Program
{
    static void Main()
    {
        MyStack<int> MyIntStack = new MyStack<int>();
        MyStack<string> MyStringStack = new MyStack<string>();

        MyIntStack.Push(3);
        MyIntStack.Push(5);
        MyIntStack.Push(7);
        MyIntStack.Push(9);
        MyIntStack.Print();

        MyStringStack.Push("Hello");
        MyStringStack.Push("World");
        MyStringStack.Print();
    }
}

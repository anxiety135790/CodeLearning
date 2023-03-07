class C1
{
    private int theRealValue; //字段：私有的，只能在类内部访问

    public int MyValue // 属性：公有的，可以在类外部访问
    {
        get { return theRealValue; }
        set { theRealValue = value; }
    }
}
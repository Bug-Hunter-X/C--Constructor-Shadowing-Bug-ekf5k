public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        // Bug: Incorrect assignment.  Should be this.MyProperty = value;
        MyProperty = value; //The bug is here. It should be this.MyProperty = value;
    }
}
public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Initialize the property before use
        MyProperty = 10; 
        int result = MyProperty * 2; // Now the calculation will be correct
    }
}
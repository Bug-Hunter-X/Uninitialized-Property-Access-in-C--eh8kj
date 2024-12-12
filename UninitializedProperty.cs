public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property before it's initialized can lead to unexpected behavior or exceptions, especially if the property is used in calculations or conditions.
        int result = MyProperty * 2; // Potential error: MyProperty might not be initialized
    }
}
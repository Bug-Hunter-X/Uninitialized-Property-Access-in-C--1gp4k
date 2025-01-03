public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Initialize the property before accessing it
        MyProperty = 0; // Or another appropriate default value
        int value = MyProperty; 
    }
}
namespace Assignment_OOP_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Q1 Object Copying
            //a) What happens when you assign one object variable to another object variable?
            // both variables refer to the same object in memory. Changes made through one variable will affect the other since they point to the same instance.
            //---------------------------------------------
            //b) Does assigning one object to another create a new object? Explain
            // No, assigning one object to another does not create a new object. It simply copies the reference to the existing object, so both variables point to the same instance in memory.
            //---------------------------------------------
            //c) What is the difference between copying an object and copying its reference?
            // Copying an object creates a new instance of the object with the same values, while copying its reference means both variables point to the same instance in memory. Changes made through one reference will affect the other if they share the same object.
            #endregion
            #endregion
        }
    }
}

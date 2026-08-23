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

            #region Q2 Shallow Copy vs Deep Copy
            //a) What is a Shallow Copy?
            // A shallow copy creates a new object, but it copies the references of the original object's fields. If the original object contains references to other objects,
            // the shallow copy will point to the same referenced objects, not create new instances of them.
            //---------------------------------------------
            //b) What is a Deep Copy?
            // A deep copy creates a new object and recursively copies all the fields of the original object,
            // including any referenced objects. This means that the new object is completely independent of the original object,
            // and changes made to one will not affect the other.
            //---------------------------------------------
            //c) What happens to reference-type members when a Shallow Copy is created?
            // When a shallow copy is created, reference-type members of the original object are not duplicated. Instead, the shallow copy will contain references to the same objects as the original. Therefore, if you modify a reference-type member in the shallow copy,
            // it will also affect the original object since both share the same reference.
            //---------------------------------------------
            //d) What happens to reference-type members when a Deep Copy is created?
            //  reference-type members of the original object are also duplicated. The deep copy will create new instances of the referenced objects,
            //  so changes made to the reference-type members in the deep copy will not affect the original object, and vice versa.
            //---------------------------------------------
            //e) Give one situation where Deep Copy would be safer than Shallow Copy.
            // Deep Copy would be safer in situations where you need to ensure that the copied object is completely independent of the original object,
            // such as when working with mutable objects that may be modified in different parts of a program. For example, if you have a complex data structure like a tree or graph and you want to create a copy to manipulate without affecting the original structure,
            // a deep copy would be necessary to avoid unintended side effects.

            #endregion
            #endregion
        }
    }
}

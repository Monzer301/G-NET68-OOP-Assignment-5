using System.Reflection.Metadata;

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

            #region Q3 Static Members
            //a) What is a static field, and how is it different from an instance field?
            // A static field is a variable that belongs to the class itself rather than any specific instance of the class.
            // It is shared among all instances of the class, meaning that there is only one copy of the static field for the entire class.
            // In contrast, an instance field is unique to each object created from the class, and each instance has its own copy of the instance field.
            //---------------------------------------------
            //b) What is a static method? Can a static method directly access instance members?
            // A static method belongs to the class itself rather than any specific instance of the class.
            // It cannot directly access instance members because it does not have access to the instance context.
            // However, it can access other static members of the class.
            //---------------------------------------------
            //c) What is a static constructor, and when is it executed?
            // It is a special constructor that is used to initialize static members of a class.
            // It is executed automatically by the runtime before any static members are accessed or any instances of the class are created.
            // It is called only once for the entire class, and it cannot take parameters or have access modifiers.
            //---------------------------------------------
            //d) What is a static class? Can you create an object from a static class?
            // A static class is a class that can only contain static members and cannot be instantiated. It is used to group related static methods and fields together.
            // You cannot create an object from a static class because it does not have any instance members or constructors. 
            #endregion

            #region Q4 Extension Methods
            //a) What is an Extension Method?
            // An extension method is a special kind of static method that allows you to "add" new methods to existing types without modifying the original type or creating a new derived type.
            //---------------------------------------------
            // b) What keyword must be used in the first parameter of an extension method ?
            // The first parameter of an extension method must use the "this" keyword, followed by the type that you want to extend. This indicates that the method is an extension method for that type.
            //---------------------------------------------
            //c) Where must an extension method be declared?
            // An extension method must be declared in a static class and must be defined as a static method with the "this" keyword as the first parameter.
            //---------------------------------------------
            //d) Can an extension method access private members of the class it extends?
            // No, an extension method cannot access private members of the class it extends. It can only access public and protected members of the class, as well as any other accessible members based on the visibility rules of the language.
            #endregion

            #region Q5 Partial Classes and Partial Methods
            //a) What is a Partial Class?
            // A partial class is a class that can be split into multiple files, allowing different parts of the class to be defined in separate files.
            // This can be useful for organizing code, especially in large projects or when working with auto-generated code.
            //---------------------------------------------
            //b) Why would a developer split one class into multiple files?
            // A developer might split a class into multiple files to improve code organization, maintainability, and readability.
            //---------------------------------------------
            //c) What is a Partial Method?
            // A partial method is a method that can be defined in one part of a partial class and implemented in another part of the same partial class.
            // This allows for more flexible code organization, especially when working with auto-generated code.
            //---------------------------------------------
            //d) What happens if a declared partial method has no implementation?
            // If a declared partial method has no implementation, the compiler will remove the method declaration and any calls to it from the compiled code.
            #endregion
            #endregion
        }
    }
}

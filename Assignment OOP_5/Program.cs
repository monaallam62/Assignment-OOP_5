namespace Assignment_OOP_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //Q1 : What is an interface in C#? Why do we use interfaces instead of depending on concrete classes directly? Mention at least three benefits of using interfaces.
            // An interface defines a contract that a class must follow and defines a set of methods, properties, or events that a class must implement It specifies what a class should do, but not how it should do it
            // Loose Coupling,multiple Implementations,easier Testing
            //Enable polymorphism without inheritance ,remove tight coupling between classes,enable multiple inheritance
            #endregion
            #region Question 2
            //a) What is the problem with this design? Both interfaces have a method called Greet() — how does the class handle it currently?
            //Both interfaces define a method called Greet(), but the Translator class provides only one implementation ,the class cannot provide different behavior for each interface
            //==============================================================
            //b) How would you fix this so IEnglishSpeaker.Greet() says "Hello" and IArabicSpeaker.Greet() says "Ahlan"? What is this technique called?
            //We can fix it using Explicit Interface Implementation,This technique allows a class to provide different implementations for methods with the same name from different interfaces
            //Technique name: Explicit Interface Implementation
            //==============================================================
            //c) After applying your fix, can you call Greet() directly on a Translator object (e.g. translator.Greet())? Why or why not? How do you call each version?
            //No we cannot call it directly Because the methods are implemented explicitly, they are only accessible through the interface type
            //Calling the English version
            //IEnglishSpeaker eng = new Translator();
            //eng.Greet(); // Hello
            //Calling the Arabic version
            //IArabicSpeaker ar = new Translator();
            //ar.Greet(); // Ahlan
            #endregion
            #region Question 3
            //Q3 : Explain the difference between a shallow copy and a deep copy. When would you use each one? What is the risk of using a shallow copy when the object has reference-type fields?
            //Shallow Copy
            //A shallow copy creates a new object but copies only the values of the fields ,If a field is a reference type, only the reference is copied, not the actual object both objects will reference the same inner object
            //Deep Copy
            //A deep copy creates a completely independent copy of the object, including all referenced objects,Changes to one object do not affect the other
            //------------------------------------------------------------
            //Shallow → object is immutable, no nested reference state, performance is critical
            //Deep → objects must be isolated, modifications should not affect original
            //------------------------------------------------------------
            //If the object contains reference-type fields, modifying the referenced object in one copy will affect the other copy because both references point to the same object.
            #endregion
        }
    }
}

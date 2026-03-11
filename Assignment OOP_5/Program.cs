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
        }
    }
}

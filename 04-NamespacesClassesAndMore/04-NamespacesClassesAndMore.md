**What are namespaces?**
A way to organize classes

**What are classes?**
A representation of a thing or idea.
Encapsulation of functionality

**What are methods?**
A place to process or manipulate data

**What is a constructor?**
A special method that runs with a new instance of the object is created

# Demo
```
namespace NamespacesClassesAndMore
{
    public class Processor
    {
        public Processor()
        {

        }

        public void Process()
        {

        }
    }
}
```

**What are variables?**
a representation of data that can change during the course of application execution

**What are constants?**
a representation of data that will not change during application execution

**What are properties?**


```
namespace NamespacesClassesAndMore
{
    public class Processor
    {
        public const string SpecialValue = "ABC";

        public Processor()
        {

        }

        public string Status { get; set; }

        public void StartProcessing()
        {
            Status = "Running";
        }

        public void StopProcessing()
        {
            Status = "Not Running";
        }
    }
}
```

**What are access modifiers?**
A way to control what can see an work with your data, whether that be a class, method, or variable/constant

**What is an interface?**
Interfaces are specifications as to what classes properties and methods must implemented
# Reference Types vs Value Types

**What is a type?**
It is a representation of data such as a number, string, boolean, or real world object

**What are some data types?**
integer - whole number
long - big whole number
float - floating point number
double - big floating point number
decimal - precision number
char - a single character
string - N characters (a word)
bool - boolean (true/false)
object

**Which of those types are value types?**
integer
long
float
double
decimal
char
bool

**Which of those types are reference types?**
string
object

**What is a value type?**
It is a data type that is stores the actual value
__Typically__ value types are stored directly on the application stack, but there are exceptions
A value type is copied from one place to another

**What is a reference type?**
It is a data type that stores a reference to the actual value
__Typically__ reference types are stored in the application heap, but there are exceptions
A reference type copies the reference not the value

## Demo

**Value Types**

~~~
int i = 7;
int j = 8;

i = j;
j = 9;

Console.WriteLine("i: " + i);
Console.WriteLine("j: " + j);
~~~

What should the value of i going to be?

**Reference Types**

~~~
public class Demo
{
	public int Id {get;set;}
	public string Name {get;set;}
}

Demo i = new Demo{Id = 7; Name = "7"};
Demo j = new Demo{Id = 8; Name = "8"};

i = j;
j.Name = "9";

Console.WriteLine("i: " + i.Name);
Console.WriteLine("j: " + j.Name);
~~~

What should the value of i going to be?
Why is the value of i different here compared to the value type demo?

**Closing the Loop**
- Strings are special case reference types in that they are handles like value types
- Strings are a reference type because they are essentially unlimited in size but a value type because we want them to be immuatable
- The file extensions are .md which is markdown. It is a standard that formats documents using characters
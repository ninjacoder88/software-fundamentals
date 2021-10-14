# Reference Types vs Value Types

**What is a type?**
A type is a representation of data.

**What sort of data can be represented in software?**
Numbers, strings, booleans, with everything falling into "objects"

**What are some data types in C# and what do they represent?**
integer (int) - whole number => 2,147,483,647
long - big whole number => 18,446,744,073,709,551,615
float - floating point number 
double - big floating point number => 10001.11010011
decimal - precision number => 123.45
char - a single character => A 1 $
string - N characters (a word/phrase/sentence/etc) => "A sentenence"
bool - boolean => true/false
object

**What are the commonly used value types?**
integer (int)
long
float
double
decimal
char
bool

**Which of those types are reference types?**
string __kind of__
object

**What is a value type?**
A value type is a data type where the actual value is stored __on the application stack__ and is immuatable (meaning the value can't be changed)
You will often hear that value types are stored on the stack, but that is not always true.
A vaule type is copied from one memory location to another

**What is a reference type?**
A reference type is a data type where the actual value is stored __in the application heap__ and a reference to that object is stored __on the application stack__
A reference to the object is stored and the reference is copied not the object.
You will often hear that reference types are stored on the heap, but there are exceptions.

**Why are strings "kind of" reference types?**
Strings are special case reference types in that the data is stored on the heap because a string can be very large (in terms of memory) so we don't want to blow up the stack (stack overflow), however similar to value types, we want our strings to be immuatable


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
- The file extensions are .md which is markdown. It is a standard that formats documents using characters
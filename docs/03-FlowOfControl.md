**What is flow of control?**
Flow of control is how the program flows and how to make decision

if, else, switch

# Demo
```
Console.WriteLine("Start");

int a = 2;
int b = 3;
int result = a + b;

if(result == 5)
{
	Console.WriteLine("5");
}

Console.WriteLine("Not 5");

/**/

if(result == 5)
{
	Console.WriteLine("5");
}
else
{
	Console.WriteLine("Not 5");
}

Console.WriteLine("Everytime");

/**/

switch(result)
	case 3:
		Console.WriteLine("3");
		break;
	case 4:
		Console.WriteLine("4");
		break;
	case 5:
		Console.WriteLine("5");
		break;
	default:
		Console.WriteLine("Not Handled");
		break;

```

for, foreach, while, do...while

# Demo
```
for(int i = 0; i < 10; i++)
{
	if(i % 2 == 0)
	{
		Console.WriteLine(i);
		continue;
	}
}

int[] array = new int[5];
foreach(int i in array)
{

}

Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
while(queue.Count)
{
	var v = queue.Peek();
	
	if(v == 2)
		break;
	
	queue.Dequeue();
}

do
{

} while()
```

break, continue

**What are operators?**
Operators are symbols that represent logic such as and, or, not, etc
! - Not
&& - And
|| - Or
+=, *=, -= - 
++
== - Equals
= - Assignment
< > - LT, GT
% - Mod

**What is a class**
A representation of some sort of an object. 
At runtimes we call them objects. At compile time we call it a class

**What are access modifiers?**
They are keywords that control the access of a class, method, or variable
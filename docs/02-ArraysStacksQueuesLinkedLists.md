**What is an array?**
A data structure that holds a group of items

**What is an array used for?**
Managing a list of data

## Demo

~~~
int[] array = new int[3];
array[0] = 5;
array[1] = 8;
~~~

**What is a stack?**
A data structure that manages data in a First In Last Out (FILO) or Last In First Out (LIFO) manner
Has 3 important methods: Push, Pop, Peek

**What is a stack used for?**
Processing data as it comes in, where the most recent item is processed next
Retry transfers that just failed
Depth First Search algorithm
Application management (application stack)

## Demo

~~~
Stack<string> stack = new Stack<string>();
stack.Push("A");
stack.Push("B");
stack.Pop();
stack.Push("C");
stack.Pop();
stack.Pop();
~~~

**What is a queue?**
A data structure that manages data in a First In First Out (FIFO) or Last In Last Out (LILO) manner
Has 3 important methods: Enqueue, Dequeue, Peek

**What is a queue used for?**
Processing data in the order it came in
Line (queue) at a store or amusement park
Breadth First Search algorithm

# Demo

~~~
Queue<string> queue = new Queue<string>();
queue.Enqueue("A");
queue.Enqueue("B");
queue.Dequeue();
queue.Enqueue("C");
queue.Dequeue();
queue.Dequeue();
~~~

**What is a linked list?**
A data structure that manages data by linking together nodes
There are two types of linked lists: (singly) linked list, doubly linked list

**What is a linked list used for?**
Managing data that needs to be traversed in steps, one at a time

# Demo

~~~
LinkedList<string> linkedList = new LinkedList<string>();
linkedList.AddLast(new LinkedListNode<string>("A"));
linkedList.AddLast(new LinkedListNode<string>("B"));
linkedList.AddLast(new LinkedListNode<string>("C"));
~~~

//Request and take user input


using System.Collections;

Console.WriteLine("Hello, please enter a string:");
var response = Console.ReadLine();
Console.WriteLine(StringReverseUsingStack(response));


 static string StringReverseUsingStack(string str)
{
    var reversedStr = "";
    Stack myStack = new Stack();
    foreach(var t in str)
    myStack.Push(t);
    while(myStack.Count > 0)
        reversedStr += myStack.Pop();
    return reversedStr;
}
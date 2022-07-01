//Using statements
using System.Collections;

//Running bool
bool isrunning = true;


do
{
    //Greet and prompt user
    Console.WriteLine("Hello, please enter a string:");

    //take response
    string response = Console.ReadLine();

    //variables
    string[] sentence = response.Split(" ");
    string result = "";

    //Validate user input
    try
    {
        while (true)
        {

            response = Console.ReadLine();
            if (result.All(c => Char.IsLetter(c) == true))
            {
                //foreach loop to reverse sentence correctly
                foreach (string s in sentence)
                {
                    result += StringReverseUsingStack(s) + " ";

                }
                Console.WriteLine(result);
                break;
            }
            else
            {
                throw new Exception("Please do not enter any numbers or symbols. Try again");
                continue;
            }

        }



    }
    catch (FormatException e)
    {
        Console.WriteLine(e.Message);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }

    //Ask user if they'd like to loop again
    Console.WriteLine("Would you like to try again? (y/n)");
    if(Console.ReadLine().ToLower().Trim() == "y")
    {
        continue;
    }
    else
    {
        isrunning = false;
    }
}
while (isrunning);





//reverse method using Stack
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
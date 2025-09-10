using System;

namespace TheStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool inuse = true;
            var varStack = new GStack<int>();

            


            while (inuse == true)
            {
                Console.Write("do you want to get the count, push, pop or peek the stack: ");
                string choose = Console.ReadLine().ToLower();
                if(choose == "count")
                {
                    Console.WriteLine($"the current count is {varStack.Count()}");
                }
                else if (choose == "push")
                {
                    Console.WriteLine($"the current datatype is {varStack.CurrentType()}");
                    Console.Write("what do you want to push to the stack:");
                    try
                    {
                        var toPush = Console.ReadLine();
                        varStack.Push(Convert.ToInt32(toPush));
                    }
                    catch
                    {
                        Console.WriteLine("that does not match the datatype of the stack");
                    }


                }
                else if (choose == "pop")
                {
                    if (varStack.Count() > 0)
                    {
                        Console.WriteLine($"{varStack.Pop()} has been poped from the stack");
                    }
                    else
                    {
                        Console.WriteLine("their is currently nothing in the stack to pop");
                    }
                }
               else  if (choose == "peek")
                {
                    Console.WriteLine($"{varStack.Peek()} is currently at the top of the stack");
                }
                else
                {
                    Console.WriteLine("that was not one of the options");
                }


                Console.Write("do you want to continue or stop for now: ");
                string toStopOrNot = Console.ReadLine().ToLower();
                if (toStopOrNot == "stop")
                {
                    inuse = false;
                }
            }
                




        }
    }
}

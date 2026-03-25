using System;
using System.Collections.Generic;
using System.Text;

namespace C__Collections_Assignments
{
    internal class Assignment4
    {
        static void Main()
        {
            Stack<string> actions = new Stack<string>();
            Stack<string> redoStack = new Stack<string>();

            Console.Write("Enter number of actions: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter action: ");
                string action = Console.ReadLine();
                actions.Push(action);
            }

            Console.Write("\nHow many actions to undo: ");
            int undoCount = int.Parse(Console.ReadLine());

            Console.WriteLine("\nUndo Actions:");
            for (int i = 0; i < undoCount; i++)
            {
                if (actions.Count > 0)
                {
                    string undone = actions.Pop();
                    redoStack.Push(undone);
                    Console.WriteLine("Undo: " + undone);
                }
            }

            if (actions.Count > 0)
            {
                Console.WriteLine("\nCurrent Top Action: " + actions.Peek());
            }
            else
            {
                Console.WriteLine("\nNo actions left");
            }

            Console.Write("\nDo you want to redo? (yes/no): ");
            string choice = Console.ReadLine();

            if (choice.ToLower() == "yes")
            {
                Console.WriteLine("\nRedo Actions:");
                while (redoStack.Count > 0)
                {
                    string redo = redoStack.Pop();
                    actions.Push(redo);
                    Console.WriteLine("Redo: " + redo);
                }
            }

        }
    }
}

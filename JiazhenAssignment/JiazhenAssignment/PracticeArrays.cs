using System.Collections;

namespace JiazhenAssignment;

public class PracticeArrays
{

    public T[] CopyArray<T>(T[] originalArray)
    {
        T[] newArray =new T[originalArray.Length];
        for (int i = 0; i < originalArray.Length; i++)
        {
            newArray[i]=originalArray[i];
        }
        return newArray;
    }

    public void ToDoList()
    {
        ArrayList toDoList = new ArrayList();
        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear, 0 to exit)):");
            string command = Console.ReadLine();
            if (string.IsNullOrEmpty(command))
            {
                Console.WriteLine("Command is empty");
                continue;
            }
            if (command[0] == '+')
            {
                string item = command.Substring(1).Trim();
                if (!string.IsNullOrEmpty(item))
                {
                    toDoList.Add(item);
                    Console.WriteLine($"Added {item}");
                }
                else
                {
                    Console.WriteLine("No item added");
                }
                
            }
            else if (command[0] == '-' && command[1] != '-')
            {
                string item = command.Substring(1).Trim();
                if (toDoList.Contains(item))
                {
                    toDoList.Remove(item);
                    Console.WriteLine($"Removed {item}");
                }
                else
                {
                    Console.WriteLine("Not found item");
                }
            }
            else if (command == "--")
            {
                toDoList.Clear();
                Console.WriteLine("Cleared list");
            }
            else if (command == "0")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid command");
            }
            Console.WriteLine("To do list: " + 
                              (toDoList.Count>0? string.Join(", ",toDoList.ToArray()) : "Empty List"));
            
        }
    }
}

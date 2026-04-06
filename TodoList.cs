using System;

public class TodoList
{
    public static string[] tasks = new string[10];
    public static int taskCount = 0;
    public static void AddTask()
    {
        if (taskCount >= tasks.Length)
        {
            Console.WriteLine("You have exceeded the array limit");
            return;
        }
        Console.WriteLine("Enter a new task:");
        tasks[taskCount] = Console.ReadLine();
        taskCount++;
    }
    public static void ViewTasks()
    {
        Console.WriteLine("Your tasks:");

        for(int i = 0; i< taskCount; i++)
        {
            Console.WriteLine((i+1) + "." + tasks[i]);
        }
    }
    public static void CompleteTask()
    {
        Console.WriteLine("Enter the number of the task to mark as complete:");
        int taskNumber = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine("Task" + (taskCount) + "of" + tasks.Count());
        if (taskNumber >= 0 && taskNumber < taskCount)
        {
            tasks[taskNumber] = tasks[taskNumber] + "(Completed)";
            Console.WriteLine("Task marked as complete.");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }
}
using System;
using System.Threading;

abstract class Activity
{
    protected string Name;
    protected string Description;
    protected int Duration;

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Starting {Name} activity. {Description}");
        Console.Write("Enter the duration of the activity in seconds: ");
        Duration = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    public abstract void DoActivity();

    public void EndActivity()
    {
        Console.WriteLine("You have done a good job!");
        Thread.Sleep(2000); // Pause for 2 seconds
        Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
        Thread.Sleep(2000); // Pause for 2 seconds
    }
}

class BreathingActivity : Activity
{
 public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public override void DoActivity()
    {
        StartActivity();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        bool breatheIn = true;

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(breatheIn ? "Breathe in..." : "Breathe out...");
            breatheIn = !breatheIn; // Switch between "Breathe in..." and "Breathe out..."

            for (int i = 0; i < 5; i++) // Pause for 3 seconds with a spinner
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        EndActivity();
    }
}




class ReflectionActivity : Activity
{
private string[] prompts = new string[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = new string[]
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") { }

    public override void DoActivity()
    {
        StartActivity();
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            string question = questions[random.Next(questions.Length)];
            Console.WriteLine(question);
            for (int i = 0; i < 10; i++) // Pause for 3 seconds with a spinner
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        EndActivity();
    }
}

class ListingActivity : Activity
{
private string[] prompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    public override void DoActivity()
    {
        StartActivity();
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        int count = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            count++;
            for (int i = 0; i < 3; i++) // Pause for 3 seconds with a spinner
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        Console.WriteLine($"You have listed {count} items.");
        EndActivity();
    }
}

class Program
{
static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the Mindfulness App! Please choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Exit");

            int choice = Int32.Parse(Console.ReadLine());

            Activity activity;
            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectionActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
                case 4:
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            activity.DoActivity();
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        string[] listOfEvents = {"🎤  Lectures", "🥂  Receptions", "🪩  Outdoors"};
        string logo = """
                ╔═╗┬  ┬┌─┐┌┐┌┌┬┐  ╔═╗┬  ┌─┐┌┐┌┌┐┌┬┌┐┌┌─┐
                ║╣ └┐┌┘├┤ │││ │   ╠═╝│  ├─┤│││││││││││ ┬
                ╚═╝ └┘ └─┘┘└┘ ┴   ╩  ┴─┘┴ ┴┘└┘┘└┘┴┘└┘└─┘.co
                        "PLAN YOUR EVENTS WITH US"
            """;
        Console.WriteLine(logo);
        Console.WriteLine("");
        Console.WriteLine($"Which event would you like to plan: 1.{listOfEvents[0]}  |  2.{listOfEvents[1]}  |  3.{listOfEvents[2]}");
        string theEvent = Console.ReadLine().ToLower();
        Console.WriteLine("");

        void StandardMessage()
        {
            Console.WriteLine("");
            Console.WriteLine("Standard Format - Event Information: ");
            Console.WriteLine("_______________________________________");
        }
        void FulldMessage()
        {
            Console.WriteLine("");
            Console.WriteLine("Full Format - Event Information: ");
            Console.WriteLine("_______________________________________");
        }
        void ShortMessage()
        {
            Console.WriteLine("");
            Console.WriteLine("Short Format - Event Information: ");
            Console.WriteLine("_______________________________________");
        }

        switch (theEvent)
        {
            case "lectures":
                Lectures lectures = new();
                lectures.BookLectureEvent();

                StandardMessage();
                lectures.DisplayStandardDetails();

                FulldMessage();
                lectures.DisplayFullDetails();

                ShortMessage();
                lectures.DisplayShortDetails();
                break;

            case "receptions":
                Reception reception = new();
                reception.BookReceptionEvent();

                StandardMessage();
                reception.DisplayStandardDetails();

                FulldMessage();
                reception.DisplayFullDetails();

                ShortMessage();
                reception.DisplayShortDetails();
                break;

            case "outdoors":
                Outdoor outdoor = new();
                outdoor.BookEvent();

                StandardMessage();
                outdoor.DisplayStandardDetails();

                FulldMessage();
                outdoor.DisplayFullDetails();

                ShortMessage();
                outdoor.DisplayShortDetails();
                break;

            default:
                Console.WriteLine("[❗️❗️❗️...Invalid Event] - You entered an event that's not in the list of events we plan");
                break;
        }
    }
}
    
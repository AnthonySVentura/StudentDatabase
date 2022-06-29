string[] studentNames = { "Justin Jones", "Connor Wood", "Kris Pranger", "Josh Carolin", "Krista Anderson", "Travis Amador", "Asia Drew", "Ali Al-Hashemi", "Vinh Dang", "Tolulope Olubunmi", "Robot Haupt", "Matt Fox", "Daniel Schuler", "Anthony Ventura", "Mara Johnson", "Brandon Harman", "Olukayode Olubunmi" };

string[] favoriteFood = { "Baja Blast", "Chicken Sandwich", "Sushi", "Naleśniki", "Sushi", "General Tso's", "Jerk chicken", "Steak", "Sushi", "Rice and Dodo", "Bread", "Steak", "BBQ", "Thai", "tacos", "Pasta", "Pounded Yam" };

string[] hometown = { "Wyoming, MI", "Grosse Pointe, MI", "Grosse Pointe, MI", "Westland, MI", "Grosse Ile, MI", "Brown City, MI", "Detroit, MI", "Dearborn Heights, MI", "Shelby, MI", "Asese, Nigeria", "Green Bay, WI", "Sterling Heights, MI", "Potterville, MI", "Canton, MI", "Rochester, MI", "Dallas, TX", "Ibadan, Nigeria" };

int index = 0;

    Console.WriteLine("Please pick a student by number between 1-17");
    string userInput = (Console.ReadLine());
    index = int.Parse(userInput) - 1;

    Console.WriteLine($"This student number is {studentNames[index]}");

    do
    {
        Console.WriteLine("Do you want to know where their hometown is or their favorite food? Please answer with hometown/food");
        string choice = Console.ReadLine();
        if (choice == "hometown")
        {
            Console.WriteLine($"{studentNames[index]} is from {hometown[index]}");
        break;
        }
        else if (choice == "food")
        {
            Console.WriteLine($"{studentNames[index]}'s favorite food is {favoriteFood[index]}");
        break;
        }
        else
        {
            Console.WriteLine("I'm sorry but this answer will not work.");
        }
    } while (index < studentNames.Length);





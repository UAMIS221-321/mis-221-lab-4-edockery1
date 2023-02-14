// start main
int userChoice = GetUserChoice();   // priming read

while (userChoice != 3)              // condition check 
{
    RouteEm(userChoice);
    userChoice = GetUserChoice();       // update read 
}
// end main

static int GetUserChoice()
{
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if (IsValidChoice(userChoice))
    {
        return int.Parse(userChoice);
    }
    else return 0;
}

static void RouteEm(int menuChoice)
{
    if (menuChoice == 1)
    {
        GetFull();
        PauseAction();
    }
    else if (menuChoice == 2)
    {
        GetPartial();
        PauseAction();
    }
    else if (menuChoice != 3)
    {
        SayInvalid();
    }
}

// checking to see if user entered valid choice
static bool IsValidChoice(string userInput)
{
    if (userInput == "1" || userInput == "2" || userInput == "3")
    {
        return true;
    }
    return false;
}

static void SayInvalid()
{
    System.Console.WriteLine("Invalid choice");
    PauseAction();
}

static void PauseAction()
{
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

// menu options 
static void DisplayMenu()
{
    Console.Clear();
    System.Console.WriteLine("Enter 1: To display full triangle\nEnter 2: To display partial triangle\nEnter 3: To exit");
}

// display full triangle (mint condition)
static void GetFull()
{
    Random rnd = new Random();
    int rowNumber = rnd.Next(3, 10);
    int count = 0;

    for (int i = 1; i <= rowNumber; i++)
    {
        for (int x = 0; x <= count; x++)
        {
            Console.Write("O");
        }
        System.Console.WriteLine("");
        count++;
    }
}

// display partial triangle (modern day condition)
static void GetPartial()
{
    Random rnd = new Random();
    int rowNumber = rnd.Next(3, 10);
    for (int i = 0; i < rowNumber; i++)
    {
        for (int x = 0; x <= i; x++)
        {
            int count = rnd.Next(2);
            if (count == 0)
            {
                System.Console.Write("O");
            }
            else
            {
                System.Console.Write(" ");
            }
        }
        System.Console.WriteLine();
    }
}
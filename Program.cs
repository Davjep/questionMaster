// See https://aka.ms/new-console-template for more information
Questions questions = new Questions();

Console.WriteLine("Choose course: \n1. D0025N, Data Communication in Information Systems \n2. D0026E, Affärssystem - ERP");
string input = Console.ReadLine();
switch (input)
{
    case "1": 
        Console.WriteLine("Youve chosen " + input);
        break;
    case "2":
        Console.WriteLine("Youve chosen " + input);
        break;
    default:
        Console.WriteLine("Please specify one of the options...");
        break;

}


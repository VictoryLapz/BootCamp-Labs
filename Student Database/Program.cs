
//Stack of Arrays
string[] Names = new string[3];
Names[0] = "Freddie";
Names[1] = "Jon";
Names[2] = "Michael";

string[] FavFoods = new string[3];
FavFoods[0] = "Pizza";
FavFoods[1] = "Wings";
FavFoods[2] = "Burger";

string[] Hometowns = new string[3];
Hometowns[1] = "Arizona";
Hometowns[2] = "Claifornia";
Hometowns[3] = "Texas";


Console.WriteLine("Hello Welcome, Which student would you like to learn more about? Please enter a number between 1-9:");
string numberselected = Console.ReadLine();


for (int i = 0; i < Names.Length; i++)
{
    Console.WriteLine($"Student: {Names[i]}");
}

{
    Console.WriteLine("What information would you like to know? Enter \"Hometown\" or \"Favorite Food\"");
    string MoreInfo = Console.ReadLine();
};



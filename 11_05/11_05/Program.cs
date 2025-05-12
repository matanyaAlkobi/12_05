

//string[] new_list = { "rocket", "drone", "tank" };
//List<int> houses = new List<int>();
//int house_history = 0;
//string wepen_history = "";
//int number_of_house;
//Random r = new Random();
//int num = r.Next(1, 9);

//for (int i = 0; i < num; i++)
//{ 
//    houses.Add(i);
//}

//Console.Write($"how many house to destroy between 0 to {num}");
//int atack = int.Parse(Console.ReadLine());

//for (int i = 0; atack > 0; atack--)
//{
//    string weppen = new_list[r.Next(0, 3)];
//    int index = r.Next(0, atack);
//    number_of_house = houses[index];
//    houses.RemoveAt(index);

//    if (i == 0)
//    {
//        house_history = number_of_house;
//        wepen_history = weppen;
//    }
//    i++;

//}
//Console.WriteLine($"the first  house that  got atack {house_history}");
//Console.WriteLine($"the first wepen that atck { wepen_history}");
//foreach (int i in houses)
//{
//    Console.WriteLine(i);
//}



//question 1
//List<string> names = new List<string> { "moshe", "adam","shy", "jakov", "ori"};
//names.Add("shalom");
//names.Add("gali");
//names.Remove("adam");

//for (int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine($"{i} {names[i]}");
//}


//  question 2
//Dictionary <string,int> my_dict = new Dictionary<string, int> { { "knif", 5 },
//    { "cups", 6 },
//    {"lemon" ,  2} };

//my_dict["cups"] = 3;
//foreach (string key in my_dict.Keys) 
//{
//    Console.WriteLine($"{key} = {my_dict[key]}");
//}


// question 3
//List<Dictionary<string, string>> my_list = new List<Dictionary<string, string>>();
//Dictionary<string, string> my_dict1 = new Dictionary<string, string> { { "names", "moshe"},
//    {"email",  "kjnvjbs" },
//    {"status", "online"},};
//Dictionary<string, string> my_Dict2 = new Dictionary<string, string> { { "names", "alkobi"},
//    {"email",  "@gmai.com" },
//    {"status", "offline"},}; 
//my_list.Add(my_dict1);
//my_list.Add(my_Dict2);

//foreach (var i in my_list)
//{
//    Console.WriteLine(i["email"]);
//}




//question 4
//string[] user_names = { "moshe", "matan", "shoam" };
//Console.WriteLine("enter a user name: ");
//string user = Console.ReadLine();

//if (user_names.Contains(user))
//{
//    Console.WriteLine(Array.IndexOf(user_names, user));
//}
//else
//{
//    Console.WriteLine("Username not registered.");
//}



// question 5
List<string> tools1 = new List<string> { "recorder", "map", "notebook" };
List<string> tools2 = new List<string> { "recorder", "map", };
List<string> tools3 = new List<string> { "recorder",};

Dictionary<string,List<string>> soliders =  new Dictionary<string,List<string>>();
soliders.Add("Avi", tools1);







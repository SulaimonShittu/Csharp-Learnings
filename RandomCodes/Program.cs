using RandomCode;
//
//
// string? firstName;
// string? lastName;
//
//
// Console.WriteLine("--------------------------------------------------");
// Console.Write("Please enter the your firstName : ");
// firstName = Console.ReadLine();
//
// Console.WriteLine("--------------------------------------------------");
// Console.Write("Please enter the your lastName : ");
// lastName = Console.ReadLine();
//
// Console.WriteLine(String.Format("Your name is {0} {1}. ", firstName, lastName));
//
// Console.WriteLine(sizeof(int));
//
//
// Console.WriteLine(3.142); // 3.142 here is the literal
// Console.WriteLine($"{42.44546:R}");
//
//
// Console.WriteLine(sizeof(bool));
// Console.WriteLine(String.Compare("Ada", "ada", true));
//
// Console.WriteLine(@"
//     Start
//         ------
//        /        
//         \      
//           \   
//             \ 
//               \
//               / 
//         ------
//     Stop
// ");
//
// Label:
// Console.Write($"Hello please enter your age : {Environment.NewLine}");
// if (int.TryParse(Console.ReadLine(), out int age))
// {
//     if (age > 60)
//     {
//         Console.WriteLine("You are due for retirement according to labour laws");
//     }
//     else
//     {
//         Console.WriteLine("Keep working!");
//     }
// }
// else
// {
//     Console.WriteLine("You didn't enter a valid age try again");
//     goto Label;
// }
//
// Panda sula = new Panda("Sulaimon");
// var (name, population) = sula;
//
// Animal Elephant = new Animal { Name = "Sulaimon", LikesVegs = true, LikesMeat = true };
//

//
// Stock tsla = new Stock{Name = "Tesla", SharesOwned = 120};
// House twoStorey = new House { Name = "Two Storey building", Mortgage = 1200000m };
//
// Asset x = tsla;
// Asset x2 = twoStorey;
// Stock z = (Stock) x;
//
// if (x2 is Stock y)
// {
//     Console.WriteLine(y.SharesOwned);
// }
// else
// {
//     Console.WriteLine("x2 is not a Stock");
// }
//
// Console.WriteLine(z.SharesOwned);
//

Stack x = new Stack(100);
x.Append(5);
x.Append(2);
x.Append(6);
int y = (int) x.Pop();

//  using RandomCode;
//
// string? firstName;
// string? lastName;
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
// Console.WriteLine(3.142); // 3.142 here is the literal
// Console.WriteLine($"{42.44546:R}");
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
// Stock tsla = new Stock { Name = "Tesla", SharesOwned = 120 };
// House twoStorey = new House { Name = "Two Storey building", Mortgage = 1200000m };
//
// Asset x = tsla;
// Asset xx = twoStorey;
// Stock z = (Stock)x;
//
// if (xx is Stock y)
// {
//     Console.WriteLine(y.SharesOwned);
// }
// else
// {
//     Console.WriteLine("xx is not a Stock");
// }
//
// Console.WriteLine(z.SharesOwned);
//
//
// Stack x2 = new Stack(100);
// x2.Append(5);
// x2.Append(2);
// x2.Append(6);
// int y2 = (int)x2.Pop();
//
//
// Countdown x1 = new Countdown();
// Console.WriteLine(x1.Current);
// Console.WriteLine(x1.MoveNext());
// Console.WriteLine(x1.Current);
// Console.WriteLine(x1.MoveNext());
// Console.WriteLine(x1.Current);
// x1.Reset();
// Console.WriteLine(x1.Current);
// Console.WriteLine(x1.MoveNext());
// Console.WriteLine(x1.Current);
//
//
// var Z1 = new RandomCode.Stack<int>();
// Z1.Push(5);
// Z1.Push(4);
// Z1.Push(2);
// Z1.Push(-5);
// Z1.Push(-4);
// Z1.Push(-2);
// Console.WriteLine(Z1.Pop());
// Console.WriteLine(Z1.Pop());
// Console.WriteLine(Z1.Pop());
// Z1.Push(3); 
// Console.WriteLine(Z1.Pop());
//
// Dictionary<int, string> dic = new Dictionary<int, string>(10);
// dic.Add(1, "ada");
// dic.Add(2, "saul");
// dic.Add(4, "sula");
// dic.Add(0, "zami");
//
// Console.WriteLine(dic[4]);
// Console.WriteLine(dic[0]);
//
// string a = "aa";
//
// if (a is IComparable p)
//  Console.WriteLine(p.GetType());
//  
//  


int Square(int x) => x * x;
int Cube(int x) => x * x * x;

int[] vals = [1, 4, 8, 16, 32, 64];

Transform(vals, Square);
Console.WriteLine(String.Join(',', vals));

Transform(vals, Cube);
Console.WriteLine(String.Join(',', vals));


void Transform(int[] values, Transformer transformMethod)
{
    for (int i = 0; i < values.Length; i++)
    {
        values[i] = transformMethod(values[i]);
    }
}

Converter milliTodeci = new Converter();

ConvertorDel x1 = milliTodeci.ConvertFromMilliToDeci;

Console.WriteLine(x1.Invoke(400));
Console.WriteLine(x1.GetType().Name);


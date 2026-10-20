// // class task
// List<string> friuits = new List<string>();
// friuits.Add("apple");
// friuits.Add("banana");
// friuits.Add("orange");
// System.Console.WriteLine(friuits.Count());
// foreach (var item in friuits)
// {
//     System.Console.Write(item+" ");
// }
// friuits.Remove("banana");
// System.Console.WriteLine(friuits.Any(x=>x=="apple"));
// // friuits.Clear();
// List<string> strings = new List<string>();
// strings.AddRange(friuits);
// strings.Insert(0, "grape");
// strings.RemoveAt(2);
// System.Console.WriteLine(strings.Any());
// strings.Sort();
// strings.Reverse();
// List<string> friuit = new List<string>();
// friuit.AddRange(strings);
// friuit.RemoveAt(x=>x.length>5);
// int cnt;
// foreach (var item in friuit)
// {
//    if(item[0]=='a') cnt++;
// }
// friuit.Reverse();
// string s="";
// foreach (var item in friuit)
// {
//  s+=item;   
// }
// System.Console.WriteLine(s);
// home Task
// List<int> ints =new List<int>(){1,2,3,4,5};
// int cnt=0;
// foreach (var item in ints)
// {
//     cnt+=item;
// }
// System.Console.WriteLine(cnt);

// // task 2
// List<string> text = new List<string>(){"Abdlo"," va ", "Qrbon"};
// string con="";
// foreach (var item in text)
// {
//     con+=item;
// }
// System.Console.WriteLine(con);
// // Task 3
// List<DateTime> dateTimes= new List<DateTime>()
// {
//     new DateTime(2020, 10, 1),
//     new DateTime(2022, 8, 15),
//     new DateTime(2021, 4, 28)
// };
// dateTimes.Sort();
// foreach (var item in dateTimes)
// {
//     System.Console.WriteLine(item);
// }
// // Task 4
// List<double> doubles = new List<double>(){3.5, 4, 3.2, 5};
// double a=doubles.Average();
// System.Console.WriteLine(a);
// // Task 5
// List<int> numbers = new List<int>{ 1, 2, 3, 4, 5 };
// List<int> evenNumbers = new List<int>();
// evenNumbers.AddRange(numbers.FindAll(x=>x%2==0));
// foreach (var item in evenNumbers)
// {
//     System.Console.Write(item+" ");
// }
// // Task 6
// List<bool> bools = new List<bool>(){true, true, false};
// bool a = bools.All(x=> x==true || x==false);
// System.Console.WriteLine(a);
// // task 7
// List<string> strings = new List<string>(){"apple", "banana", "cherry"};
// strings.Remove("banana");
// foreach (var item in strings)
// {
//     System.Console.Write(item+" ");
// }
// // Task 8
// List<string> items = new List<string>{ "apple", "banana", "cherry" };
// bool found=items.Any(x=>x=="cherry");
// Console.WriteLine("Is the element found? " + found);
// // Task 9
// List<int> numbers = new List<int>();
// numbers.Add(21);
// foreach (var number in numbers)
// {
//     Console.Write(number+" ");
// }
// // Task 10
//  List<int> numbers = new List<int>();
// numbers.AddRange(2,2,3,4,5,6,7,8,9);
// foreach (var number in numbers)
// {
//     Console.Write(number+" ");
// }
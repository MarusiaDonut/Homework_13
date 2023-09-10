using Homework_13;

List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9};
list.Top(30).ToList().ForEach(x => Console.Write(x + " "));

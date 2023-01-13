// See https://aka.ms/new-console-template for more information

int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
FenwickTree ft = new FenwickTree(arr);
Console.WriteLine("[1,3]: "+ (ft.Sum(3)-ft.Sum(0)));
Console.WriteLine("[0,3]: "+ (ft.Sum(3)));
Console.WriteLine("[2,6]: "+ (ft.Sum(6)-ft.Sum(1)));


Console.WriteLine("Hello, World!");

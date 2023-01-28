int[] arr = Console.ReadLine().Split().Select(int.Parse).Where(x => x % 2 == 0).ToArray();
int sum = arr.Sum();
Console.WriteLine(sum);
----------------------------------------------------------------------------------------------------
    
//int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

//int sum = 0; 

//foreach (var number in arr.Where(x => x % 2 == 0))
//{
//    sum += number;
//}

//Console.WriteLine(sum);
 ----------------------------------------------------------------------------------------------------
    
//int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

//int sum = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//	if (arr[i] % 2 == 0)
//	{
//		sum += arr[i];
//	}
//}

//Console.WriteLine(sum);

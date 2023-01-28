int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < arr1.Length; i++)
{
	if (arr1[i] != arr2[i])
	{
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        return;
    }
	
}

Console.WriteLine($"Arrays are identical. Sum: {arr1.Sum()}");
---------------------------------------------------

//int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
//int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

//int sum = 0;

//for (int i = 0; i < arr1.Length; i++)
//{
//	if (arr1[i] == arr2[i])
//	{
//		sum += arr1[i];
//	}
//	else
//	{
//      Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
//		return;
//  }
//}

//Console.WriteLine($"Arrays are identical. Sum: {sum}");
---------------------------------------------------

//int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
//int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

//bool isEqual = Enumerable.SequenceEqual(arr1, arr2);

//if (isEqual)
//{
//    Console.WriteLine($"Arrays are identical. Sum: {arr1.Sum()}");
//}
//else
//{
//	for (int i = 0; i < arr1.Length; i++)
//	{
//		if (arr1[i] != arr2[i])
//		{
//          Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
//			break;
//      }
//	}
//}
---------------------------------------------------

//int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
//int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

//bool isEqual = true;
//int sum = 0;

//for (int i = 0; i < arr1.Length; i++)
//{
//	if (arr1[i] != arr2[i])
//	{
//		Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
//		isEqual = false;
//		break;
//	}

//	sum += arr1[i];
//}

//if (isEqual)
//{
//    Console.WriteLine($"Arrays are identical. Sum: {sum}");
//}

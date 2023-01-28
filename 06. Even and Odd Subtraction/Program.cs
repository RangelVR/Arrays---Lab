int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] evenArr = arr.Where(x => x % 2 == 0).ToArray();
int[] oddArr = arr.Where(x => x % 2 != 0).ToArray();
int evenSum = evenArr.Sum();
int oddSum = oddArr.Sum();

Console.WriteLine(evenSum - oddSum);
-------------------------------------------------------------

//int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

//int evenSum = 0;
//int oddSum = 0;

//foreach (var number in arr.Where(x => x % 2 == 0))
//{
//    evenSum += number;
//}

//foreach (var number in arr.Where(x => x % 2 != 0))
//{
//    oddSum += number;
//}

//Console.WriteLine(evenSum - oddSum);
-------------------------------------------------------------

//int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

//int evenSum = 0;
//int oddSum = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//	if (arr[i] % 2 == 0)
//	{
//		evenSum += arr[i];
//	}
//	else
//	{
//		oddSum += arr[i];
//	}
//}

//Console.WriteLine(evenSum - oddSum);

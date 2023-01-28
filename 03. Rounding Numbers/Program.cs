double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();

foreach (var number in arr)
{
    Console.WriteLine($"{number} => {(int)Math.Round(number, MidpointRounding.AwayFromZero)}");
}

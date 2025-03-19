var nums = File.ReadAllLines("input_files/numbers.txt").Select(x => int.Parse(x));

Console.WriteLine($"Prvy: {nums.First()}");
Console.WriteLine($"Posledny: {nums.Last()}");
Console.WriteLine($"Stredny: {nums.ElementAt(nums.Count() / 2)}\n");
PrintStatistics(nums.ToArray().AsSpan()[0..^0]);

var editableNums = nums.ToArray();

for (int i = 0; i < 300; ++i)
{
    editableNums[i] = 0;
}

PrintStatistics(editableNums);

for (int i = 4000; i < 6001; ++i)
{
    editableNums[i] = 500;
}

PrintStatistics(editableNums);
PrintStatistics(editableNums[5000..]);

string[] myarr = { "a", "b", "c", "d", "e" };
rotateArray(myarr, 3);
foreach (string str in myarr)
{
    Console.WriteLine(str);
}

void PrintStatistics(ReadOnlySpan<int> nums)
{
    int sum = 0;
    foreach (int num in nums)
    {
        sum += num;
    }
    double mean = (double)sum / nums.Length;
    double variance = 0.0;

    foreach (int num in nums)
    {
        variance += Math.Pow(num - mean, 2);
    }
    variance /= nums.Length;

    Console.WriteLine($"Suma = {sum}");
    Console.WriteLine($"Priemer = {mean}");
    Console.WriteLine($"Rozptyl = {variance}\n");
}

void rotateArray<T>(T[] myarr, int places)
{
    if (myarr == null) { return; }
    var tmp = myarr[0];
    for (int i = 0; i < myarr.Length; ++i) {
        myarr[i] = myarr[(places + i) % myarr.Length];
    }
    myarr[places] = tmp;
}

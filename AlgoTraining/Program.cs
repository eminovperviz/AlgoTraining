Console.WriteLine(IsAnagram("anagram", "nagaram"));

var arrResult = ReplaceElements(new int[] { 1, 121, 343, 25, 66 });

WriteArray(arrResult);

Console.ReadKey();

// find duplicates in given array
bool ContainsDuplicate(int[] nums)
{
    HashSet<int> list = new(nums);

    return list.Count < nums.Length;
}

// find given word is Anagram or not
bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length)
        return false;

    var tArray = t.AsSpan().ToArray().OrderBy(x => x).ToArray();
    var sArray = s.AsSpan().ToArray().OrderBy(x => x).ToArray();

    return Enumerable.SequenceEqual(sArray, tArray);
}

// replace elements with greatest element on right side 
int[] ReplaceElements(int[] arr)
{
    int max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            var next = arr[j];

            if (next > max)
                max = next;

        }
        arr[i] = max;
        max = 0;
    }

    arr[arr.Length - 1] = -1;

    return arr;

}

static void WriteArray(int[] arrResult)
{
    Console.WriteLine("[{0}]",string.Join(",", arrResult));
}
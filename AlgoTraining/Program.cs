//FindWordIsAnagram();

//FindWorkIsSubsequence();

//ReplaceElementWithGreatestOnRightSide();

SumGivenNumber();

Console.ReadKey();

// sum of given number
void SumGivenNumber()
{
    int n = 123, sum = 0, m;
    while (n > 0)
    {
        m = n % 10;
        sum = sum + m;
        n = n / 10;
    }
    Console.Write("Sum is (123) = " + sum);
}

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

// compare if given string IsSubsequence or not
bool IsSubsequence(string s, string t)
{
    if (s.Length > t.Length)
        return false;

    int sIndex = 0, tIndex = 0;

    while (sIndex < s.Length && tIndex < t.Length)
    {
        if (s[sIndex] == t[tIndex])
        {
            sIndex++;
        }

        tIndex++;
    }
    //if (sIndex == s.Length)
    return (sIndex == s.Length);
}

// count length of last work in given string
int LengthOfLastWord(string s)
{
    var array = s.Trim().Split(' ');

    return array[array.Length - 1].Length;

    //var result = nextSolution();

    int nextSolution()
    {
        var x = s.AsSpan().TrimEnd();
        int count = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ' ')
            {
                count++;
            }
            else
                return count;
        }
        return count;
    }


    //return result;
}

//Input: nums = [2, 7, 11, 15], target = 9
//Output: [0,1]
int[] TwoSum(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                return new int[] { i, j };
            }
        }
    }
    return null;
}

// Input: strs = ["flower", "flow", "flight"]
// Output: "fl"
string LongestCommonPrefix(string[] strs)
{
    return "";
}


static void WriteArray(int[] arrResult)
{
    Console.WriteLine("[{0}]", string.Join(",", arrResult));
}

void ReplaceElementWithGreatestOnRightSide()
{
    var arrResult = ReplaceElements(new int[] { 1, 121, 343, 25, 66 });
    WriteArray(arrResult);
}

void FindWordIsAnagram()
{
    Console.WriteLine($"IsAnagram : {IsAnagram("anagram", "nagaram")}");
}

void FindWorkIsSubsequence()
{
    Console.WriteLine($"IsSubsequence : {IsSubsequence("ana", "raganamoksueksnaasmsmeuema")}");
}
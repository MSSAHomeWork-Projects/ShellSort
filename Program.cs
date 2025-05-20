static void ShellSort(int[] arr)
{
    int gap = arr.Length / 2;//6, gap = 3
    int i, j;

    while (gap > 0)
    {
        i = gap;
        while (i < arr.Length)
        {
            int temp = arr[i];//number to be placed in correct position
            j = i - gap;
            while (j >= 0 && arr[j] > temp)
            {
                arr[j + gap] = arr[j];
                j = j - gap;
            }
            arr[j + gap] = temp;
            i++;
        }
        gap = gap / 2;
    }
}
Console.WriteLine("Assignment 7.2.1");
Console.WriteLine("Enter the length of the array: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] myArr = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Number {i + 1}: ");
    myArr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Array before sorting: ");
Console.Write("[");
for (int i = 0; i < myArr.Length; i++)
{
    Console.Write(myArr[i] + " ");
}
Console.WriteLine("]");

ShellSort(myArr);
Console.WriteLine("Array after sorting: ");
Console.Write("[");
for (int i = 0; i < myArr.Length; i++)
{
    Console.Write(myArr[i] + " ");
}
Console.WriteLine("]");
Console.WriteLine();
Console.WriteLine("Assignment 7.2.2");
static string ReverseVowels(string word)
{
    HashSet<char> vowels = new HashSet<char>()
    {
        'a','e','i','o','u','A','E','I','I','O','U'
    };
    char[] wordChar = word.ToCharArray();
    int left = 0, right = wordChar.Length - 1;

    while (left < right)
    {
        //if it's not a vowel move left pointer right
        while (left < right && !vowels.Contains(wordChar[left]))
            left++;

        //if it's not a vowel move right pointer left
        while (left < right && !vowels.Contains(wordChar[right]))
            right--;

        //once its finds one swap happens here
        char temp = wordChar[left];
        wordChar[left] = wordChar[right];
        wordChar[right] = temp;

        left++;
        right--;
    }
    return new string(wordChar);
}
Console.WriteLine("hello");
Console.WriteLine(ReverseVowels("hello"));
Console.WriteLine("intelligent");
Console.WriteLine(ReverseVowels("intelligent"));
Console.WriteLine();

Console.WriteLine("Assignment 7.2.3");
static bool IsAnagram(string word1, string word2)
{
    if (word1.Length != word2.Length)
        return false;

    Dictionary<char, int> count = new Dictionary<char, int>();
    //Add all of the characters in word1 to the dictionary
    foreach (char c in word1)
    {
        if (!count.ContainsKey(c))
        {
            count[c] = 0;   
        }
        count[c]++;
    }
    //subtract the characters in word2 from the dictionary
    foreach (char c in word2)
    {
        if (!count.ContainsKey(c))
        {
            return false;
        }
        count[c]--;
        if (count[c] < 0)
        {
            return false;
        }
    }
    return true;
}

Console.WriteLine($"Word 1 is anagram.");
Console.WriteLine("Word 2 is magraan");
Console.WriteLine($"Output: {IsAnagram("anagram", "magraan")}");
Console.WriteLine();
Console.WriteLine($"Word 1 is rat.");
Console.WriteLine("Word 2 is car");
Console.WriteLine($"Output: {IsAnagram("rat", "car")}");
using System.Collections;
using System.Text.Encodings.Web;
/*/* -- Two Sum -- #1#
static int[] TwoSum(int[] nums, int target)
{
    int arrayLength = nums.Length;
    for (int i = 0; i < arrayLength; i++)
    {
        for (int j = i + 1; j < arrayLength; j++)
        {
            if (nums[i] + nums[j] == target) return new int[] {
                i,
                j
            };
        }
    }
    return Array.Empty<int>();
}


/* -- Palindrome Number -- #1#
static bool IsPalindrome(int x)
{
    string a1 = x.ToString();
    string a2 = "";
    for (int i = a1.Length - 1; i >= 0; i--)
    {
        if (Char.IsDigit(a1[i]) == false)
        {
            return false;
        }

        a2 += a1[i];
    }
    long y = Convert.ToInt64(a2);
    if ((long)x == y)
    {
        return true;
    }
    else
    {
        return false;
    }
}

/* -- Roman to Integer -- #1#
static int RomanToInt(string s)
{
    Dictionary<char, int> list = new Dictionary<char, int>(){
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
    int number = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (i + 1 < s.Length && list[s[i]] < list[s[i + 1]])
        {
            number -= list[s[i]];
        }
        else
        {
            number += list[s[i]];
        }
    }
    return number;
}*/

/* -- Longest Common Prefix -- */


Console.WriteLine(IsValid("["));

static bool IsValid(string s)
{
    Stack left = new Stack();
    foreach (char c in s.ToCharArray())
    {
        if (c == '(' || c == '{' || c == '[')
        {
            left.Push(c); 
        }
       
        else if (c == ')' && left.Count != 0 && (char)left.Peek() == '(')
        {
            left.Pop();
        }
        else if (c == '}' && left.Count != 0 && (char)left.Peek() == '{')
        {
            left.Pop();
        }
        else if (c == ']' && left.Count != 0 && (char)left.Peek() == '[')
        {
            left.Pop();
        }
        else
        {
            return false; 
        }
    }
    return true;
}
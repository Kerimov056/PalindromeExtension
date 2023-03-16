namespace PalindromeExtension.PALLINDROME;

public static class PalindromExtension
{
    public static bool Palindrome(this int num)
    {
        int fake = num;
        int qaliq = 0;
        int newpalindrom = 0;
        while (num > 0)
        {
            qaliq = num % 10;
            newpalindrom = (newpalindrom * 10) + qaliq;
            num /= 10;
        }
        return fake == newpalindrom;
    }

}

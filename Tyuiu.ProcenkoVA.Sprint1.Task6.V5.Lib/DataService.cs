using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ProcenkoVA.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            string[] words = value.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();

            foreach (string word in words)
            {
                string lowerWord = word.ToLower();
                char[] charArray = lowerWord.ToCharArray();
                Array.Reverse(charArray);
                string reversedWord = new string(charArray);

                if (lowerWord == reversedWord && word.Length > 1)
                {
                    palindromes.Add(word);
                }
            }

            return string.Join(" ", palindromes);
        }
    }
}

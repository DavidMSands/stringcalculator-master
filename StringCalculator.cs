
namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        if(numbers == "")
        {
            return 0;
        }
        if(numbers.Length == 1)
        {
            return int.Parse(numbers);
        }
        if(numbers.StartsWith("//"))
        {
            var result = 0;
            var split = numbers.Remove(0,4).Split(numbers.Substring(2, 1));

            foreach (var number in split)
            {
                var num = int.Parse(number);
                result += num;
            }

            return result;
        }
        else
        {

            var result = 0;
            Char[] delimiters = { '\n', ',' };
            var split = numbers.Split(delimiters);

            foreach(var number in split)
            {
                var num = int.Parse(number);
                result += num;
            }

           return result;
        }
    }
}

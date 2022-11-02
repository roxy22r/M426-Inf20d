namespace FooBarQix
{
    public class FooBarQixDeterminer
    {
        public string Determine(int input)
        {
            string result = "";
            if (input % 3 == 0)
            {
                result = result + "Foo";
            }
             if (input % 5 == 0)
            {
                result = result + "Bar";
            }
             if (input % 7 == 0)
            {
                result = result + "Qix";
            }
            return isEmptyReturnNumberElseText(input, result);
        }

        private static string isEmptyReturnNumberElseText(int input, string result)
        {
            if (string.IsNullOrEmpty(result))
            {
                return input.ToString();
            }
            else
            {
                return result;
            }
        }
    }
}
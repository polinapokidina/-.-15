using System;
using System.Text;
namespace _82

{
    class Program
    {
        static void Main(string[] args)
        {
            var src = "aapabbppccc";
            var toRemove = 'p';
            var res = RemoveAt(src, toRemove);
            Console.WriteLine(src);
            Console.WriteLine(toRemove);
            Console.WriteLine(res);
        }
        static string RemoveAt(string src, char c)
        {
            var sb = new StringBuilder();
            foreach (var item in src)
            {
                if (!item.Equals(c))
                {
                    sb.Append(item);
                }
            }
            return sb.ToString();
        
        }

    }
}

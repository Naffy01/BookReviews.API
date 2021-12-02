using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReviews.ConsoleApp
{
    public class PersonBase:ITestInterfaceksaksak
    {
        public int Sample { get; set; }

        public int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public string KtheString(string vlera1, string vlera2)
        {
            return vlera1;
        }

        public string NameCapitalized(string name)
        {
            return name.ToUpper();
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}

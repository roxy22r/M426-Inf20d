using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    internal class Player
    {
        private string name;
        private int point;
        private string resultText;

        public string Name { get { return name; } set { name = value; } }
        public int Point { get { return point; } set { point = value; } }  
        public string ResultText { get { return resultText;} set { resultText = value; } }  

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComdepConfig.Main_Code_Pool.Abstracts
{
    public abstract class Pair { }



    // Pair containing two values, possibly of different types.
    public class Pair<TFirst, TSecond> : Pair
    {
        private TFirst m_first;
        private TSecond m_second;
        public Pair(TFirst first, TSecond second)
        {

            m_first = first;
            m_second = second;
        }
        // Returns a pair containing the first two values from a linked list
    }
}
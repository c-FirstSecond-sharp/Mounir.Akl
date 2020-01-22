using Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComdepConfig.Main_Code_Pool.Abstracts
{
    public class One
    {
    }

    public class One<TFirst> : One where TFirst : class
    {
        private AM<TFirst> m_first;
        public AM<TFirst> AM { get { return m_first; } }
        public One(TFirst first)
        {

            m_first = first;

        }
    }
}

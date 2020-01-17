using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePool.Code_pool
{
    public interface IBuild<T>
    {
        void Build(T xc);
    }
}

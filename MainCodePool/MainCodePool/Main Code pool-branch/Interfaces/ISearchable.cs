using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    internal interface ISearchable<TVal, TId, TResult>
    {
        TResult SelectValue(TVal val);
        TResult FindId(TId id);
       // TResult[] Select(params NamedValue<string, TVal>[] criterias);
    }
}

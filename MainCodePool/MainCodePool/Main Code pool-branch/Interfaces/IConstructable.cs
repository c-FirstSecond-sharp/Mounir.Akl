using Abstracts;
using Patterns;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
   public interface IConstructable
    {
        void Construct();
        AM<TFirst> ConstructOne<TFirst>(AConstructable<TFirst> other);
        IConstructable Get();
        AM<TFirst> GetOne<TFirst>(AConstructable<TFirst> other);
        AM<TFirst> GetOne<TFirst>();
        TInnerContent GetSelectedItem<TInnerContent>() where TInnerContent:class;
        int IdSelected { get; set; }
        Guid GuidSelected { get; set; }

        string GetKey();
    }
}

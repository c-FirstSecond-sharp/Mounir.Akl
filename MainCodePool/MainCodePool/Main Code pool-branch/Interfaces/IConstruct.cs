using Abstracts;
using KeyClick.Main_Code_pool_branch;
using Patterns;
using System;

namespace Interfaces
{
    public interface IConstruct
    {
        Type ContentType();
        bool IsSubclass(Type t);
        bool Is(Type t);
        bool IsNull(IConstruct am);
        AM<string> Name
        {
            get;
            set;
        }
        void Init();
       // void Init<T>(T obj);
        AM<TFirst> ConstructOne<TFirst>(AConstruct other) where TFirst : class;
        IConstruct Get();
        T Get<T>();
        AM<TFirst> GetOne<TFirst>(AConstruct other) where TFirst : class;
        AM<TFirst> GetOne<TFirst>() where TFirst : class;
        TInnerContent GetSelectedItem<TInnerContent>() where TInnerContent:class;
        int IdSelected { get; set; }
        Guid GuidSelected { get; set; }

        string GetKey();
        IConstruct DeepCopy();
        //  void Set<U>(U uIType);// where U : AM<V> where V : class, U,IConstructable;
        void Set<B, T>(AMNamed<B, Construct, T> uIType) where B : Construct where T : Construct;
        //void Set<T>(T aPanel);
    }
}

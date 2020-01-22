using System;
using Interfaces;
using KeyClick.Main_Code_pool_branch;
//using KeyClick.RGC_branch;
using Patterns;

namespace Abstracts
{
    public class Construct : AConstruct
    {
        internal Construct Encapsulator { get; set; }

        internal int ChildrenCount { get; set; }

        public Construct()
        {

        }


        override public void Init() { }
        //override public void Init<T>(T obj)
        //{
        //    throw new NotImplementedException();
        //}
        override public AM<TFirst> ConstructOne<TFirst>(AConstruct other) { return null; }
        override public Type ContentType() { return null; }
        override public IConstruct DeepCopy() { return null; }
        override public IConstruct Get() { return null; }
        override public string GetKey() { return null; }
        override public AM<TFirst> GetOne<TFirst>() { return null; }
        override public AM<TFirst> GetOne<TFirst>(AConstruct other) { return null; }
        override public TInnerContent GetSelectedItem<TInnerContent>()  { return default(TInnerContent); }
        override public bool Is(Type t) { return false; }
        override public bool IsNull(IConstruct am) { return false; }
        override public bool IsSubclass(Type t) { return false; }
        //override public void Set<T>(T aPanel) { }
        override public T Get<T>() { return default(T); }
        override public void Set<B, T>(AMNamed<B, Construct, T> uIType)
        { }

        internal void ChildrenClear()
        {
            throw new NotImplementedException();
        }

       virtual  internal object ChildAt(int v)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using Interfaces;
using KeyClick.Main_Code_pool_branch;
using Patterns;
//using Windows.UI.Xaml.Controls;

namespace Abstracts
{
    public abstract partial class AConstruct : EventArgs, IConstruct
    {
        public AM<string> Name
        {
            get;
            set;
        }

        public int IdSelected
        {
            get;

            set;
        }

        public Guid GuidSelected
        {
            get;

            set;
        }


        // [StrongNameIdentityPermission(SecurityAction.Demand, PublicKey = "10240000048000009400000006020000002400005253413100040000010001005fc2c227cb86691ad0177ae60fc2c11f93f2a0d932d182e3f4583277e1e9e81dec38b8064327a4df5c82347f6f33846c91ba1faebb558dbf76d79170e47a2c9adc8a3d7bccd61404b6f59b979d72e6cbf3bae857fd3b17490cf2e81e720ce3c630ea54a9dd43f643d10617295d696fd17b72a3efc61f86534c2c31ab377569f0")]
        //     abstract protected internal void Construct<T>(T obj);
        //{

        //}

        #region IConstructable Members
        abstract public void Init();
       // abstract public void Init<T>(T obj);
        //abstract public void Construct();
        //{
        //    throw new Exception("The method or operation is not implemented.");
        //}

        #endregion




        abstract public IConstruct Get();
        //{
        //    throw new NotImplementedException();
        //}
        abstract public T Get<T>();
        abstract public AM<TFirst> GetOne<TFirst>(AConstruct other) where TFirst : class;
        //{
        //    throw new NotImplementedException();
        //}

        abstract public AM<TFirst> GetOne<TFirst>() where TFirst : class;
        //{
        //    throw new NotImplementedException();
        //}


        abstract public TInnerContent GetSelectedItem<TInnerContent>() where TInnerContent:class;
        //{
        //    throw new NotImplementedException();
        //}


        //override abstract public int IdSelected
        //{
        //    get;
        //    set;
        //}

        //override abstract public Guid GuidSelected
        //{
        //    get;
        //    set;
        //}

        //override abstract public AM<string> Name
        //{
        //    get;

        //    set;
        //}

        abstract public string GetKey();

        abstract public IConstruct DeepCopy();

        // abstract public void Set<U>(U uIType);// where U : AM<V> where V : class, U, IConstructable;



        abstract public bool IsNull(IConstruct am);
        abstract public Type ContentType();
        abstract public bool IsSubclass(Type t);
        abstract public bool Is(Type t);

        abstract public void Set<B, T>(AMNamed<B, Construct,T> uIType) where B : Construct where T : Construct;

       // abstract public void Set<T>(T aPanel);

        

        abstract public AM<TFirst> ConstructOne<TFirst>(AConstruct other) where TFirst : class;
    }
}

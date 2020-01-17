using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;
using System.Security.Permissions;
using Patterns;
namespace Abstracts
{
    public abstract class AConstructable<T> : IConstructable
    {
       // [StrongNameIdentityPermission(SecurityAction.Demand, PublicKey = "10240000048000009400000006020000002400005253413100040000010001005fc2c227cb86691ad0177ae60fc2c11f93f2a0d932d182e3f4583277e1e9e81dec38b8064327a4df5c82347f6f33846c91ba1faebb558dbf76d79170e47a2c9adc8a3d7bccd61404b6f59b979d72e6cbf3bae857fd3b17490cf2e81e720ce3c630ea54a9dd43f643d10617295d696fd17b72a3efc61f86534c2c31ab377569f0")]
        abstract protected internal void Construct(T obj);
        //{

        //}

        #region IConstructable Members

        abstract public void Construct();
        //{
        //    throw new Exception("The method or operation is not implemented.");
        //}

        #endregion


        abstract public AM<TFirst> ConstructOne<TFirst>(AConstructable<TFirst> other);
        //{
        //    throw new NotImplementedException();
        //}

        abstract public IConstructable Get();
        //{
        //    throw new NotImplementedException();
        //}

        abstract public AM<TFirst> GetOne<TFirst>(AConstructable<TFirst> other);
        //{
        //    throw new NotImplementedException();
        //}

        abstract public AM<TFirst> GetOne<TFirst>();
        //{
        //    throw new NotImplementedException();
        //}


        abstract public TInnerContent GetSelectedItem<TInnerContent>() where TInnerContent : class;
        //{
        //    throw new NotImplementedException();
        //}


        abstract public int IdSelected
        {
            get;
            set;
        }

        abstract public Guid GuidSelected
        {
            get;
            set;
        }

        abstract public string GetKey();
    }
}

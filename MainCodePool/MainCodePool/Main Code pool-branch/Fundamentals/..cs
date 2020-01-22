using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyClick.Main_Code_pool_branch
{
    class t<T>
    {
        T _t;
        internal T  this[int t]
        {
            get { return _t; }
            set { _t = value; }
        }
        //public static implicit operator t<T>(t<T> n)
        //{
        //    T content = default(T);
        //    try
        //    {
        //        //T t = (T)Activator.CreateInstance(typeof(T));
        //        //content = n[t];
        //    }
        //    catch (NullReferenceException ex)
        //    {
        //        content = default(T);
        //    }
        //    return n;
        //}
        //public static implicit operator t<T>(T n)
        //{
        //    t<T> newObj = new t<T>();//n
        //    newObj[0] = n;
        //    //newObj.Init(n);
        //    return newObj;
        //}
        public   T Cast<S,R>(S n,R content) where R: t<S>, T
        {
            //= default(T);
            try
            {
               // object o = n;

               content[0]=n ;
             // content = n[0] as T;// as t<T>;
               // content = t[0];
            }
            catch (NullReferenceException ex)
            {
                content = default(R);
            }
            return content;
        }
        //public static  object Cast(T n)
        //{
        //    t<T> newObj = new t<T>();//n
        //    newObj[(T)Activator.CreateInstance(typeof(T))] = n;
        //    //newObj.Init(n);
        //    return newObj;
        //}
    }
}

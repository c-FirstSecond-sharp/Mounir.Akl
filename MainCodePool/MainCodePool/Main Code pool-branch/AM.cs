using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;
using Singleton;
using KeyClick.Main_Code_pool_branch;
using System.Reflection;
//using Windows.UI.Xaml;
using KeyClick.Main_Code_pool_branch.Fundamentals;

namespace Patterns
{
    public class AM<T> : EventRepeater<T>, IAM<T>, IEquatable<AM<T>>, IComparer<T>  where T:class
    {
         T _content;

        protected internal T Content
        {
            get
            {
                return _content;
            }

            set
            {
                _content=value;
            }
        }

        public AM()
        {
            
        }
        //public AM(T content)
        //{
        //    Init(content);
        //}
        
        /// <summary>
        /// Convert a Notifiable into its internal value/>
        /// </summary>
        /// <param name="n">the notifiable class</param>
        /// <returns></returns>
        public static implicit operator T(AM<T> n)
        {
            T content = default(T);
            try
            {
                content = n.Get();
            }
            catch (NullReferenceException ex)
            {
                content = default(T);
            }
            return content;
        }
        public static implicit operator AM<T>(T n)
        {
            AM<T> newObj = new AM<T>();//n
            newObj.Set(n);
            return newObj;
        }
        public static bool operator ==(AM<T> a, AM<T> b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(AM<T> a, AM<T> b)
        {
            return !a.Equals(b);
        }

        public override bool Is(Type t)
        {
            return typeof(T).Equals(t);
        }
        public override Type ContentType()
        {
            return typeof(T);
        }
        
        public override bool IsSubclass(Type t)
        {
            return typeof(T).GetTypeInfo().IsSubclassOf(t);
        }

        //internal void Set<S>(S t) where S : class,T
        //{
        //    Content = t ;
        //}
       
        internal AM<T> IsSameType(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return null;

            return (AM<T>)obj;
        }
        public override bool Equals(object obj)
        {

            AM<T> p = IsSameType(obj);

            if (this.IsNull(p) == false && _content != null && p.IsNull() == false)
            {
                T temp2 = _content;
                T pContent = p.Get();
                bool isEqual = pContent.Equals(temp2);
                return isEqual;
            }
            else if (_content == null && p.IsNull() == true)
            {
                return true;
            }
            return false;

        }
        public override int GetHashCode()
        {
            return _content.GetHashCode();
        }

        #region IContent Members

       
        public T Get()
        {
           // Debug(_content);
            return _content;
        }
        public T Get(bool debug)
        {
            if (debug == true)
            {
                Debug(_content);
            }
            return _content;
        }
        public override S Get<S>()
        {
            return (S)(object)Get();
        }
        //override public void Set<S>(S t)
        //{

        //    //  _content = t<T>.Cast(t,Get());///////////////////////////////////////

        //}
        public void Set(T value)
        {
            AM<T> oldContent = new AM<T>();
            oldContent.Content=_content;
            _content = value;
          //  Debug(_content);
         //   Raise(this, oldContent);
        }
        public void Set(T value, bool notify)
        {
            AM<T> oldContent = new AM<T>();
            oldContent.Set(_content);
            _content = value;

            //    Debug(_content);
            if (notify == true)
            {
                Raise(this, oldContent);
            }
        }
        public void Set(T value, bool debug, bool notify)
        {
            AM<T> oldContent = new AM<T>();
            oldContent.Set(_content);
            _content = value;

            if (debug == true)
            {
                Debug(_content);
            }
            if (debug == true)
            {
                Raise(this, oldContent);
            }
        }
        //public override void Set<U>(U uIType) 
        //{
        //    if (_content!=null && ((_content.GetType()).Equals(typeof(U)) || (_content.GetType().GetTypeInfo().IsSubclassOf(typeof(U)))))
        //    {
        //        T asType = (T)(uIType as object);
        //        Set(asType);
        //    }
        //    else if (_content == null &&( (typeof(T)).Equals(typeof(U)) || (typeof(T).GetTypeInfo().IsSubclassOf(typeof(U)))))
        //    {
        //        T asType = (T)(uIType as object);
        //        Set(asType);
        //    }
           
        //}
      
       
        #endregion
        public override string ToString()
        {
            if (_content != null)
            {
                return _content.ToString();
            }
            return string.Empty;
        }
        internal void Debug(T val)
        {
            System.Diagnostics.Debug.WriteLine(val);
        }
        internal void Debug()
        {
            System.Diagnostics.Debug.WriteLine("*** The Content is: "+_content+" ***");
        }

        #region IConstructable<T> Members

        override public void Init()
        {
            try
            {
                Set((T)Activator.CreateInstance(typeof(T)));
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            //_content = default(T);
           
        }

        //override public void Init<S>(S obj)
        //{
        //    Set(obj);
        //    //_content = (T)((object)obj);
            
        //    Debug(_content);
        //}


        #endregion
        virtual public bool Equals(T other)
        {
            T temp = other;
            T temp2 = _content;

            return Convert.ToBoolean(Compare(temp, temp2));
        }

        virtual public bool Equals(AM<T> other)
        {
            T temp = other;
            T temp2 = _content;

            return Convert.ToBoolean(Compare(temp, temp2));
        }

        public int Compare(T x, T y)
        {
            bool isEqual = EqualityComparer<T>.Default.Equals(x, y);
            return Convert.ToInt32(isEqual);
        }

        protected internal bool IsNull()
        {
            if (_content == null) return true;
            return false;
        }
        //static protected internal bool IsNull(IConstructable am)
        //{
        //    if (am == null) return true;
        //    return false;
        //}
        public override bool IsNull(IConstruct am)
        {
            if (am == null) return true;
            return false;
        }
        #region Copy
        internal AM<T> ShallowCopy()
        {
            return MemberwiseClone() as AM<T>;
        }
        IConstruct Copy(T t)
        {
            if (t is ValueType)
            {
                T s = default(T);
                s = t;
                AM<T> amt = new AM<T>();
                amt.Set(s);
                return amt;
            }
            else
            {
                return (t as  IConstruct).DeepCopy();
            }
        }
        IConstruct DeepCopy(T t)
        {
            AM<T> other = ShallowCopy();
            other.DeepCopy();
            other.Set((T)Copy(_content));
            return other;
        }
        override public IConstruct DeepCopy()
        {
            AM<T> other = ShallowCopy();
            other.Set((T)Copy(_content));
            return other;
        }
        #endregion

       
    }
}


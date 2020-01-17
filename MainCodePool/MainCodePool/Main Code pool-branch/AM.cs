using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;
using Singleton;
namespace Patterns
{
    public class AM<T> : EventRepeater<T>, IAM<T>, IEquatable<AM<T>>,IComparer<T>  // where T:class
	{
       protected internal T _content;
		public AM()
		{
			Construct();
		}
		public 	AM(T content)
		{
			Construct(content);
		}
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
            AM<T> newObj = new AM<T>(n);
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
        internal AM<T> IsSameType(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return null;

            return (AM<T>)obj;
        }
        public override bool Equals(object obj)
        {
           
            AM<T> p = IsSameType(obj);

            if (AM<T>.IsNull(p)==false && _content != null && p.IsNull()==false)
            {
                T temp2 = _content;
                T pContent = p.Get();
               //bool b= pContent == _content;
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
			Debug(_content);
			return _content;
		}
		
		public void Set(T value)
		{
			AM<T> oldContent=new AM<T>(_content);
			_content = value;
			Debug(_content);
			Subscribe();
			Raise(this, oldContent);
		}
		
		#endregion
        public override string ToString()
        {
            return _content.ToString();
        }
		static internal void Debug(T val)
		{
			System.Diagnostics.Debug.WriteLine(val);
		}


		#region IConstructable<T> Members

		override public void Construct()
		{
			_content = default(T);
		}

		override protected  internal void Construct(T obj)
		{
			_content = obj;
			Debug(_content);
		}

	
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
        static protected internal bool IsNull(IConstructable am)
        {
            if (am == null) return true;
            return false;
        }
    }
}


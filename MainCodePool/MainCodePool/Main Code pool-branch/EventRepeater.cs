using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;
using Patterns;
using Abstracts;
using KeyClick.Main_Code_pool_branch;

namespace Singleton
{
    public class EventRepeater<T> : Construct, IEventRepeater<T>, IDisposable where T : class
    {
		public AM<System.EventHandler> Act;
		//public delegate void EventHandler(AM<T> sender, AM<T> e);
		event EventHandler Changed;
		public void Raise(T sender, EventArgs e)
		{
			Changed+=new EventHandler(Changed_State);
			if (Changed != null)
			{
				Changed(sender, e);
			}
		}
		protected internal void Subscribe()
		{
            if (this.IsNull(Act) == true)
            {
                Act = new AM<System.EventHandler>();
                Act.Set(new EventHandler(FirstAction));
            }
		}
		virtual public void Changed_State(object sender, EventArgs e)
		{
			AM<T> s = null;
			AM<T> ee = null;
			if (sender is AM<T>)
				s = sender as AM<T>;
			//else s =new  AM<T>(sender);
			if (e is AM<T>)
				ee = e as AM<T>;
			//else ee = new AM<T>(e);
			if (IsNull( Act) == false)
				Act.Get()(s, ee);

		}

      virtual internal  void FirstAction(object sender, EventArgs e)
        {

        }
        //public override void Init<T>(T obj)
        //{
        //    throw new NotImplementedException();
        //}

        public override void Init()
        {
            throw new NotImplementedException();
        }

        public override AM<TFirst> ConstructOne<TFirst>(AConstruct other)
        {
            throw new NotImplementedException();
        }

        public override IConstruct Get()
        {
            return this;
        }

        public override AM<TFirst> GetOne<TFirst>(AConstruct other)
        {
            throw new NotImplementedException();
        }

        public override AM<TFirst> GetOne<TFirst>()
        {
            throw new NotImplementedException();
        }

        

        public override TInnerContent GetSelectedItem<TInnerContent>()
        {
            throw new NotImplementedException();
        }
        virtual protected  void Dispose(bool disposing)
        {
            if (disposing && (Act != null))
            {
                if ((Act is IDisposable) == true)
                {
                    (Act as IDisposable).Dispose();
                }
            }
            
        }

        public void Dispose()
        {
            Dispose(true);
        }

        //public override int IdSelected
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //    set
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        //public override Guid GuidSelected
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //    set
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        public override string GetKey()
        {
            throw new NotImplementedException();
        }

        public override IConstruct DeepCopy()
        {
            throw new NotImplementedException();
        }
        //public override void Set<U>(U uIType)
        //{
        //    throw new NotImplementedException();
        //}

        public override void Set<B, T>(AMNamed<B, Construct, T> uIType)
        {
            throw new NotImplementedException();
        }

        public override bool IsNull(IConstruct am)
        {
            throw new NotImplementedException();
        }

        //public override AM<string> Name
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }

        //    set
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
        public override Type ContentType()
        {
            throw new NotImplementedException();
        }
        public override bool IsSubclass(Type t)
        {
            throw new NotImplementedException();
        }
        public override bool Is(Type t)
        {
            throw new NotImplementedException();
        }

        //public override void Set<T>(T aPanel)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

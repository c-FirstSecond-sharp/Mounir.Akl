using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;
using Patterns;
using Abstracts;
namespace Singleton
{  
    public class EventRepeater<T> : AConstructable<T>, IEventRepeater<T>, IDisposable
	{
		public AM<EventHandler> Act;
		public delegate void EventHandler(T sender, T e);
		event EventHandler Changed;
		public void Raise(T sender, T e)
		{
			Changed+=new EventHandler(Changed_State);
			if (Changed != null)
			{
				Changed(sender, e);
			}
		}
		protected internal void Subscribe()
		{
			if(Act==null)
				Act = new AM<EventHandler>();
		}
		virtual public void Changed_State(T sender, T e)
		{
			AM<T> s = null;
			AM<T> ee = null;
			if (sender is AM<T>)
				s = sender as AM<T>;
			else s =new  AM<T>(sender);
			if (e is AM<T>)
				ee = e as AM<T>;
			else ee = new AM<T>(e);
			if (Act.Get() != null)
				Act.Get()(s, ee);

		}



        protected internal override void Construct(T obj)
        {
            throw new NotImplementedException();
        }

        public override void Construct()
        {
            throw new NotImplementedException();
        }

        public override AM<TFirst> ConstructOne<TFirst>(AConstructable<TFirst> other)
        {
            throw new NotImplementedException();
        }

        public override IConstructable Get()
        {
            throw new NotImplementedException();
        }

        public override AM<TFirst> GetOne<TFirst>(AConstructable<TFirst> other)
        {
            throw new NotImplementedException();
        }

        public override AM<TFirst> GetOne<TFirst>()
        {
            throw new NotImplementedException();
        }

        //public override TInnerContent GetSelected<TInnerContent>()  
        //{
        //    throw new NotImplementedException();
        //}

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

        public override int IdSelected
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override Guid GuidSelected
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override string GetKey()
        {
            throw new NotImplementedException();
        }
    }
}

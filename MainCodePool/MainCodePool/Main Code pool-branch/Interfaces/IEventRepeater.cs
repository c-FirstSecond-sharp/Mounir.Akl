using System;
namespace Interfaces
{
	public interface IEventRepeater<T>
	{
		void Raise(T sender, T e);
	}
}

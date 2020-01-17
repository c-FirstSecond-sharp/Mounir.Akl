using Patterns;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IAM<T> : IEquatable<AM<T>>, IComparer<T> // : IGetAbel
	{
		void Set(T value);
	}
}

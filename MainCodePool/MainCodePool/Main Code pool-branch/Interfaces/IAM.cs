using Patterns;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IAM<T> : IEquatable<AM<T>>, IComparer<T> where T : class
    {
		void Set(T value);

	}
}

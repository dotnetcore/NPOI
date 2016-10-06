using System;

namespace TestCases.Exceptions
{
	public class SystemException : Exception
	{
		public SystemException(string message) : base(message)
		{

		}
	}
	public class ApplicationException : Exception
	{
		public ApplicationException(string message) : base(message)
		{

		}
	}
}
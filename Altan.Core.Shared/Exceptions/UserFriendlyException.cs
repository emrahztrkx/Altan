using System;

namespace Altan.Core.Shared.Exceptions
{
    public class UserFriendlyException : Exception
    {
        private UserFriendlyException()
        {
        }

        public UserFriendlyException(ExceptionCode code, string message) : base(message)
        {
            Code = (int) code;
        }

        public int Code { get; }
    }
}
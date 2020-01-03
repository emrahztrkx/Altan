using System;

namespace Altan.Core.Shared.Exceptions
{
    public class UserFriendlyException : Exception
    {
        public string Message { get; set; }

        public int Code { get; set; }
    }
}
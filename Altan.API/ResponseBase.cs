namespace Altan.API
{
    
    public class ResponseBase 
    {
        public  bool IsSuccess { get;  set; }

        public  int Code { get;   set; }

        public  string Message { get;   set; }
        
        public ResponseBase()
        {
            IsSuccess = true;
        }
        public ResponseBase(bool isSuccess = true)
        {
            IsSuccess = isSuccess;
        }
        
        public ResponseBase(int code, string message, bool isSuccess=true)
        {
            Code = code;
            Message = message;
            IsSuccess = isSuccess;
        }
    }

    public sealed class ResponseBase<T> :ResponseBase
        where T : class, new()
    {
        public ResponseBase()
        {
            IsSuccess = true;
        }
        public ResponseBase(T result = null, bool isSuccess = true)
        {
            IsSuccess = isSuccess;
            Result = result;
        }

        public ResponseBase(int code, string message, T result = null, bool isSuccess = true)
        {
            Code = code;
            Message = message;
            IsSuccess = isSuccess;
            Result = result;
        }

        public T Result { get; set; }
    }
}
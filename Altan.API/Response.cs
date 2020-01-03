namespace Altan.API
{
    public class Response : Response<object>
    {
        public Response()
        {
            
        }
        public Response(bool isSuccess = true):base(isSuccess)
        {
            IsSuccess = isSuccess;
        }
        
        public Response(int code, string message, bool isSuccess=true) : base(code, message)
        {
            Code = code;
            Message = message;
            IsSuccess = isSuccess;
        }
    }

    public class Response<T> where T : class, new()
    {
        public Response()
        {
            
        }
        public Response(T result = null, bool isSuccess = true)
        {
            IsSuccess = isSuccess;
            Result = result;
        }

        public Response(int code, string message, T result = null, bool isSuccess = true)
        {
            Code = code;
            Message = message;
            IsSuccess = isSuccess;
            Result = result;
        }

        public bool IsSuccess { get; set; }

        public int Code { get; set; }

        public string Message { get; set; }

        public T Result { get; set; }
    }
}
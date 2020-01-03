namespace Altan.API
{
    public class BaseResponse : BaseResponse<object>
    {
        public BaseResponse()
        {
            
        }
        public BaseResponse(bool isSuccess = true):base(isSuccess)
        {
            
        }
        
        public BaseResponse(int code, string message, bool isSuccess=true) : base(code, message)
        {
        }
    }

    public class BaseResponse<T> where T : class, new()
    {
        public BaseResponse()
        {
            
        }
        public BaseResponse(T result = null, bool isSuccess = true)
        {
            IsSuccess = isSuccess;
            Result = result;
        }

        public BaseResponse(int code, string message, T result = null, bool isSuccess = true)
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
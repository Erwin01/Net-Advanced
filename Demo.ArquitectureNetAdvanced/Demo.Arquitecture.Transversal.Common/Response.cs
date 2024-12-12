using System;

namespace Demo.Arquitecture.Transversal.Common
{
    public class Response<T>
    {
        public T Data { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }
        public Exception LogError { get; set; }


        public static Response<T> Success(T data, string message, bool isSuccess)
        {
            return new Response<T>
            {
                Message = message,
                IsSuccess = isSuccess,
                Data = data
            };
        }

        public static Response<T> Error(T data, Exception exception, string message, bool isSuccess)
        {
            return new Response<T>
            {
                LogError = exception,
                Message = message,
                IsSuccess = isSuccess,
                Data = data
            };
        }
    }
}

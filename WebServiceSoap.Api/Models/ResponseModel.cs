namespace WebServiceSoap.Api.Models
{
    public class ResponseModel<T>
    {
        public T Data { get; set; }
        public int ResultCode { get; set; }
        public string Message { get; set; }
    }
}
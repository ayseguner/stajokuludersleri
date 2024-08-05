namespace Core.Common.Abstract
{
    public interface IResult<T>
    {
        bool IsSuccess { get; set; }
        string Message { get; set; }
        T Data { get; set; }
    }
}

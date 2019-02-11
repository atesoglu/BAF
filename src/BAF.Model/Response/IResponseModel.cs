using System.Collections.Generic;

namespace BAF.Model.Response
{
    public interface IResponseModel<out T>
    {
        string UId { get; }
        bool Success { get; }
        string Message { get; }

        int Total { get; }
        T Data { get; }

        ICollection<KeyValuePair<string, string>> Errors { get; set; }
        ICollection<KeyValuePair<string, string>> Params { get; set; }

        IResponseModel<T> AddError(string error);
        IResponseModel<T> AddError(string header, string body);

        IResponseModel<T> AddParam(string key, string value);
    }
}
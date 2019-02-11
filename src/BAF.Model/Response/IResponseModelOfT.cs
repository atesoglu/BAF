using System.Collections.Generic;
using BAF.Model.Data;

namespace BAF.Model.Response
{
    public interface IResponseModelOfT<out T>
    {
        string UId { get; }
        bool Success { get; }
        string Message { get; }

        int Total { get; }
        T Data { get; }

        ICollection<KeyValuePair<string, string>> Errors { get; set; }
        ICollection<KeyValuePair<string, string>> Params { get; set; }

        IResponseModelOfT<T> AddError(string error);
        IResponseModelOfT<T> AddError(string header, string body);

        IResponseModelOfT<T> AddPair(string key, string value);
    }
}
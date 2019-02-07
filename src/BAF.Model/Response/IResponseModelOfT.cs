using System.Collections.Generic;
using BAF.Model.Data;

namespace BAF.Model.Response
{
    public interface IResponseModelOfT<out TObjectModel>
        where TObjectModel : ObjectModelBase
    {
        string UId { get; }
        bool Success { get; }
        string Message { get; }

        int Total { get; }
        TObjectModel Data { get; }

        ICollection<KeyValuePair<string, string>> Errors { get; set; }
        ICollection<KeyValuePair<string, string>> Params { get; set; }

        IResponseModelOfT<TObjectModel> AddError(string error);
        IResponseModelOfT<TObjectModel> AddError(string header, string body);

        IResponseModelOfT<TObjectModel> AddPair(string key, string value);
    }
}
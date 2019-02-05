using System.Collections.Generic;
using BAF.Model.Data;

namespace BAF.Model.Response
{
    public interface IResponseModelOfT<out TObjectModel, TIdType>
        where TObjectModel : ObjectModelBaseOfT<TIdType>
    {
        string UId { get; }
        bool Success { get; }
        string Message { get; }

        int Total { get; }
        TObjectModel Data { get; }

        ICollection<KeyValuePair<string, string>> Errors { get; set; }
        ICollection<KeyValuePair<string, string>> Pairs { get; set; }

        IResponseModelOfT<TObjectModel, TIdType> AddError(string error);
        IResponseModelOfT<TObjectModel, TIdType> AddError(string header, string body);

        IResponseModelOfT<TObjectModel, TIdType> AddPair(string key, string value);
    }
}
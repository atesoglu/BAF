using System;
using System.Collections.Generic;

namespace BAF.Model.Response
{
    public class ResponseModel<T> : IResponseModel<T>
    {
        public string UId { get; set; }
        public bool Success => Errors == null || Errors.Count == 0;
        public string Message { get; set; }
        public int Total { get; set; }
        public T Data { get; set; }

        public ICollection<KeyValuePair<string, string>> Errors { get; set; }
        public ICollection<KeyValuePair<string, string>> Params { get; set; }

        public ResponseModel()
        {
            UId = Guid.NewGuid().ToString("N");
        }

        public IResponseModel<T> AddError(string error)
        {
            return AddError(null, error);
        }
        public virtual IResponseModel<T> AddError(string header, string body)
        {
            Errors = Errors ?? new List<KeyValuePair<string, string>>();

            Errors.Add(new KeyValuePair<string, string>(header, body));

            return this;
        }
        public virtual IResponseModel<T> AddParam(string key, string value)
        {
            Params = Params ?? new List<KeyValuePair<string, string>>();

            Params.Add(new KeyValuePair<string, string>(key, value));

            return this;
        }
    }
}
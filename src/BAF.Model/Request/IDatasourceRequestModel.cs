using System.Collections.Generic;

namespace BAF.Model.Request
{
    public interface IDatasourceRequestModel
    {
        int Start { get; }
        int Limit { get; }
        ICollection<IDatasourceRequestSortModel> Sorts { get; set; }
    }

    public enum DatasourceRequestSortDirections { ASC = 1, DESC = 2 }

    public interface IDatasourceRequestSortModel
    {
        string Property { get; set; }
        DatasourceRequestSortDirections Direction { get; set; }
    }
}
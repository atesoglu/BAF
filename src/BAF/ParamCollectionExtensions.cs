namespace BAF
{
    public static class ParamCollectionExtensions
    {
        private const string KeyDefaultCollection = "DefaultConnection";

        public static string GetDefaultConnectionString(this ParamCollection paramCollection)
        {
            return paramCollection[KeyDefaultCollection];
        }
        public static void SetDefaultConnectionString(this ParamCollection paramCollection, string connectionString)
        {
            paramCollection[KeyDefaultCollection] = connectionString;
        }
    }
}
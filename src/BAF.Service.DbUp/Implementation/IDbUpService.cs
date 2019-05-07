namespace BAF.Service.DbUp.Implementation
{
    public interface IDbUpService
    {
        IDbUpMigrationResult Migrate();
    }
}
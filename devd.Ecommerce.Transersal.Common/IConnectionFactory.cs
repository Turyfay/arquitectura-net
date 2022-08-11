using System.Data;


namespace devd.Ecommerce.Transersal.Common
{
    public interface IConnectionFactory
    {
        IDbConnection dbConnection { get; }
    }
}

using System.Data;

namespace Demo.Arquitecture.Transversal.Common
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection { get; }
    }
}

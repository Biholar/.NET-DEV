using SkillManagement.DataAccess.Core;
using SkillManagement.DataAccess.Entities.SQLEntities;
using SkillManagement.DataAccess.Interfaces;
using SkillManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace SkillManagement.DataAccess.Repositories
{
    public class SQLScoreRepository : GenericRepository<SQLScore, int>, ISQLScoreRepository
    {
        private static string _tableName;

        public SQLScoreRepository(IConnectionFactory connectionFactory, IConfiguration config) : base(connectionFactory, _tableName, false)
        {
            var connectionString = config["connectionString:DefaultConnection"];
            connectionFactory.SetConnection(connectionString);
        }
    }
}

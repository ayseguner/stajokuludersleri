using Core.Models.Response;
using Dapper;
using DataAccess.Queries;
using DataAccess.Repositories.Abstract;
using System.Data.SqlClient;

namespace DataAccess.Repositories.Concrete
{
    public class PlantRepository : IPlantRepository
    {
        public async Task<List<GetPlantInformationsResponseModel>> GetPlantInformationsAsync()
        {
            using var connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=StajOkulu;Trusted_Connection=true");
            var response = await connection.QueryAsync<GetPlantInformationsResponseModel>(
                sql: PlantQueries.GET_PLANT_INFORMATIONS,
                commandTimeout: 0);
            return response.ToList();
        }
    }
}

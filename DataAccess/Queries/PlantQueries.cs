namespace DataAccess.Queries
{
    public class PlantQueries
    {
        protected PlantQueries()
        {

        }

        internal const string GET_PLANT_INFORMATIONS = @"
SELECT *
FROM [dbo].[Plants]";
    }
}

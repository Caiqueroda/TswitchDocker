namespace DockerSampleAPI.Services
{
    public class Configure
    {
        // Remova o campo _configuration

        public static string DockerConfigDb(IConfiguration configuration)
        {
            var server = configuration["DatabaseServer"] ?? "";
            var port = configuration["DatabasePort"] ?? "";
            var user = configuration["DatabaseUser"] ?? "";
            var password = configuration["DatabasePassword"] ?? "";
            var database = configuration["DatabaseName"] ?? "";

            var connectionString = $"Server={server},{port};Initial Catalog={database};User ID={user};Password={password};Encrypt=False";

            return connectionString;
        }
    }
}
namespace BusTransportationModel.Service.Settings
{
    public static class BusTransportationModelSettingsReader
    {
        public static BusTransportationModelSettings Read(IConfiguration configuration)
        {
            return new BusTransportationModelSettings()
            {
                BusTransportationModelDbContextConnectionString = configuration.GetValue<string>("FitnessClubDbContext")
            };
        }
    }
}
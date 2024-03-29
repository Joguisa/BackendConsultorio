﻿namespace BackendConsultorio.Connection
{
    public class CadenaDAL
    {
        public string cadena { get; set; }
        public CadenaDAL()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder();

            builder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"));
            var root = builder.Build();
            cadena = root.GetConnectionString("db");
        }
    }
}

namespace PeliculasApi.Servicios
{
    public class AlmacenadorArchivosAzure : IAlmacenadorArchivos
    {
        public Task BorrarArchivo(string ruta, string contenedor)
        {
            throw new NotImplementedException();
        }

        public Task<string> EditarArchivo(byte[] contenido, string extension, string contenedor, string ruta, string contextType)
        {
            throw new NotImplementedException();
        }

        public Task<string> GuardarArchivo(byte[] contenido, string extension, string contenedor, string contextType)
        {
            throw new NotImplementedException();
        }
    }
}

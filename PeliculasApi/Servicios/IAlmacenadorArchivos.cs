namespace PeliculasApi.Servicios
{
    public interface IAlmacenadorArchivos
    {
        Task<string> GuardarArchivo(byte[] contenido, string extension, string contenedor, string contextType);
        Task<string>  EditarArchivo(byte[] contenido, string extension, string contenedor, string ruta, string contextType);
        Task BorrarArchivo(string ruta, string contenedor);
    }
}

namespace Patron_Builder_Formativa.Caso1_Usuario
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string EstadoCuenta { get; set; }

        public override string ToString() =>
            $"Usuario: {Nombre} | Correo: {Correo} | Rol: {Rol} | Estado: {EstadoCuenta}";
    }
}
namespace Patron_Builder_Formativa.Caso1_Usuario
{
    public class UsuarioBuilder
    {
        private Usuario _usuario = new Usuario();

        public UsuarioBuilder(string nombre, string correo)
        {
            _usuario.Nombre = nombre;
            _usuario.Correo = correo;
            _usuario.EstadoCuenta = "Activo";
        }

        public UsuarioBuilder ConRol(string rol) { _usuario.Rol = rol; return this; }
        public UsuarioBuilder ConTelefono(string tel) { _usuario.Telefono = tel; return this; }
        public Usuario Build() => _usuario;
    }
}
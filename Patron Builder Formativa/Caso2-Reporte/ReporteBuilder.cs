namespace Patron_Builder_Formativa.Caso2_Reporte
{
    public class ReporteBuilder
    {
        private Reporte _reporte = new Reporte();

        public ReporteBuilder(string titulo)
        {
            _reporte.Titulo = titulo;
        }

        public ReporteBuilder DefinirAutor(string autor)
        {
            _reporte.Autor = autor; 
            return this;
        }

        public ReporteBuilder AgregarSeccion(string nombre, string contenido)
        {
            _reporte.Secciones.Add($"[{nombre.ToUpper()}]: {contenido}");
            return this;
        }

        public Reporte Build() => _reporte;
    }
}
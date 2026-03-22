# Patrón Builder - Formativa Semana 9
Este repositorio contiene la resolución de los ejercicios de la **Semana 9**, enfocados en la implementación del **Patrón de Diseño Builder** para simplificar la creación de objetos complejos en C#.

## Casos Implementados

### 1. Registro de Usuario 
Se diseñó un constructor flexible para perfiles de usuario. Permite gestionar datos obligatorios como el nombre y correo, mientras que campos como el teléfono o el rol se agregan de forma opcional mediante el Builder, evitando constructores saturados.

### 2. Generador de Reportes 
Sistema dinámico para la creación de reportes informáticos. El Builder permite añadir gradualmente secciones de títulos, tablas de datos, gráficos y conclusiones, adaptándose a las necesidades de cada reporte.

---

## Ejecución Local

Si deseas probar el código en tu máquina:

1. Clona el repositorio.
2. Abre la terminal en la carpeta del proyecto.
3. Ejecuta:
```bash
dotnet run

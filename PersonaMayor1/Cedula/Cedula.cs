
namespace PersonaMayor1.Cedula
{
    public class Cedula
    {
        #region "atributos de nuestra clase"
        private string Nombres;
        private string Apellidos;
        private int Edad;
        string linea = string.Empty;

        #endregion

        #region"metodos de la clase"
        public void ObtenerDatos()
        {
            Console.WriteLine(" Ingrese los nombres del contacto");
            linea = Console.ReadLine();
            Nombres = Convert.ToString(linea);
            Console.WriteLine(" Ingrese el los apellidos del contacto ");
            linea = Console.ReadLine();
            Apellidos = Convert.ToString(linea);
            Console.WriteLine(" Ingrese la edad del contacto ");
            linea = Console.ReadLine();
            Edad = Convert.ToInt32(linea);

            if (Edad > 18)
            {
                Console.WriteLine(" $El contacto " + Nombres + Apellidos + " Es mayor de 18 años");
            }
            else
            {
                Console.WriteLine(" $El contacto " + Nombres + Apellidos + " No  es mayor de 18 años");
            }

        }
        #endregion
    }
}

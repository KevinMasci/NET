namespace ClasePersona
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNac;
        private int _dni;

        public Persona (string nombre, string apellido, DateTime fechaNac, int dni)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._fechaNac = fechaNac;
            this._dni = dni;
            Console.WriteLine("Objeto construido");
        }

        ~Persona()
        {
            Console.WriteLine("Objeto destruido");
        }

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public string Apellido
        { 
            get => _apellido; 
            set => _apellido = value; 
        }

        public DateTime FechaNac
        { 
            get => _fechaNac; 
            set => _fechaNac = value;
        }

        public int DNI
        { 
            get => _dni; 
            set => _dni = value;
        }

        public string GetFullName()
        {
            return _nombre + " " + _apellido;
        }

        public int GetAge()
        {
            DateTime diaActual = DateTime.Now;
            int diasVividos = diaActual.Subtract(_fechaNac).Days;

            return diasVividos / 365;
        }
    }
}
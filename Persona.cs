namespace c41
{
    public class Person
    {
        private static int contadorDNI = 0;
        private string _documento = "";
        private string _nombre = "";
        private int _edad = 0;
        private char _sexo = 'M';
        private int _dni = 0;
        private double _peso = 0.0;
        private double _altura = 0.0;

        public Person() { }

        public Person(string documento, string nombre, int edad, char sexo)
        {
            sexo = char.ToUpper(sexo);
            if (sexo == 'M' || sexo == 'F')
            {
                _sexo = sexo;
            }
            else
            {
                _sexo = 'M';
            }
            _documento = documento;
            _nombre = nombre;
            _edad = edad;

        }

        public Person(string documento, string nombre, int edad, char sexo, int dni, double peso, double altura)
        {
            _documento = documento;
            _nombre = nombre;
            _edad = edad;
            _sexo = sexo;
            _dni = dni;
            _peso = peso;
            _altura = altura;
        }

        public string Documento { get => _documento; set => _documento = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public char Sexo { get => _sexo; set => _sexo = value; }
        public double Peso { get => _peso; set => _peso = value; }
        public double Altura { get => _altura; set => _altura = value; }


        public EstadoPeso CalcularIMC(double peso, double altura)
        {
            _altura = altura;
            _peso = peso;
            double imc = _peso / (_altura * _altura);


            if (imc < 18.5)
            {
                return EstadoPeso.BajoPeso;
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                return EstadoPeso.PesoIdeal;

            }
            else if (imc >= 25 && imc <= 29.9)
            {
                return EstadoPeso.Sobrepeso;
            }
            else if (imc >= 30 && imc <= 39.9)
            {
                return EstadoPeso.Obeso;
            }
            else
            {
                return EstadoPeso.ObesidadExtrema;
            }

        }
        public bool esMayorDeEdad()
        {
            return _edad >= 18 ? true : false;
        }
        public void ComprobarSexo(char sexo)
        {
            sexo = char.ToUpper(sexo);

            if (sexo == 'M' || sexo == 'F')
            {
                _sexo = sexo;
            }
            else
            {
                _sexo = 'M';
            }
        }
        public void ListarInfo()
        {
            Console.WriteLine("Nombre: {0}", _nombre);
            Console.WriteLine("edad: {0}", _edad);
            Console.WriteLine("Genero: {0}", _sexo);
            Console.WriteLine("Documento: {0}", _documento);
            Console.WriteLine("DNI: {0}", _dni);
            Console.WriteLine("Peso: {0}", _peso);
            Console.WriteLine("Altura: {0}", _altura);
            Console.ReadLine();
        }
        public void GenerarDNI()
        {
            contadorDNI++;
            _dni = contadorDNI;

        }
    }
    public enum EstadoPeso
    {
        BajoPeso = -1,
        PesoIdeal = 0,
        Sobrepeso = 1,
        Obeso = 2,
        ObesidadExtrema = 3
    }

}
namespace c41
{
    public class Person{
        private string _documento = "";
        private string _nombre = "";
        private int _edad = 0;
        private char _sexo = "M";
        private int _dni = 0;
        private double _peso = 0.0;
        private double _altura = 0.0;

        public Person(){}

        public Person(string documento, string nombre, int edad, char sexo)
        {
            _documento = documento;
            _nombre = nombre;
            _edad = edad;
            _sexo = sexo;
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
        public int Dni { get => _dni; set => _dni = value; }
        public char Sexo { get => _sexo; set => _sexo = value; }
        public double Peso { get => _peso; set => _peso = value; }
        public double Altura { get => _altura; set => _altura = value; }

        public void CalcularIMC(){}
        public void esMayorDeEdad(){}
        public void ComprobarSexo(){}
        public void ListarInfo(){}
        public void GenerarDNI(){}
        


        
    }
    
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public int Edad { get; set; }
        public string Cargo { get; set; }
        public double salario { get; set; }

        public Empleado(int id, string nombre, string apellido, int edad, string cargo, double salario)
        {
            Id = id;
            Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Cargo = cargo;
            this.salario = salario;
        }
        public override string ToString()
        {
            return $"Id: {Id} Nombre: {Nombre} Apellido: {Apellido} Edad: {Edad} Cargo: {Cargo} Salario: {salario}";
        }
    }
}

using System;

namespace Laboratorio
{
    class Program
    {
        static void Main(string[] args)
        {
            string databasePath = "c:\\tmp\\gestorEmpleados.db";
            GestorEmpleados Empleados = new GestorEmpleados(databasePath);

            Empleados.CrearTabla();

            // Agrega un empleado
            Empleado empleado1 = new Empleado(1, "John", "Doe", 30, "Desarrollador", 2500.75);
            Empleados.AgregarEmpleado(empleado1);

            // Agrega otro empleado
            Empleado empleado2 = new Empleado(2, "Jane", "Doe", 28, "Desarrollador", 3000.10);
            Empleados.AgregarEmpleado(empleado2);

            //Agrega otro empleado
            Empleado empleado3 = new Empleado(3, "Juan", "Perez", 35, "Desarrollador", 3000.10);
            Empleados.AgregarEmpleado(empleado3);

            //Agrega otro empleado
            Empleado empleado4 = new Empleado(4, "Pedro", "Gomez", 40, "Desarrollador", 3000.10);
            Empleados.AgregarEmpleado(empleado4);

            //Agrega otro empleado
            Empleado empleado5 = new Empleado(5, "Maria", "Gomez", 40, "Desarrollador", 4000);
            Empleados.AgregarEmpleado(empleado5);

            //Agrega otro empleado
            Empleado empleado6 = new Empleado(6, "Jose", "Gomez", 40, "Desarrollador", 3000.10);
            Empleados.AgregarEmpleado(empleado6);

            //Agrega otro empleado con un cargo diferente a desarrollador

            Empleado empleado7 = new Empleado(7, "Jose", "Gomez", 40, "Gerente", 7000.69);
            Empleados.AgregarEmpleado(empleado7);

            //Agrega otro empleado con un cargo diferente a desarrollador y gerente

            Empleado empleado8 = new Empleado(8, "Jose", "Gomez", 40, "Director", 10500.8);
            Empleados.AgregarEmpleado(empleado8);

            // Obtén la lista de empleados y muéstrala en la consola
            var empleados = Empleados.ObtenerEmpleados();
            foreach (var empleado in empleados)
            {
                Console.WriteLine($"ID: {empleado.Id}, Nombre: {empleado.Nombre}, Apellido: {empleado.Apellido}, Edad: {empleado.Edad}, Cargo: {empleado.Cargo}, Salario: {empleado.salario}");
            }

            Console.ReadLine();
        }
    }
}
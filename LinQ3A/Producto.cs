using System;

namespace EjemplosWin
{
    public  class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public int Salario { get; set; }
        public int EmpresaID { get; set; }
        public void GetDatosEmpleado()
        {
            Console.WriteLine("Empleado {0} con Id {1}, con Cargo {2}, con Salario {3} y pertenece a " +
                "La empresa {4}", Nombre, Id, Cargo, Salario, EmpresaID);
        }
    }
}

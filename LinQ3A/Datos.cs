using System.Collections;
using System.Collections.Generic;

namespace EjemplosWin
{
    public static class Datos
    {
        public static int[] Numeros = 
            { 23, 89, 10, 5, 56, 12, 98, 76, 85, 42, 7, 18, 34, 15 };

        public static ArrayList MiLista = new ArrayList
            { 5, "hola", 89, 1.7, "sopa", 7.5, 45, "A", 32 };

        public static IList<Empleado> Empleados = new List<Empleado>
        {
            new Empleado { Id = 1, Nombre = "Martin", Cargo = "Gerente", EmpresaID = 1, Salario = 70000 },
            new Empleado { Id = 2, Nombre = "Maria", Cargo = "Gerente", EmpresaID = 2, Salario = 70000 },
            new Empleado { Id = 3, Nombre = "Pedro", Cargo = "Empleado", EmpresaID = 1, Salario = 30000 },
            new Empleado { Id = 4, Nombre = "Daniel", Cargo = "Empleado", EmpresaID = 1, Salario = 30000 },
            new Empleado { Id = 5, Nombre = "Diego", Cargo = "Empleado", EmpresaID = 2, Salario = 30000 },
            new Empleado { Id = 6, Nombre = "Soledad", Cargo = "Empleado", EmpresaID = 1, Salario = 30000 },
            new Empleado { Id = 7, Nombre = "Laura", Cargo = "Empleado", EmpresaID = 2, Salario = 30000 },
            new Empleado { Id = 8, Nombre = "Mirta", Cargo = "Empleado", EmpresaID = 1, Salario = 30000 },
            new Empleado { Id = 9, Nombre = "Leandro", Cargo = "Empleado", EmpresaID = 2, Salario = 30000 },
            new Empleado { Id = 10, Nombre = "Leonardo", Cargo = "Empleado", EmpresaID = 2, Salario = 30000 },
            new Empleado { Id = 11, Nombre = "Pepe", Cargo = "Encargado", EmpresaID = 2, Salario = 45000 },
            new Empleado { Id = 12, Nombre = "Marta", Cargo = "Encargado", EmpresaID = 1, Salario = 45000 }

        };
    }
}

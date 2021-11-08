using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Datos.Data;
using Datos.Models;

namespace Datos.Admin
{
    public static class AdmPaciente
    {
        //private static DbClinicaContext
        static DbClinicaContext context = new DbClinicaContext();
        public static List<Paciente> Listar()
        {
           
            return context.Pacientes.ToList();
            //Todo implementar Listar() 
           
        }

        public static Paciente TraerPorId(int id)
        {
            //Todo implementar TraerPorId(int id)
            return context.Pacientes.Find(id);
        }

        public static int Insertar(Paciente paciente)
        {
            context.Pacientes.Add(paciente);
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
            //Todo implementar Insertar(Paciente paciente)
        }

        public static int Modificar(Paciente paciente)
        {
            Paciente pacienteOrigen = context.Pacientes.Find(paciente);
            if (pacienteOrigen != null)
            {
                pacienteOrigen.Nombre =paciente.Nombre;
                pacienteOrigen.Apellido =paciente.Apellido;
                pacienteOrigen.FechaNacimiento =paciente.FechaNacimiento;
                pacienteOrigen.NroHistoriaClinica =paciente.NroHistoriaClinica;
                pacienteOrigen.MedicoID = paciente.MedicoID;
                return context.SaveChanges();
            }
            //Todo implementar Modificar(Paciente paciente)
            return 0;
        }

        public static int Eliminar(int id)
        {
            Paciente pacienteOrigen = context.Pacientes.Find(id);

            if (pacienteOrigen!= null)
            {
                context.Pacientes.Remove(pacienteOrigen);
                return context.SaveChanges();
            }
            //Todo implementar Eliminar(Paciente paciente)
            return 0;
        }
    }
}

    
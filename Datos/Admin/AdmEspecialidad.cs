using Datos.Data;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Admin
{
    public static class AdmEspecialidad
    {
        static DbClinicaContext context = new DbClinicaContext();
        public static List<Especialidad> Listar()
        {

            return context.Especialidades.ToList(); // con esto retornamos todos
        }

        public static List<Especialidad> TraerPorId(int especialidadId)
        {
            // linq to entities
            List<Especialidad> especialidades = (from m in context.Especialidades
                                                 where m.Id == especialidadId
                                                 select m).ToList(); // eso es el quivalente al metodo TOLIST. Esta Query trae todos los medicos de esa especialidad

            return especialidades;
        }

        //public static Especialidad TraerPorId(int EspecialidadId)
        //{
        //    return context.Especialidades.Find(EspecialidadId);
        //}
        public static int Insertar(Especialidad especialidad)
        {
            context.Especialidades.Add(especialidad);
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }
        public static int Modificar(Especialidad especialidad)
        {
            Especialidad especialidadOrigen = context.Especialidades.Find(especialidad.Id);

            if (especialidadOrigen != null)
            {
                especialidadOrigen.Id = especialidad.Id;
                especialidadOrigen.Nombre = especialidad.Nombre;

                return context.SaveChanges();
            }
            return 0;
        }
        public static int Eliminar(int id)
        {
            Especialidad especialidadOrigen = context.Especialidades.Find(id);
            if (especialidadOrigen != null)
            {
                context.Especialidades.Remove(especialidadOrigen);
                return context.SaveChanges();
            }
            return 0;
        }


    }

}

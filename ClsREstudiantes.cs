using Estudiantes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes.Repository
{
    class ClsREstudiantes : IEstudiante 
    {
        public void Create(estudiante estudiante)
        {
            using (EstudiantessEntities conexionBD = new EstudiantessEntities())
            {

                try
                {

                    

                    conexionBD.estudiante.Add(estudiante);
                    conexionBD.SaveChanges();
                    MessageBox.Show("Guardado");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el ingreso a la base de datos" + ex);
                }




            }



        }

        public void Delete(estudiante estudiante)
        {
           
        }

        public List<estudiante> ListOfDataEstudiante()
        {

            using (EstudiantessEntities conexionBD = new EstudiantessEntities())
            {

                List<estudiante>ListOfdata= conexionBD.estudiante.ToList();
                //select*from  estudiante


                return ListOfdata;
            }
        }
        
    }
}




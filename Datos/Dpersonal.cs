using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importamos las librerias de SQL
using System.Data;
using System.Data. SqlClient;
using SisttAsist.Logica;
using System.Windows.Forms;


namespace SisttAsist.Datos
{
    public class Dpersonal
    {
        public bool InsertarPersonal(Lpersonal parametros)
        {
			try //Proteger código
			{
                CONEXIONMAESTRA.abrir();
                //Siempre que se va a trabajar con insetar, eliminar o modificar se usa SqlCommand
                SqlCommand cmd = new SqlCommand("InsertarPersonal", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;//[ara pasarle parametros
                cmd.Parameters.AddWithValue("@Nombres", parametros.Nombres);
                cmd.Parameters.AddWithValue("@Identificacion", parametros.Identificacion);
                cmd.Parameters.AddWithValue("@Pais", parametros.Pais);
                cmd.Parameters.AddWithValue("@Id_cargo", parametros.Id_cargo);
                cmd.Parameters.AddWithValue("@SueldoPorHora", parametros.sueldoPorHora);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }



        }
        public bool editarPersonal(Lpersonal parametros)
        {
            try //Proteger código
            {
                CONEXIONMAESTRA.abrir();
                //Siempre que se va a trabajar con insetar, eliminar o modificar se usa SqlCommand
                SqlCommand cmd = new SqlCommand("editarPersonal", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;//[ara pasarle parametros
                cmd.Parameters.AddWithValue("@Id_personal", parametros.Id_personal);
                cmd.Parameters.AddWithValue("@Nombres", parametros.Nombres);
                cmd.Parameters.AddWithValue("@Identificacion", parametros.Identificacion);
                cmd.Parameters.AddWithValue("@Pais", parametros.Pais);
                cmd.Parameters.AddWithValue("@Id_cargo", parametros.Id_cargo);
                cmd.Parameters.AddWithValue("@SueldoPorHora", parametros.sueldoPorHora);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }



        }
        public bool eliminarPersonal(Lpersonal parametros)
        {
            try //Proteger código
            {
                CONEXIONMAESTRA.abrir();
                //Siempre que se va a trabajar con insetar, eliminar o modificar se usa SqlCommand
                SqlCommand cmd = new SqlCommand("eliminarPersonal", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;//[ara pasarle parametros
                cmd.Parameters.AddWithValue("@Id_personal", parametros.Id_personal);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }



        }
    }
}

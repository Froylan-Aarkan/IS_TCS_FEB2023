using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosLinqEscolar.Modelo
{
    public static class UsuarioDAO
    {
        public static List<usuario> obtenerUsuarios()
        {
            DataClassesEscolarUVDataContext conexionBD = getConnection();
            IQueryable<usuario> usuariosBD = from usuarioQuery in conexionBD.usuario select usuarioQuery;

            return usuariosBD.ToList();
        }

        public static Mensaje iniciarSesion(string username, string password)
        {
            DataClassesEscolarUVDataContext conexionBD = getConnection();

            var usuarioBD = (from userLogin in conexionBD.usuario where userLogin.username == username && userLogin.password == password select userLogin).FirstOrDefault();

            Mensaje mensajeInicioSesion;

            if(usuarioBD != null)
            {
                mensajeInicioSesion = new Mensaje()
                {
                    error = false,
                    mensaje = "Bienvenido...",
                    usuarioLogin = usuarioBD,
                };
            }else
            {
                mensajeInicioSesion = new Mensaje()
                {
                    error = true,
                    mensaje = "usuario no encontrado.",
                    usuarioLogin = null,
                };
            }

            return mensajeInicioSesion;
        }

        public static bool guardarUsuario(usuario usuarioNuevo)
        {
            try
            {
                DataClassesEscolarUVDataContext conexionBD = getConnection();
                var usuario = new usuario()
                {
                    nombre = usuarioNuevo.nombre,
                    apellidoPaterno = usuarioNuevo.apellidoPaterno,
                    apellidoMaterno = usuarioNuevo.apellidoMaterno,
                    username = usuarioNuevo.username,
                    password = usuarioNuevo.password
                };

                conexionBD.usuario.InsertOnSubmit(usuario);
                conexionBD.SubmitChanges();
                
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static Boolean editarUsuario(usuario usuarioAEditar)
        {
            try
            {
                DataClassesEscolarUVDataContext conexionBD = getConnection();
                var usuario = (from usuarioEdicion in conexionBD.usuario where usuarioEdicion.idUsuario == usuarioAEditar.idUsuario select usuarioEdicion).FirstOrDefault();

                if (usuario != null)
                {
                    usuario.nombre = usuarioAEditar.nombre;
                    usuario.apellidoPaterno = usuarioAEditar.apellidoPaterno;
                    usuario.apellidoMaterno = usuarioAEditar.apellidoMaterno;
                    usuario.password = usuarioAEditar.password;
                    conexionBD.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static Boolean eliminarUsuario(int idUsuario)
        {
            try
            {
                DataClassesEscolarUVDataContext conexionBD = getConnection();
                usuario usuarioEliminar = (from usuario in conexionBD.usuario where usuario.idUsuario == idUsuario select usuario).FirstOrDefault();

                if(usuarioEliminar != null)
                {
                    conexionBD.usuario.DeleteOnSubmit(usuarioEliminar);
                    conexionBD.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static DataClassesEscolarUVDataContext getConnection()
        {
            return new DataClassesEscolarUVDataContext(global::System.Configuration.ConfigurationManager.ConnectionStrings["escolaruvConnectionString"].ConnectionString);
        }
    }
}
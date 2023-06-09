﻿using ServiciosLinqEscolar.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiciosLinqEscolar
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public List<usuario> obtenerUsuarios()
        {
            return UsuarioDAO.obtenerUsuarios();
        }
        public Mensaje iniciarSesion(string username, string password)
        {
            return UsuarioDAO.iniciarSesion(username, password);
        }

        public bool guardarUsuario(usuario usuarioNuevo)
        {
            return UsuarioDAO.guardarUsuario(usuarioNuevo);
        }

        public bool editarUsuario(usuario usuarioEdicion)
        {
            return UsuarioDAO.editarUsuario(usuarioEdicion);
        }

        public bool eliminarUsuario(int idUsuario)
        {
            return UsuarioDAO.eliminarUsuario(idUsuario);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}

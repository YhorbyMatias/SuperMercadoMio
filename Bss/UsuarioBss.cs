using Dal;
using Ent;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss
{
    public class UsuarioBss
    {
        #region Objetos
        private UsuarioDal objetoUsuario = new UsuarioDal();
        #endregion
        #region Metodos
        public int authenticate(UsuarioEnt usuario)
        {
            return objetoUsuario.authenticate(usuario);
        }
        public int authenticateCi(UsuarioEnt usuario)
        {
            return objetoUsuario.authenticateCi(usuario);
        }
        public int authenticatePassword(UsuarioEnt usuario)
        {
            return objetoUsuario.authenticatePassword(usuario);
        }
        public int authenticateUserName(UsuarioEnt usuario)
        {
            return objetoUsuario.authenticateUserName(usuario);
        }
        public void delete(UsuarioEnt usuario)
        {
            objetoUsuario.delete(usuario);
        }
        public string getFullName(UsuarioEnt usuario)
        {
            return objetoUsuario.getFullName(usuario);
        }
        public int insert(UsuarioEnt usuario)
        {
            return objetoUsuario.insert(usuario);
        }
        public int login(UsuarioEnt usuario)
        {
            return objetoUsuario.login(usuario);
        }
        public DataTable search(UsuarioEnt usuario)
        {
            return objetoUsuario.search(usuario);
        }
        public DataTable searchAll()
        {
            return objetoUsuario.searchAll();
        }
        public void update(UsuarioEnt usuario)
        {
            objetoUsuario.update(usuario);
        }
        public void updatePassword(UsuarioEnt usuario)
        {
            objetoUsuario.updatePassword(usuario);
        }
        #endregion
    }
}
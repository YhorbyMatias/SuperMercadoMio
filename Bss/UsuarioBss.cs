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
        private UsuarioDal usuario = new UsuarioDal();
        #endregion
        #region Metodos
        public int authenticate(UsuarioEnt usuarioX)
        {
            return usuario.authenticate(usuarioX);
        }
        public int authenticateCi(UsuarioEnt usuarioX)
        {
            return usuario.authenticateCi(usuarioX);
        }
        public int authenticatePassword(UsuarioEnt usuarioX)
        {
            return usuario.authenticatePassword(usuarioX);
        }
        public int authenticateUserName(UsuarioEnt usuarioX)
        {
            return usuario.authenticateUserName(usuarioX);
        }
        public void delete(UsuarioEnt usuarioX)
        {
            usuario.delete(usuarioX);
        }
        public string getFullName(UsuarioEnt usuarioX)
        {
            return usuario.getFullName(usuarioX);
        }
        public int insert(UsuarioEnt usuarioX)
        {
            return usuario.insert(usuarioX);
        }
        public int login(UsuarioEnt usuarioX)
        {
            return usuario.login(usuarioX);
        }
        public DataTable search(UsuarioEnt usuarioX)
        {
            return usuario.search(usuarioX);
        }
        public DataTable searchAll()
        {
            return usuario.searchAll();
        }
        public void update(UsuarioEnt usuarioX)
        {
            usuario.update(usuarioX);
        }
        public void updatePassword(UsuarioEnt usuarioX)
        {
            usuario.updatePassword(usuarioX);
        }
        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.DAO;

namespace WinFormsApp2.Modelo
{
    internal class Controle
    {
        public bool tem;
        public String mensagem;

        public bool acessar(String email, String senha) {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem =loginDao.verificarLogin(email, senha);
            if(!loginDao.mensagem.Equals(senha))
            {
                mensagem = loginDao.mensagem;
            }
            return tem;
        }

        public String cadastrar(String email, String senha, String confSemha) { 
            return mensagem;
        }



    }
}

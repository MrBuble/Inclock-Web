﻿using System;
using Classes.VO;
using Classes.Common;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Web;
using System.Web.Security;

namespace Library.Inclock.web.br.BL
{
    public class Login
    {
        /// <summary>
        /// Metodo que faz um login com senha e 
        /// </summary>
        /// <param name="user">Objeto User </param>
        /// <returns>Retorna um Json do usuario</returns>
        public static Funcionario Logar(User user)
        {
            Funcionario funcionario = new Funcionario();
            try
            {
                using (var cliente = new Client())
                {
                    funcionario = cliente.Service.Logar(user.Senha, user.Login, "web");
                }
                if (funcionario.Id == 0)
                    return null;
            }
            catch (Exception ex)
            {
                return null;
                //isso foi feito so para teste 
                //     return new Funcionario { Id = 1, Nome = "Usuario Teste", Email = "kiko", Roles = new List<string> { "ADM", "FUNC", "PALHACO" } };
            }

            return funcionario;
        }
        public static Funcionario LoginForms(User user, string configPath)
        {
            try
            {
                var dici = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Funcionario>>(UtilFile.FileStringReader(configPath));
                return dici.Find(x => x.Senha == user.Senha && x.Login == user.Login);
            }
            catch (Exception)
            {
                return null;
            }

        }
        public static void Logout(int func, string dispositivo = "web")
        {
            using (Client client = new Client())
            {
                client.Service.ApagarSessao(func, dispositivo);
                var response = HttpContext.Current.Response;
            }
        }
    }
}

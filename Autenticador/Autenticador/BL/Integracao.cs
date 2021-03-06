﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using Classes.VO;
using Newtonsoft.Json;

using System.Diagnostics;
using System.ServiceModel.Channels;

namespace Autenticador.BL
{
    public class Integracao : IDisposable
    {
        public const string MENSAGEMERRO = "Você não tem privilegios necessarios";
        private WebHeaderCollection GetHeaders()
        {
            IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
            return request.Headers;
        }
        public bool ValidaSessao()
        {
            GetUserAgent();
            var headers = GetHeaders();
            return Autenticador.Autenticar(headers["integracao"]);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        private class Autenticador : Classes.Common.Role
        {
            public static bool Autenticar(string encryptedRoles)
            {
                try
                {
                    var stack = new StackTrace().GetFrame(2);
                    var bt = string.IsNullOrEmpty(encryptedRoles) ? new string[] { "" } : Classes.Common.Rijndael.DescriptografaFromBase64(encryptedRoles).Split(new[] { ';' });
                    return IsInRole<Service>(bt, stack.GetMethod().Name);
                }
                catch
                {
                    return false;
                }
            }
        }
        public static void GetUserAgent()
        {
            var request = WebOperationContext.Current;

            var bt = request.IncomingRequest.Headers["Host"];
        }

    }
}

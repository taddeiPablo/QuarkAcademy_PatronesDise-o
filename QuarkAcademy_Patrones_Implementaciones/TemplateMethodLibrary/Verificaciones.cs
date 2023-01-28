﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodLibrary
{
    public abstract class Verificaciones
    {
        protected Cliente _cliente;
        public string[] Verificar()
        {
            var msg = new List<string>();
            msg.Add($"Verificando crédito para {_cliente.Nombre}");
            msg.Add(VerificarAcciones());
            msg.Add(VerificarBalance());
            msg.Add(VerificarCreditos());
            msg.Add(VerificarIngresos());

            return msg.ToArray();
        }
        protected abstract string VerificarAcciones();
        protected abstract string VerificarBalance();
        protected abstract string VerificarCreditos();
        protected abstract string VerificarIngresos();
    }
}

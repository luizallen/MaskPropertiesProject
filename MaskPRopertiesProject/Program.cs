using System;
using MaskPropertiesProject.Models;
using MaskPropertiesProject.Services;

namespace MaskPropertiesProject
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var loggerHandler = new LoggerHandler();

            var user = 
                new User(
                    1,
                    "UsuarioTeste",
                    DateTime.Now);

            loggerHandler.HandleLog(user);
        }
    }
}

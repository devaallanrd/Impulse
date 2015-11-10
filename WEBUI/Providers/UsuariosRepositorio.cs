using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WEBUI.Models;

namespace WEBUI.Providers
{
    public class UsuariosRepositorio 
    {
        ArduinoDataContext Arduino = new ArduinoDataContext();

        public IList<Models.Usuario> EncontrarTodos()
        {
            var usuarios = from u in  Arduino.usuarios 

                           select new Models.Usuario
                           {
                               Code = u.code,
                               ID = u.id,
                               Auto = u.automovil,
                               Propietario = u.propietario,
                               Vencido = u.vencido,
                               Multas = (int) u.multas
                               
                           };


            return usuarios.ToList();
        }

      
        public Models.Usuario EncontrarUsuario(string code)
        {

            //Mi lista de todos los usuarios encontrados
            IList<Models.Usuario> users = EncontrarTodos();
            
            //Modelo de usuario esta en nulo
            Models.Usuario encontrado = new Models.Usuario(); 

            //Para cada usuario
            foreach (Models.Usuario usuario in users)
            {

                //SI el codigo == code
                if (code == usuario.Code)
                {
                   
                    //Usuario esta vencido
                    if (usuario.Vencido == "true") {
                        usuario.Multas = usuario.Multas + 1;
                        //Hagale una multa
                        UpdateMulta(code);
                       
                    }
                  
                    //Retorne al usuario que me encontro
                    encontrado = usuario;
                }
            }

            return encontrado;

        }

        public void UpdateMulta(string codex)
        {
            // Query the database for the row to be updated.
            var query =
                from user in Arduino.usuarios
                where user.code == codex
                select user;

            // Execute the query, and change the column values
            // you want to change.
            foreach (Providers.usuario user in query)
            {
                user.multas = user.multas + 1;
                
                // Insert any additional changes to column values.
            }

            // Submit the changes to the database.
            try
            {
                Arduino.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // Provide for exceptions.
            }
        }

        public void ToggleMarchamo(string codex, string vencido)
        {
            // Query the database for the row to be updated.
            var query =
                from user in Arduino.usuarios
                where user.code == codex
                select user;

            // Execute the query, and change the column values
            // you want to change.
            foreach (Providers.usuario user in query)
            {
                user.vencido = "false";

                // Insert any additional changes to column values.
            }

            // Submit the changes to the database.
            try
            {
                Arduino.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // Provide for exceptions.
            }
        }
       
       

    }
}
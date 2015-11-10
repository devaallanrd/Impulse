using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arduino
{
   public class Read
       {
       static void Main(string[] args)
       {

       }
           /*Si quieres probar esto por si solo lo puedes hacer 
            solamente desmarquen este codigo y conviertan las funciones estaticas.
           
           bool checky = check();
           if (checky)
           {
               Console.writeLine(read());

           }*/
       
     
        //Chequear si el puerto esta disponible
        public  bool check()
        {

            String[] portNames = SerialPort.GetPortNames();
            string found = Array.Find( portNames, s => s.Equals("COM4") ); //Pasarlo por parámetro
            if (found == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

       //Lectura en el puerto para esperar mensaje del arduino
        public  String read()
        {
            using (SerialPort sp = new SerialPort("COM4", 9600)) // Pasarlos por parámetro
            {
                try
                {
                    //Abre el puerto especifico 
                    sp.Open();

                    //Preparamos variables 
                    string returnMessage = "";
                    int intReturnASCII = 0;

                    /* Enciclamos el sp.ReadByte(); para obtener los bytes desde el arduino
                     * cada byte se pega a la linea de caracteres de retorno.
                     *  ## Esto deberia ser una tarea asyncrona ·##
                    */
                    while (true)
                    {
                        //Lee un byte
                        intReturnASCII = sp.ReadByte();

                        //Cuando lee un byte asigna a la cadena de retorno toda la cadena + el byte 
                        returnMessage = returnMessage + Convert.ToChar(intReturnASCII);

                        //La cantidad de caracteres que queremos leer del codigo de la tarjeta
                        if (returnMessage.Length == 26) // Pasarlo por parámetro
                        {
                            sp.Close();
                            return returnMessage;

                        }
                    }
                } 
                //Si encuentra un error en el proceso
                catch(Exception e){
                    sp.Close();
                    return "";
                }
                
                   
                }
            }
        }
    }


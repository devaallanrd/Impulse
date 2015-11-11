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
            string found = Array.Find( portNames, s => s.Equals("COM4") );
            if (found == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public  String read()
        {
            using (SerialPort sp = new SerialPort("COM13", 9600))
            {
                try
                {
                    sp.Open();
                    string returnMessage = "";
                    int intReturnASCII = 0;

                    while (true)
                    {
                        intReturnASCII = sp.ReadByte();
                        returnMessage = returnMessage + Convert.ToChar(intReturnASCII);
                        if (returnMessage.Length == 26)
                        {
                            sp.Close();
                            return returnMessage;

                        }
                    }
                } catch(Exception e){
                    sp.Close();
                    return "";
                }
                
                   
                }
            }
        }
    }


using Arduino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBUI.Models
{
    public class ArduinoModel
    {

        public string readData(){
            Read read = new Read();
            string x = read.read();
            return x;
      }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
    public class Common
    {
        public static void WriteToFile(this Exception ex)
        {
            using (StreamWriter sw = new StreamWriter("app.log", true))
            {
                sw.WriteLine
                (
                    $"{DateTime.Now}\n{ex}\n"
                );
            }
        }
    }
}


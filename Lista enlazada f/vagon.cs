﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_enlazada_f
{
    class vagon
    {
        public int Dato { get; set; }
        public vagon Sig { get; set; }

        public vagon(int dato)
        {
            Dato = dato;
            
        }
        public vagon()
        {
        }
       
        

}

    
        
    }


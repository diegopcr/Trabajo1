using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lista_enlazada_f
{
    class locomotora
    {
        vagon primero { get; set; }

        public void agregaFinal(int valor)
        {
            vagon Nuevo = vagon(valor);
            if (primero == null)
            {
                this.primero = Nuevo;

            }
            else
            {
                vagon tmp = this.primero;
                while (tmp.Sig != null)
                {
                    tmp = tmp.Sig;


                }
                tmp.Sig = Nuevo;
            }
        }

        public string VerVagones()
        {
            string ListaVag = "";
            vagon tmp = primero;
            while (tmp != null)
            {
                ListaVag += tmp.Dato + ",";
                tmp = tmp.Sig;
                return ListaVag;
            }
        }
    }
}

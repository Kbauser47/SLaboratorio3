using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLaboratorio3
{
    public class ColaCicular
    {

        public string[] colacirdatos = new string[100];
        public int primero = -1;
        public int ultimo = -1;
        public int MaxCola = 5;
        public string valor = "";

        public ColaCicular()
        {
            primero = -1;
            ultimo = -1;
        }

        public bool Vacia()
        {

            if (primero == -1 && ultimo == -1) return true;
            else return false;

        }

        public bool Llena()
        {

            if (((ultimo == MaxCola - 1) && (primero == 0)) || ((ultimo + 1) == primero)) return true;
            else return false;

        }

        public void Insertar(string insert)
        {

            if(Llena()) MessageBox.Show("Error: La cola circular esta LLENA");
            else
            {
                if (ultimo == MaxCola - 1) ultimo = 0;
                else
                {
                    ultimo++;
                    colacirdatos[ultimo] = insert;
                }
                if (primero == -1) primero = 0;
            }
        }

        public string Eliminar()
        {
            string valor = "";
            if (Vacia()) MessageBox.Show("Error: La cola circular esta VACIA");
            else
            {

                valor = colacirdatos[primero];
                if(primero == ultimo)
                {
                    primero = -1;
                    ultimo = -1;
                }
                else
                {
                    if (primero == MaxCola - 1) primero = 0;
                    else
                    {
                        primero++;
                    }
                }

            }
            return valor;
        }

    }
}

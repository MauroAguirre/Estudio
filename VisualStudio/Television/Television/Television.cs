using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Television
{
    class Television
    {
        #region Enums
        public enum Tipo { LED, LCD, Plasma, TRC };
        #endregion
        #region Atributos
        private string marca;
        private string modelo;
        private bool smart;
        private int tamaño;
        private int brillo;
        private int contraste;
        private int estado;
        private int volumen;
        private int canal;
        private Tipo tipos;
        #endregion
        #region Metodos
        public Television(string newMarca, string newModelo, int newTipo, bool newSmart, int newTamaño) 
        {
            marca = newMarca;
            modelo = newModelo;
            switch (newTipo)
            {
                case 1:
                    tipos = Tipo.LCD;
                    break;
                case 2:
                    tipos = Tipo.LED;
                    break;
                case 3:
                    tipos = Tipo.Plasma;
                    break;
                case 4:
                    tipos = Tipo.TRC;
                    break;
            }
            smart = newSmart;
            tamaño = newTamaño;
            estado = 2;
            canal = 1;
            volumen = 0;
            brillo = 50;
            contraste = 50;
        }
        public void CambiarEstado() 
        {
            if (estado != 3)
                estado++;
            else
                estado = 1;
        }
        public void AumentarBrillo() 
        {
            if (brillo != 100)
                brillo++;
        }
        public void DisminuirBrillo()
        {
            if (brillo != 1)
                brillo--;
        }
        public void AumentarContraste() 
        {
            if (contraste != 100)
                contraste++;
        }
        public void DisminuirContraste()
        {
            if (contraste != 1)
                contraste--;
        }
        public void SubirCanal() 
        {
            if (canal != 100)
                canal++;
            else
                canal = 1;
        }
        public void BajarCanal()
        {
            if (canal != 1)
                canal--;
            else
                canal = 100;
        }
        public void IngresarCanal(int can) 
        {
            if (can < 101 && can > -1)
                canal = can;
        }
        public void SubirVolumen() 
        {
            if (volumen != 100)
                volumen += 10;
        }
        public void BajarVolumen()
        {
            if (volumen != 0)
                volumen -= 10;
        }
        public override string ToString()
        {
            string esta="";
            switch(estado)
            {
                case 1:
                    esta = "Encendido";
                    break;
                case 2:
                    esta = "Apagado";
                    break;
                case 3:
                    esta = "Stand-by";
                    break;
            }
            return "Marca: " + marca + " Modelo: " + modelo + " Smart: " + smart + "\nTamaño: " + tamaño + " brillo: " + brillo + " Contraste: " + contraste + "\nEstado: " + esta + " Volumen: " + volumen + " Canal: " + canal + " Tipo: " + tipos;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Cliente
    {
        public enum Pais { Uruguay, Mercosur, otros };
        private int cedula;
        private string nombre;
        private Pais pais;
        private string mail;
        private int telefono;
        public Pais SuPais
        {
            get { return pais; }
        }

        public Cliente(int pais,int cedula,string nombre,string mail,int telefono)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.mail = mail;
            this.telefono = telefono;
            switch (pais)
            {
                case 1:
                    this.pais = Pais.Uruguay;
                    break;
                case 2:
                    this.pais = Pais.Mercosur;
                    break;
                case 3:
                    this.pais = Pais.otros;
                    break;
            }
        }
    }
}

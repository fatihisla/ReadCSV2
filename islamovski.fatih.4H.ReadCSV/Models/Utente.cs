﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static islamovski.fatih._4H.ReadCSV.Models.Utente;

namespace islamovski.fatih._4H.ReadCSV.Models
{
    public class Utente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }
        public string Tipo { get; set; }
        public Utente() 
        { 
            
        } 
        public Utente(string str)
        {

            string[] colonne = str.Split(';');

            Nome = colonne[0];
            Cognome = colonne[1];
            Email = colonne[2];
            Tipo = colonne[3];
        }
    }
        public class Utenti : List<Utente>
        {
            public Utenti(string filename)
            {
                StreamReader fin = new StreamReader("Utenti.csv");
                fin.ReadLine();
                while (!fin.EndOfStream)
                {
                    string str = fin.ReadLine();
                    Add(new Utente(str));
                }
                fin.Close();
            }

        }
}

        
       
    


using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RahastoGrafiikka
{
   
    class RAHASTO
    {
        Yhdista yhteys = new Yhdista();
        public DataTable haeSijoitukset()
        {
            MySqlCommand komento = new MySqlCommand("SELECT `Paiva`, `Rahasto`, `MarkkinaArvo` FROM `aktia`,`tilanne` WHERE aktia.RahastoId = tilanne.RahastoId", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        public DataTable haeArvot()
        {
            MySqlCommand komento = new MySqlCommand("SELECT `Paiva`, `Rahasto`, `MarkkinaArvo` FROM `aktia`,`tilanne` WHERE aktia.RahastoId = tilanne.RahastoId", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog
{
    public class blog
    {
        public string denumireBlog;
        public string idPoprietar;

        public void administrare() { }
        public void signup() { }
        public void signin() { }
        public void delogare() { }

        public List<int> listaDePersoaneAbonate = new List<int>();
        public void sendEmailTo() { }

        public List<int> idpagini = new List<int>();

        public blog() { }

        public void creazaONouaPagina() { }
        public void creazaONouaPersoana() { }
        public void creazaUnNouElement() { }

        public List<string> pagini = new List<string>();
        public List<string> persoane = new List<string>();
        public List<int> elemente = new List<int>();
        public List<int> meniuri = new List<int>();

        public void afisareMeniu() { }
        public void afisareSubMeniu() { }
        public void stergeMeniu() { }
        public void ascundeMeniu() { }

        public void afisarePagina(int i)
        {

            //cauta in lista de pagini pagina cu idPagina == i 
            //si afiseaza pagina 

        }
        public void schimbaPagina() { }
        public void stergePagina() { }
        public void duteLaPagina() { }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //bmp blogul meu personal
        public blog bmp = new blog();
        public persoana eu = new persoana();

        private void Form1_Load(object sender, EventArgs e)
        {
            eu.idPersoana = "razvan99x";
            eu.contul = "google.com";
            eu.prenume = "razvan";
            eu.nume = "numefamilie";
            eu.userName = "administrator";
            eu.userParola = "adminpassword";

            bmp.denumireBlog = "Blogul meu personal";
            bmp.idPoprietar = "razvan99x";
            bmp.persoane.Add(eu.idPersoana);

            element textbox = new element();
            textbox.idElement = 1;
            textbox.valoare = eu.idPersoana;
            textbox.denumireElement = "input type=textbox";
            textbox.pozitie = new punct2d(10.0f,10.0f);
            textbox.zorder = 1;

            bmp.elemente.Add(textbox.idElement);
            
            pagina homepage = new pagina();
            homepage.idpagina = "Home.html";
            homepage.idElemente.Add(textbox.idElement);

            bmp.pagini.Add(homepage.idpagina);

            bmp.afisareMeniu();
            bmp.afisarePagina(0);
        }
    }
}

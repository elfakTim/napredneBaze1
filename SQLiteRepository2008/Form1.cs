using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SQLiteRepository2008.Entiteti;
using NHibernate;

namespace SQLiteRepository2008
{
    public partial class Form1 : Form
    {
        private ISession session;
        private Adresa tmp;
        bool postavljeno;

        public Form1()
        {
            InitializeComponent();
            postavljeno = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            session = DataLayer.GetSession();

            IQuery q = session.CreateQuery("FROM Banka as b");

            try
            {
                if (postavljeno)
                {
                    IList<Banka> banke = q.List<Banka>();

                    foreach (Banka banka in banke)
                    {
                        cbListaBanaka.Items.Add(banka.nazivBanke);
                    }
                }

               
            }
            catch (ObjectNotFoundException exception)
            {
                MessageBox.Show("Ne postoji trazeni sektor!");
                return;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            session.Close();
        }

        private void btnDodjBanku_Click(object sender, EventArgs e)
        {
            
            Banka b = new Banka();
            b.nazivBanke = tbxNazivBanke.Text;

            FormAdresa f = new FormAdresa(session,b);
            f.Show();
        }

    

        private void cbListaBanaka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




    }
}

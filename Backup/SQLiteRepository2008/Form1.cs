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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            session = DataLayer.GetSession();
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            session.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sektor sek = new Sektor();
            sek.Naziv = "Proba sektor";

            session.SaveOrUpdate(sek);

            session.Flush();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sektor sek = session.Load<Sektor>(1);

            Radnik r = new Radnik();
            r.Ime = "Petar";
            r.Prezime = "Petrovic";
            r.Plata = 50000f;

            sek.DodajRadnika(r);

            session.SaveOrUpdate(r);

            session.Flush();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sef s = new Sef();

            s.Ime = "Marko";
            s.Prezime = "Markovic";

            s.Plata = 3000000f;

            s.DatumPostavljenja = new DateTime(2012, 11, 12);

            Sektor sektor = null;
            try
            {
                sektor = session.Load<Sektor>(1);

                sektor.DodajRadnika(s);

                session.SaveOrUpdate(s);

                session.Flush();

            }
            catch (ObjectNotFoundException exception)
            {
                MessageBox.Show("Ne postoji trazeni sektor!");
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Projekat p = new Projekat();

            p.Naziv = "Proba projekat";

            Sektor sektor = null;

            IQuery q = session.CreateQuery("FROM Radnik as r WHERE r.Sektor.Id = ?");
            q.SetInt32(0, 1);


            try
            {
                sektor = session.Load<Sektor>(1);
                sektor.DodajProjekat(p);
                IList<Radnik> radnici = q.List<Radnik>();

                foreach (Radnik radnik in radnici)
                {
                    radnik.Projekti.Add(p);
                    p.Radnici.Add(radnik);
                    session.SaveOrUpdate(radnik);
                    session.Flush();
                }

                session.SaveOrUpdate(p);
                session.Flush();
            }
            catch (ObjectNotFoundException exception)
            {
                MessageBox.Show("Ne postoji trazeni sektor!");
                return;
            }
        }

        
    }
}

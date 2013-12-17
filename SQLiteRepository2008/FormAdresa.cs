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
    public partial class FormAdresa : Form
    {
        private ISession session;
        private Banka b;
        private Donor d;
        private Zaposlen z;
        char tip;

        public FormAdresa(ISession session,Object obj)
        {
            this.session = session;
            if (obj is Banka)
            {
                this.b = (Banka)obj;
                this.tip = 'b';
            }
            else
                if (obj is Donor)
                {
                    this.d = (Donor)obj;
                    this.tip = 'd';
                }
                else
                    if (obj is Zaposlen)
                    {
                        this.z = (Zaposlen)obj;
                        this.tip = 'z';
                    }
            InitializeComponent();
        }

        private void btnDodajAdresu_Click(object sender, EventArgs e)
        {
            Adresa adr = new Adresa();
            adr.brUlice = System.Convert.ToInt32(nBrUlice.Value);
            adr.brZgrade = System.Convert.ToInt32(nBrZgrade.Value);
            adr.drzava = tbxDrzava.Text;
            adr.opstina = tbxOpstina.Text;
            adr.grad = tbxGrad.Text;
            adr.postanskiKod = tbxPosKod.Text;

            session.SaveOrUpdate(adr);
            session.Flush();

            if (tip == 'b')
            {
                b.adresaBanke = adr;
                session.SaveOrUpdate(b);
                session.Flush();
            }
            else
                if (tip == 'd')
                {
                    d.adresa = adr;
                    session.SaveOrUpdate(d);
                    session.Flush();
                }
                else
                    if (tip == 'z')
                    {
                        z.adresaZaposlenog = adr;
                        session.SaveOrUpdate(z);
                        session.Flush();
                    }
            this.Close();
        }
    }
}

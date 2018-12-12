﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Match_EventApp.Classes;

namespace Match_EventApp
{
    public partial class InlogForm : Form
    {
        Database dbs = new Database("studmysql01.fhict.local", "dbi412769", "dbi412769", "EventMatchPT12");

        public InlogForm()
        {
            InitializeComponent();
        }

        private void BTlogin_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text != null && tbPassword.Text != null)
            {
                if(dbs.login(tbUsername.Text, tbPassword.Text))
                {
                    MessageBox.Show("Ingelogd");
                }
                else
                {
                    MessageBox.Show("Gebruikersnaam en/of wachtwoord is onbekend.");
                }
            }
            else
            {
                MessageBox.Show("Geen lege invoervelden toegestaan.", "Waarschuwing");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTregister_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterForm f1 = new RegisterForm();
            f1.Show();
        }
    }
}
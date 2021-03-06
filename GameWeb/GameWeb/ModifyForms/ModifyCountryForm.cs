﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWeb.ModifyForms
{
    public partial class ModifyCountryForm : Form
    {
        private DatabaseConnection databaseConnection;
        private string id;
        public ModifyCountryForm(string id)
        {
            InitializeComponent();
            this.id = id;
            databaseConnection = DatabaseConnection.GetInstance();
        }

        private void genreName_Validating(object sender, CancelEventArgs e)
        {

            TextBox s = sender as TextBox;

            if (s.TextLength <= 0)
            {
                e.Cancel = true;
                s.Select(0, s.Text.Length);
                errorProvider.SetError(s, "Value is too short");
            }
        }

        private void genreName_Validated(object sender, EventArgs e)
        {
            TextBox s = sender as TextBox;
            errorProvider.SetError(s, string.Empty);
        }

        private void add_countryButton_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            string c_name = genreName.Text;
            if (!databaseConnection.CanCountryBeInsterted(c_name,""))
            {
                MessageBox.Show("This country already exist",
                                "Cannot change!",
                                MessageBoxButtons.OK);
                return;

            }
            if (this.databaseConnection.UpdateCountry(c_name, id))
                MessageBox.Show("Country updated", "Success!", MessageBoxButtons.OK);
            else
                MessageBox.Show("Error occur", "Failed!", MessageBoxButtons.OK);

            this.Close();

        }
    }
}

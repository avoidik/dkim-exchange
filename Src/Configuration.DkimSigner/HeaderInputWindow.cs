﻿using System;
using System.Windows.Forms;

namespace Configuration.DkimSigner
{
    public partial class HeaderInputWindow : Form
    {
        // ##########################################################
        // ##################### Variables ##########################
        // ##########################################################

        // ##########################################################
        // ##################### Construtor #########################
        // ##########################################################

        public HeaderInputWindow()
        {
            InitializeComponent();
        }

        // ##########################################################
        // ####################### Events ###########################
        // ##########################################################

        private void HeaderInputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK && txtHeader.Text == string.Empty)
            {
                MessageBox.Show(this, "You must enter a header!", "Value missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        // ##########################################################
        // ################# Internal functions #####################
        // ##########################################################

        // ###########################################################
        // ###################### Button click #######################
        // ###########################################################

        private void txtHeader_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) //return
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}

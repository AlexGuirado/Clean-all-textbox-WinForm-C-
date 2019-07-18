  public void limparTextBoxes(Control controle)
        {
            foreach (Control ctrl in controle.Controls)
            {

                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = string.Empty;
                }
                else if (ctrl.Controls.Count > 0)
                {
                    limparTextBoxes(ctrl);
                }

            }
        }
        
  //Call public for your clean button
     protected void btnLimpar_Click(object sender, EventArgs e)
        {
            limparTextBoxes(this);
        }

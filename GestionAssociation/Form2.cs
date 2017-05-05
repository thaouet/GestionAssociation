using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAssociation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void activiteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.activiteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetAssociation);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSetAssociation.Membre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.membreTableAdapter.Fill(this.dataSetAssociation.Membre);
            // TODO: cette ligne de code charge les données dans la table 'dataSetAssociation.Activite'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.activiteTableAdapter.Fill(this.dataSetAssociation.Activite);

        }
    }
}

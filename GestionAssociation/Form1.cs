using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace GestionAssociation
{
    public partial class Form1 : Form
    {

        SqlDataAdapter adapter;
        SqlConnection connexion;
        DataTable tableActivite;
        BindingSource activiteBinding;
        public Form1()
        {
            InitializeComponent();
            connexion = new SqlConnection("Server=COLOSSUS;Database=AssociationDB;User Id=sa;Password = zilla;");



            //dataadapter
            adapter = new SqlDataAdapter("Select IdActivite, LibelleActivite from Activite", connexion);


            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);


            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();


            //datatable
            tableActivite = new DataTable("Activite");

            tableActivite.Columns.Add("IdActivite", typeof(int));
            tableActivite.Columns.Add("LibelleActivite", typeof(String));
            DataColumn[] cleprimaire = { tableActivite.Columns[0] };
            tableActivite.PrimaryKey = cleprimaire;

            //liaison
            activiteBinding = new BindingSource();
            activiteBinding.DataSource = tableActivite;
            activiteBinding.PositionChanged += new EventHandler(ActiviteBinding_PositionChanged);



            dataGridActivite.DataSource = activiteBinding;

            textBoxId.DataBindings.Add("Text",activiteBinding, "IdActivite");
            textBoxLibelle.DataBindings.Add("Text", activiteBinding, "LibelleActivite");



        }

        private void ActiviteBinding_PositionChanged(object sender, EventArgs e)
        {
            labelposition.Text = ( activiteBinding.Position+1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //cherger les donnees

            adapter.Fill(tableActivite);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            activiteBinding.EndEdit();
            adapter.Update(tableActivite);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            activiteBinding.Position++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            activiteBinding.Position--;
        }
    }
}

namespace GestionAssociation
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idActiviteLabel;
            System.Windows.Forms.Label libelleActiviteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataSetAssociation = new GestionAssociation.DataSetAssociation();
            this.activiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activiteTableAdapter = new GestionAssociation.DataSetAssociationTableAdapters.ActiviteTableAdapter();
            this.tableAdapterManager = new GestionAssociation.DataSetAssociationTableAdapters.TableAdapterManager();
            this.membreTableAdapter = new GestionAssociation.DataSetAssociationTableAdapters.MembreTableAdapter();
            this.activiteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.activiteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idActiviteSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.libelleActiviteTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.membreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membreGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            idActiviteLabel = new System.Windows.Forms.Label();
            libelleActiviteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAssociation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activiteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activiteBindingNavigator)).BeginInit();
            this.activiteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idActiviteSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libelleActiviteTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membreGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // idActiviteLabel
            // 
            idActiviteLabel.AutoSize = true;
            idActiviteLabel.Location = new System.Drawing.Point(28, 40);
            idActiviteLabel.Name = "idActiviteLabel";
            idActiviteLabel.Size = new System.Drawing.Size(57, 13);
            idActiviteLabel.TabIndex = 1;
            idActiviteLabel.Text = "Id Activite:";
            // 
            // libelleActiviteLabel
            // 
            libelleActiviteLabel.AutoSize = true;
            libelleActiviteLabel.Location = new System.Drawing.Point(28, 66);
            libelleActiviteLabel.Name = "libelleActiviteLabel";
            libelleActiviteLabel.Size = new System.Drawing.Size(78, 13);
            libelleActiviteLabel.TabIndex = 3;
            libelleActiviteLabel.Text = "Libelle Activite:";
            // 
            // dataSetAssociation
            // 
            this.dataSetAssociation.DataSetName = "DataSetAssociation";
            this.dataSetAssociation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activiteBindingSource
            // 
            this.activiteBindingSource.DataMember = "Activite";
            this.activiteBindingSource.DataSource = this.dataSetAssociation;
            // 
            // activiteTableAdapter
            // 
            this.activiteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActiviteTableAdapter = this.activiteTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MembreTableAdapter = this.membreTableAdapter;
            this.tableAdapterManager.UpdateOrder = GestionAssociation.DataSetAssociationTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // membreTableAdapter
            // 
            this.membreTableAdapter.ClearBeforeFill = true;
            // 
            // activiteBindingNavigator
            // 
            this.activiteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.activiteBindingNavigator.BindingSource = this.activiteBindingSource;
            this.activiteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.activiteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.activiteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.activiteBindingNavigatorSaveItem});
            this.activiteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.activiteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.activiteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.activiteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.activiteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.activiteBindingNavigator.Name = "activiteBindingNavigator";
            this.activiteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.activiteBindingNavigator.Size = new System.Drawing.Size(588, 25);
            this.activiteBindingNavigator.TabIndex = 0;
            this.activiteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // activiteBindingNavigatorSaveItem
            // 
            this.activiteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.activiteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("activiteBindingNavigatorSaveItem.Image")));
            this.activiteBindingNavigatorSaveItem.Name = "activiteBindingNavigatorSaveItem";
            this.activiteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.activiteBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.activiteBindingNavigatorSaveItem.Click += new System.EventHandler(this.activiteBindingNavigatorSaveItem_Click);
            // 
            // idActiviteSpinEdit
            // 
            this.idActiviteSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.activiteBindingSource, "IdActivite", true));
            this.idActiviteSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idActiviteSpinEdit.Location = new System.Drawing.Point(112, 37);
            this.idActiviteSpinEdit.Name = "idActiviteSpinEdit";
            this.idActiviteSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idActiviteSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.idActiviteSpinEdit.TabIndex = 2;
            // 
            // libelleActiviteTextEdit
            // 
            this.libelleActiviteTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.activiteBindingSource, "LibelleActivite", true));
            this.libelleActiviteTextEdit.Location = new System.Drawing.Point(112, 63);
            this.libelleActiviteTextEdit.Name = "libelleActiviteTextEdit";
            this.libelleActiviteTextEdit.Size = new System.Drawing.Size(100, 20);
            this.libelleActiviteTextEdit.TabIndex = 4;
            // 
            // membreBindingSource
            // 
            this.membreBindingSource.DataMember = "FK_Membre_Activite";
            this.membreBindingSource.DataSource = this.activiteBindingSource;
            // 
            // membreGridControl
            // 
            this.membreGridControl.DataSource = this.membreBindingSource;
            this.membreGridControl.Location = new System.Drawing.Point(39, 118);
            this.membreGridControl.MainView = this.gridView1;
            this.membreGridControl.Name = "membreGridControl";
            this.membreGridControl.Size = new System.Drawing.Size(488, 220);
            this.membreGridControl.TabIndex = 5;
            this.membreGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.membreGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 358);
            this.Controls.Add(this.membreGridControl);
            this.Controls.Add(idActiviteLabel);
            this.Controls.Add(this.idActiviteSpinEdit);
            this.Controls.Add(libelleActiviteLabel);
            this.Controls.Add(this.libelleActiviteTextEdit);
            this.Controls.Add(this.activiteBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAssociation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activiteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activiteBindingNavigator)).EndInit();
            this.activiteBindingNavigator.ResumeLayout(false);
            this.activiteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idActiviteSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libelleActiviteTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membreGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetAssociation dataSetAssociation;
        private System.Windows.Forms.BindingSource activiteBindingSource;
        private DataSetAssociationTableAdapters.ActiviteTableAdapter activiteTableAdapter;
        private DataSetAssociationTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator activiteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton activiteBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.SpinEdit idActiviteSpinEdit;
        private DevExpress.XtraEditors.TextEdit libelleActiviteTextEdit;
        private DataSetAssociationTableAdapters.MembreTableAdapter membreTableAdapter;
        private System.Windows.Forms.BindingSource membreBindingSource;
        private DevExpress.XtraGrid.GridControl membreGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
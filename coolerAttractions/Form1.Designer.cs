namespace coolerAttractions
{
    partial class Form1
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
            System.Windows.Forms.Label descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.waterCheck = new System.Windows.Forms.CheckBox();
            this.loudCheck = new System.Windows.Forms.CheckBox();
            this.slowCheck = new System.Windows.Forms.CheckBox();
            this.thrilCheck = new System.Windows.Forms.CheckBox();
            this.scaryCheck = new System.Windows.Forms.CheckBox();
            this.kidsCheck = new System.Windows.Forms.CheckBox();
            this.entertainCheck = new System.Windows.Forms.CheckBox();
            this.dropCheck = new System.Windows.Forms.CheckBox();
            this.trainCheck = new System.Windows.Forms.CheckBox();
            this.boatCheck = new System.Windows.Forms.CheckBox();
            this.transportCheck = new System.Windows.Forms.CheckBox();
            this.exploreCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.database7DataSet = new coolerAttractions.Database7DataSet();
            this.attractionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attractionsTableAdapter = new coolerAttractions.Database7DataSetTableAdapters.AttractionsTableAdapter();
            this.tableAdapterManager = new coolerAttractions.Database7DataSetTableAdapters.TableAdapterManager();
            this.attractionsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.attractionsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.database7DataSet1 = new coolerAttractions.Database7DataSet1();
            this.attractionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.attractionsTableAdapter1 = new coolerAttractions.Database7DataSet1TableAdapters.AttractionsTableAdapter();
            this.tableAdapterManager1 = new coolerAttractions.Database7DataSet1TableAdapters.TableAdapterManager();
            this.attractionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attractionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attractionsBindingNavigator)).BeginInit();
            this.attractionsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database7DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attractionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attractionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(672, 358);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 16;
            descriptionLabel.Text = "Description:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::coolerAttractions.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // waterCheck
            // 
            this.waterCheck.AutoSize = true;
            this.waterCheck.Location = new System.Drawing.Point(60, 402);
            this.waterCheck.Name = "waterCheck";
            this.waterCheck.Size = new System.Drawing.Size(55, 17);
            this.waterCheck.TabIndex = 1;
            this.waterCheck.Text = "Water";
            this.waterCheck.UseVisualStyleBackColor = true;
            this.waterCheck.CheckedChanged += new System.EventHandler(this.waterCheck_CheckedChanged);
            // 
            // loudCheck
            // 
            this.loudCheck.AutoSize = true;
            this.loudCheck.Location = new System.Drawing.Point(201, 402);
            this.loudCheck.Name = "loudCheck";
            this.loudCheck.Size = new System.Drawing.Size(50, 17);
            this.loudCheck.TabIndex = 2;
            this.loudCheck.Text = "Loud";
            this.loudCheck.UseVisualStyleBackColor = true;
            // 
            // slowCheck
            // 
            this.slowCheck.AutoSize = true;
            this.slowCheck.Location = new System.Drawing.Point(322, 402);
            this.slowCheck.Name = "slowCheck";
            this.slowCheck.Size = new System.Drawing.Size(49, 17);
            this.slowCheck.TabIndex = 3;
            this.slowCheck.Text = "Slow";
            this.slowCheck.UseVisualStyleBackColor = true;
            // 
            // thrilCheck
            // 
            this.thrilCheck.AutoSize = true;
            this.thrilCheck.Location = new System.Drawing.Point(431, 402);
            this.thrilCheck.Name = "thrilCheck";
            this.thrilCheck.Size = new System.Drawing.Size(48, 17);
            this.thrilCheck.TabIndex = 4;
            this.thrilCheck.Text = "Thrill";
            this.thrilCheck.UseVisualStyleBackColor = true;
            // 
            // scaryCheck
            // 
            this.scaryCheck.AutoSize = true;
            this.scaryCheck.Location = new System.Drawing.Point(60, 457);
            this.scaryCheck.Name = "scaryCheck";
            this.scaryCheck.Size = new System.Drawing.Size(53, 17);
            this.scaryCheck.TabIndex = 5;
            this.scaryCheck.Text = "Scary";
            this.scaryCheck.UseVisualStyleBackColor = true;
            this.scaryCheck.CheckedChanged += new System.EventHandler(this.scaryCheck_CheckedChanged);
            // 
            // kidsCheck
            // 
            this.kidsCheck.AutoSize = true;
            this.kidsCheck.Location = new System.Drawing.Point(201, 457);
            this.kidsCheck.Name = "kidsCheck";
            this.kidsCheck.Size = new System.Drawing.Size(46, 17);
            this.kidsCheck.TabIndex = 6;
            this.kidsCheck.Text = "Kids";
            this.kidsCheck.UseVisualStyleBackColor = true;
            // 
            // entertainCheck
            // 
            this.entertainCheck.AutoSize = true;
            this.entertainCheck.Location = new System.Drawing.Point(320, 457);
            this.entertainCheck.Name = "entertainCheck";
            this.entertainCheck.Size = new System.Drawing.Size(91, 17);
            this.entertainCheck.TabIndex = 7;
            this.entertainCheck.Text = "Entertainment";
            this.entertainCheck.UseVisualStyleBackColor = true;
            // 
            // dropCheck
            // 
            this.dropCheck.AutoSize = true;
            this.dropCheck.Location = new System.Drawing.Point(431, 457);
            this.dropCheck.Name = "dropCheck";
            this.dropCheck.Size = new System.Drawing.Size(49, 17);
            this.dropCheck.TabIndex = 8;
            this.dropCheck.Text = "Drop";
            this.dropCheck.UseVisualStyleBackColor = true;
            // 
            // trainCheck
            // 
            this.trainCheck.AutoSize = true;
            this.trainCheck.Location = new System.Drawing.Point(60, 507);
            this.trainCheck.Name = "trainCheck";
            this.trainCheck.Size = new System.Drawing.Size(50, 17);
            this.trainCheck.TabIndex = 9;
            this.trainCheck.Text = "Train";
            this.trainCheck.UseVisualStyleBackColor = true;
            // 
            // boatCheck
            // 
            this.boatCheck.AutoSize = true;
            this.boatCheck.Location = new System.Drawing.Point(197, 507);
            this.boatCheck.Name = "boatCheck";
            this.boatCheck.Size = new System.Drawing.Size(48, 17);
            this.boatCheck.TabIndex = 10;
            this.boatCheck.Text = "Boat";
            this.boatCheck.UseVisualStyleBackColor = true;
            // 
            // transportCheck
            // 
            this.transportCheck.AutoSize = true;
            this.transportCheck.Location = new System.Drawing.Point(320, 507);
            this.transportCheck.Name = "transportCheck";
            this.transportCheck.Size = new System.Drawing.Size(94, 17);
            this.transportCheck.TabIndex = 11;
            this.transportCheck.Text = "Transportation";
            this.transportCheck.UseVisualStyleBackColor = true;
            // 
            // exploreCheck
            // 
            this.exploreCheck.AutoSize = true;
            this.exploreCheck.Location = new System.Drawing.Point(431, 507);
            this.exploreCheck.Name = "exploreCheck";
            this.exploreCheck.Size = new System.Drawing.Size(61, 17);
            this.exploreCheck.TabIndex = 12;
            this.exploreCheck.Text = "Explore";
            this.exploreCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(35, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 214);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categories";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // database7DataSet
            // 
            this.database7DataSet.DataSetName = "Database7DataSet";
            this.database7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attractionsBindingSource
            // 
            this.attractionsBindingSource.DataMember = "Attractions";
            this.attractionsBindingSource.DataSource = this.database7DataSet;
            // 
            // attractionsTableAdapter
            // 
            this.attractionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttractionsTableAdapter = this.attractionsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = coolerAttractions.Database7DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // attractionsBindingNavigator
            // 
            this.attractionsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.attractionsBindingNavigator.BindingSource = this.attractionsBindingSource;
            this.attractionsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.attractionsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.attractionsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.attractionsBindingNavigatorSaveItem});
            this.attractionsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.attractionsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.attractionsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.attractionsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.attractionsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.attractionsBindingNavigator.Name = "attractionsBindingNavigator";
            this.attractionsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.attractionsBindingNavigator.Size = new System.Drawing.Size(1250, 25);
            this.attractionsBindingNavigator.TabIndex = 14;
            this.attractionsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // attractionsBindingNavigatorSaveItem
            // 
            this.attractionsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.attractionsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("attractionsBindingNavigatorSaveItem.Image")));
            this.attractionsBindingNavigatorSaveItem.Name = "attractionsBindingNavigatorSaveItem";
            this.attractionsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.attractionsBindingNavigatorSaveItem.Text = "Save Data";
            this.attractionsBindingNavigatorSaveItem.Click += new System.EventHandler(this.attractionsBindingNavigatorSaveItem_Click);
            // 
            // database7DataSet1
            // 
            this.database7DataSet1.DataSetName = "Database7DataSet1";
            this.database7DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attractionsBindingSource1
            // 
            this.attractionsBindingSource1.DataMember = "Attractions";
            this.attractionsBindingSource1.DataSource = this.database7DataSet1;
            // 
            // attractionsTableAdapter1
            // 
            this.attractionsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AttractionsTableAdapter = this.attractionsTableAdapter1;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = coolerAttractions.Database7DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // attractionsDataGridView
            // 
            this.attractionsDataGridView.AllowUserToAddRows = false;
            this.attractionsDataGridView.AllowUserToDeleteRows = false;
            this.attractionsDataGridView.AllowUserToResizeColumns = false;
            this.attractionsDataGridView.AllowUserToResizeRows = false;
            this.attractionsDataGridView.AutoGenerateColumns = false;
            this.attractionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attractionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.attractionsDataGridView.DataSource = this.attractionsBindingSource1;
            this.attractionsDataGridView.Location = new System.Drawing.Point(555, 12);
            this.attractionsDataGridView.Name = "attractionsDataGridView";
            this.attractionsDataGridView.ReadOnly = true;
            this.attractionsDataGridView.Size = new System.Drawing.Size(643, 220);
            this.attractionsDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Location";
            this.dataGridViewTextBoxColumn3.HeaderText = "Location";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Category 1";
            this.dataGridViewTextBoxColumn4.HeaderText = "Category 1";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Category 2";
            this.dataGridViewTextBoxColumn5.HeaderText = "Category 2";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Water";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Water";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Height";
            this.dataGridViewTextBoxColumn6.HeaderText = "Height";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn7.HeaderText = "Description";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attractionsBindingSource1, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(741, 355);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(356, 229);
            this.descriptionTextBox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 608);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.attractionsDataGridView);
            this.Controls.Add(this.attractionsBindingNavigator);
            this.Controls.Add(this.exploreCheck);
            this.Controls.Add(this.transportCheck);
            this.Controls.Add(this.boatCheck);
            this.Controls.Add(this.trainCheck);
            this.Controls.Add(this.dropCheck);
            this.Controls.Add(this.entertainCheck);
            this.Controls.Add(this.kidsCheck);
            this.Controls.Add(this.scaryCheck);
            this.Controls.Add(this.thrilCheck);
            this.Controls.Add(this.slowCheck);
            this.Controls.Add(this.loudCheck);
            this.Controls.Add(this.waterCheck);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "coolerForm1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attractionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attractionsBindingNavigator)).EndInit();
            this.attractionsBindingNavigator.ResumeLayout(false);
            this.attractionsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database7DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attractionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attractionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox waterCheck;
        private System.Windows.Forms.CheckBox loudCheck;
        private System.Windows.Forms.CheckBox slowCheck;
        private System.Windows.Forms.CheckBox thrilCheck;
        private System.Windows.Forms.CheckBox scaryCheck;
        private System.Windows.Forms.CheckBox kidsCheck;
        private System.Windows.Forms.CheckBox entertainCheck;
        private System.Windows.Forms.CheckBox dropCheck;
        private System.Windows.Forms.CheckBox trainCheck;
        private System.Windows.Forms.CheckBox boatCheck;
        private System.Windows.Forms.CheckBox transportCheck;
        private System.Windows.Forms.CheckBox exploreCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private Database7DataSet database7DataSet;
        private System.Windows.Forms.BindingSource attractionsBindingSource;
        private Database7DataSetTableAdapters.AttractionsTableAdapter attractionsTableAdapter;
        private Database7DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator attractionsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton attractionsBindingNavigatorSaveItem;
        private Database7DataSet1 database7DataSet1;
        private System.Windows.Forms.BindingSource attractionsBindingSource1;
        private Database7DataSet1TableAdapters.AttractionsTableAdapter attractionsTableAdapter1;
        private Database7DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView attractionsDataGridView;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}


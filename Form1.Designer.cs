namespace Choreganizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.choreganizer_ARDataSet = new Choreganizer.choreganizer_ARDataSet();
            this.choresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.choresTableAdapter = new Choreganizer.choreganizer_ARDataSetTableAdapters.choresTableAdapter();
            this.tableAdapterManager = new Choreganizer.choreganizer_ARDataSetTableAdapters.TableAdapterManager();
            this.choreganizerARDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.choresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.choreganizer_ARDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choreganizerARDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choresBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-6, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Choreganizer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // choreganizer_ARDataSet
            // 
            this.choreganizer_ARDataSet.DataSetName = "choreganizer_ARDataSet";
            this.choreganizer_ARDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // choresBindingSource
            // 
            this.choresBindingSource.DataMember = "chores";
            this.choresBindingSource.DataSource = this.choreganizer_ARDataSet;
            // 
            // choresTableAdapter
            // 
            this.choresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.choresTableAdapter = this.choresTableAdapter;
            this.tableAdapterManager.groupsTableAdapter = null;
            this.tableAdapterManager.historyTableAdapter = null;
            this.tableAdapterManager.locationsTableAdapter = null;
            this.tableAdapterManager.requirementsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Choreganizer.choreganizer_ARDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // choreganizerARDataSetBindingSource
            // 
            this.choreganizerARDataSetBindingSource.DataSource = this.choreganizer_ARDataSet;
            this.choreganizerARDataSetBindingSource.Position = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.choresBindingSource1;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(372, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "id";
            // 
            // choresBindingSource1
            // 
            this.choresBindingSource1.DataMember = "chores";
            this.choresBindingSource1.DataSource = this.choreganizer_ARDataSet;
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.choresBindingSource1, "notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(372, 182);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(121, 72);
            this.notesTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "CHORE:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(722, 395);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Chorganizer 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.choreganizer_ARDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choreganizerARDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choresBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private choreganizer_ARDataSet choreganizer_ARDataSet;
        private System.Windows.Forms.BindingSource choresBindingSource;
        private choreganizer_ARDataSetTableAdapters.choresTableAdapter choresTableAdapter;
        private choreganizer_ARDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource choreganizerARDataSetBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource choresBindingSource1;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Label label2;
    }
}


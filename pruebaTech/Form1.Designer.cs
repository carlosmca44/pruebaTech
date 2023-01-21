namespace pruebaTech
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelEdad = new System.Windows.Forms.Label();
            this.ageSelect = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSexo = new System.Windows.Forms.Label();
            this.radioButton1Sexo = new System.Windows.Forms.RadioButton();
            this.radioButton2Sexo = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelContinente = new System.Windows.Forms.Label();
            this.comboBoxContinent = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelCI = new System.Windows.Forms.Label();
            this.textBoxCI = new System.Windows.Forms.TextBox();
            this.dateTimeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonVaciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageSelect)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 315);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(796, 132);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.labelNombre);
            this.flowLayoutPanel2.Controls.Add(this.textBoxName);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(22, 32);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(185, 54);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(2, 0);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(160, 20);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre y apellidos";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(2, 22);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(158, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.labelEdad);
            this.flowLayoutPanel3.Controls.Add(this.ageSelect);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(22, 158);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(186, 29);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdad.Location = new System.Drawing.Point(2, 0);
            this.labelEdad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(51, 20);
            this.labelEdad.TabIndex = 0;
            this.labelEdad.Text = "Edad";
            // 
            // ageSelect
            // 
            this.ageSelect.Location = new System.Drawing.Point(57, 2);
            this.ageSelect.Margin = new System.Windows.Forms.Padding(2);
            this.ageSelect.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.ageSelect.Name = "ageSelect";
            this.ageSelect.Size = new System.Drawing.Size(90, 20);
            this.ageSelect.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.labelSexo);
            this.flowLayoutPanel4.Controls.Add(this.radioButton1Sexo);
            this.flowLayoutPanel4.Controls.Add(this.radioButton2Sexo);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(22, 215);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(94, 76);
            this.flowLayoutPanel4.TabIndex = 4;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexo.Location = new System.Drawing.Point(2, 0);
            this.labelSexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(49, 20);
            this.labelSexo.TabIndex = 0;
            this.labelSexo.Text = "Sexo";
            // 
            // radioButton1Sexo
            // 
            this.radioButton1Sexo.AutoSize = true;
            this.radioButton1Sexo.Location = new System.Drawing.Point(2, 22);
            this.radioButton1Sexo.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1Sexo.Name = "radioButton1Sexo";
            this.radioButton1Sexo.Size = new System.Drawing.Size(73, 17);
            this.radioButton1Sexo.TabIndex = 1;
            this.radioButton1Sexo.TabStop = true;
            this.radioButton1Sexo.Text = "Masculino";
            this.radioButton1Sexo.UseVisualStyleBackColor = true;
            // 
            // radioButton2Sexo
            // 
            this.radioButton2Sexo.AutoSize = true;
            this.radioButton2Sexo.Location = new System.Drawing.Point(2, 43);
            this.radioButton2Sexo.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2Sexo.Name = "radioButton2Sexo";
            this.radioButton2Sexo.Size = new System.Drawing.Size(71, 17);
            this.radioButton2Sexo.TabIndex = 2;
            this.radioButton2Sexo.TabStop = true;
            this.radioButton2Sexo.Text = "Femenino";
            this.radioButton2Sexo.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.labelContinente);
            this.flowLayoutPanel5.Controls.Add(this.comboBoxContinent);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(297, 25);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(127, 61);
            this.flowLayoutPanel5.TabIndex = 5;
            // 
            // labelContinente
            // 
            this.labelContinente.AutoSize = true;
            this.labelContinente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContinente.Location = new System.Drawing.Point(2, 0);
            this.labelContinente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContinente.Name = "labelContinente";
            this.labelContinente.Size = new System.Drawing.Size(97, 20);
            this.labelContinente.TabIndex = 0;
            this.labelContinente.Text = "Continente";
            // 
            // comboBoxContinent
            // 
            this.comboBoxContinent.FormattingEnabled = true;
            this.comboBoxContinent.Location = new System.Drawing.Point(2, 22);
            this.comboBoxContinent.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxContinent.Name = "comboBoxContinent";
            this.comboBoxContinent.Size = new System.Drawing.Size(123, 21);
            this.comboBoxContinent.TabIndex = 1;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label2);
            this.flowLayoutPanel6.Controls.Add(this.textBoxDescription);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(297, 106);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(150, 107);
            this.flowLayoutPanel6.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripcion";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(2, 22);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(138, 76);
            this.textBoxDescription.TabIndex = 1;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.buttonAdd);
            this.flowLayoutPanel7.Controls.Add(this.buttonEdit);
            this.flowLayoutPanel7.Controls.Add(this.buttonDelete);
            this.flowLayoutPanel7.Controls.Add(this.button1);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(478, 464);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(298, 34);
            this.flowLayoutPanel7.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(2, 2);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(92, 24);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "ADICIONAR";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(98, 2);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(92, 24);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "EDITAR";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(194, 2);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(92, 24);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "ELIMINAR";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelCI);
            this.flowLayoutPanel1.Controls.Add(this.textBoxCI);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 106);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(150, 29);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // labelCI
            // 
            this.labelCI.AutoSize = true;
            this.labelCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCI.Location = new System.Drawing.Point(2, 0);
            this.labelCI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCI.Name = "labelCI";
            this.labelCI.Size = new System.Drawing.Size(27, 20);
            this.labelCI.TabIndex = 0;
            this.labelCI.Text = "CI";
            // 
            // textBoxCI
            // 
            this.textBoxCI.Location = new System.Drawing.Point(33, 2);
            this.textBoxCI.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCI.MaxLength = 11;
            this.textBoxCI.Name = "textBoxCI";
            this.textBoxCI.Size = new System.Drawing.Size(112, 20);
            this.textBoxCI.TabIndex = 1;
            // 
            // dateTimeNacimiento
            // 
            this.dateTimeNacimiento.Location = new System.Drawing.Point(279, 258);
            this.dateTimeNacimiento.Name = "dateTimeNacimiento";
            this.dateTimeNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimeNacimiento.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 234);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha de Nacimiento";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonVaciar
            // 
            this.buttonVaciar.Location = new System.Drawing.Point(687, 258);
            this.buttonVaciar.Name = "buttonVaciar";
            this.buttonVaciar.Size = new System.Drawing.Size(89, 33);
            this.buttonVaciar.TabIndex = 11;
            this.buttonVaciar.Text = "Vaciar Campos";
            this.buttonVaciar.UseVisualStyleBackColor = true;
            this.buttonVaciar.Click += new System.EventHandler(this.ButtonVaciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 509);
            this.Controls.Add(this.buttonVaciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeNacimiento);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel7);
            this.Controls.Add(this.flowLayoutPanel6);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageSelect)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.NumericUpDown ageSelect;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.RadioButton radioButton1Sexo;
        private System.Windows.Forms.RadioButton radioButton2Sexo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label labelContinente;
        private System.Windows.Forms.ComboBox comboBoxContinent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelCI;
        private System.Windows.Forms.TextBox textBoxCI;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DateTimePicker dateTimeNacimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonVaciar;
    }
}


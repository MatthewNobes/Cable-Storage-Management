namespace Cable_Storage_Management
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grbOptions = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grbCurrentCable = new System.Windows.Forms.GroupBox();
            this.lblSerial = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblConNum = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.chbTransformer = new System.Windows.Forms.CheckBox();
            this.chbUsed = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.grbOptions.SuspendLayout();
            this.grbCurrentCable.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1396, 895);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1388, 862);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View All Cables";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1366, 840);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1388, 862);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Database Source Location:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(576, 26);
            this.textBox1.TabIndex = 0;
            // 
            // grbOptions
            // 
            this.grbOptions.Controls.Add(this.btnRemove);
            this.grbOptions.Controls.Add(this.btnEdit);
            this.grbOptions.Controls.Add(this.btnAdd);
            this.grbOptions.Location = new System.Drawing.Point(1415, 13);
            this.grbOptions.Name = "grbOptions";
            this.grbOptions.Size = new System.Drawing.Size(700, 68);
            this.grbOptions.TabIndex = 1;
            this.grbOptions.TabStop = false;
            this.grbOptions.Text = "Options";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(352, 25);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(167, 32);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Delete Cable";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(179, 25);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(167, 32);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit Cable";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add New Cable";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(798, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Edit Storage Location";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // grbCurrentCable
            // 
            this.grbCurrentCable.Controls.Add(this.chbUsed);
            this.grbCurrentCable.Controls.Add(this.chbTransformer);
            this.grbCurrentCable.Controls.Add(this.textBox11);
            this.grbCurrentCable.Controls.Add(this.textBox12);
            this.grbCurrentCable.Controls.Add(this.label6);
            this.grbCurrentCable.Controls.Add(this.lblBrand);
            this.grbCurrentCable.Controls.Add(this.textBox7);
            this.grbCurrentCable.Controls.Add(this.textBox8);
            this.grbCurrentCable.Controls.Add(this.textBox9);
            this.grbCurrentCable.Controls.Add(this.label3);
            this.grbCurrentCable.Controls.Add(this.label4);
            this.grbCurrentCable.Controls.Add(this.label5);
            this.grbCurrentCable.Controls.Add(this.label2);
            this.grbCurrentCable.Controls.Add(this.textBox6);
            this.grbCurrentCable.Controls.Add(this.textBox5);
            this.grbCurrentCable.Controls.Add(this.textBox4);
            this.grbCurrentCable.Controls.Add(this.textBox3);
            this.grbCurrentCable.Controls.Add(this.textBox2);
            this.grbCurrentCable.Controls.Add(this.lblType);
            this.grbCurrentCable.Controls.Add(this.lblConNum);
            this.grbCurrentCable.Controls.Add(this.lblLength);
            this.grbCurrentCable.Controls.Add(this.lblSerial);
            this.grbCurrentCable.Location = new System.Drawing.Point(1415, 87);
            this.grbCurrentCable.Name = "grbCurrentCable";
            this.grbCurrentCable.Size = new System.Drawing.Size(700, 821);
            this.grbCurrentCable.TabIndex = 2;
            this.grbCurrentCable.TabStop = false;
            this.grbCurrentCable.Text = "Select a cable";
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Location = new System.Drawing.Point(6, 29);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(113, 20);
            this.lblSerial.TabIndex = 0;
            this.lblSerial.Text = "Serial Number:";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(6, 229);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(63, 20);
            this.lblLength.TabIndex = 1;
            this.lblLength.Text = "Length:";
            // 
            // lblConNum
            // 
            this.lblConNum.AutoSize = true;
            this.lblConNum.Location = new System.Drawing.Point(6, 129);
            this.lblConNum.Name = "lblConNum";
            this.lblConNum.Size = new System.Drawing.Size(155, 20);
            this.lblConNum.TabIndex = 2;
            this.lblConNum.Text = "Connention Number:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 179);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(47, 20);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(519, 26);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(164, 176);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(519, 26);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(164, 126);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(519, 26);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(164, 226);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(519, 26);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(164, 76);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(519, 26);
            this.textBox6.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Role:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(164, 376);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(519, 26);
            this.textBox7.TabIndex = 15;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(164, 276);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(519, 26);
            this.textBox8.TabIndex = 14;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(164, 326);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(519, 26);
            this.textBox9.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Connector 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Connector 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Connector 3:";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(164, 426);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(519, 26);
            this.textBox11.TabIndex = 20;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(164, 476);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(519, 26);
            this.textBox12.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Location:";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(6, 429);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(56, 20);
            this.lblBrand.TabIndex = 17;
            this.lblBrand.Text = "Brand:";
            // 
            // chbTransformer
            // 
            this.chbTransformer.AutoSize = true;
            this.chbTransformer.Location = new System.Drawing.Point(10, 526);
            this.chbTransformer.Name = "chbTransformer";
            this.chbTransformer.Size = new System.Drawing.Size(169, 24);
            this.chbTransformer.TabIndex = 21;
            this.chbTransformer.Text = "Has A Transformer";
            this.chbTransformer.UseVisualStyleBackColor = true;
            // 
            // chbUsed
            // 
            this.chbUsed.AutoSize = true;
            this.chbUsed.Location = new System.Drawing.Point(216, 526);
            this.chbUsed.Name = "chbUsed";
            this.chbUsed.Size = new System.Drawing.Size(118, 24);
            this.chbUsed.TabIndex = 22;
            this.chbUsed.Text = "Being Used";
            this.chbUsed.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2130, 925);
            this.Controls.Add(this.grbCurrentCable);
            this.Controls.Add(this.grbOptions);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Cable Storage Management";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grbOptions.ResumeLayout(false);
            this.grbCurrentCable.ResumeLayout(false);
            this.grbCurrentCable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grbOptions;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grbCurrentCable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblConNum;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.CheckBox chbUsed;
        private System.Windows.Forms.CheckBox chbTransformer;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


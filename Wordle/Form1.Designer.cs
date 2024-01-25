namespace Wordle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvWords = new System.Windows.Forms.DataGridView();
            this.clm1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtxtInput = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWords)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWords
            // 
            this.dgvWords.AllowUserToAddRows = false;
            this.dgvWords.AllowUserToDeleteRows = false;
            this.dgvWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWords.ColumnHeadersVisible = false;
            this.dgvWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm1,
            this.clm2,
            this.clm3,
            this.clm4,
            this.clm5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWords.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvWords.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvWords.Location = new System.Drawing.Point(13, 13);
            this.dgvWords.MultiSelect = false;
            this.dgvWords.Name = "dgvWords";
            this.dgvWords.ReadOnly = true;
            this.dgvWords.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvWords.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvWords.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvWords.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Window;
            this.dgvWords.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvWords.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvWords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvWords.Size = new System.Drawing.Size(253, 135);
            this.dgvWords.TabIndex = 1;
            this.dgvWords.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // clm1
            // 
            this.clm1.HeaderText = "";
            this.clm1.Name = "clm1";
            this.clm1.ReadOnly = true;
            this.clm1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clm1.Width = 50;
            // 
            // clm2
            // 
            this.clm2.HeaderText = "";
            this.clm2.Name = "clm2";
            this.clm2.ReadOnly = true;
            this.clm2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clm2.Width = 50;
            // 
            // clm3
            // 
            this.clm3.HeaderText = "";
            this.clm3.Name = "clm3";
            this.clm3.ReadOnly = true;
            this.clm3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clm3.Width = 50;
            // 
            // clm4
            // 
            this.clm4.HeaderText = "";
            this.clm4.Name = "clm4";
            this.clm4.ReadOnly = true;
            this.clm4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clm4.Width = 50;
            // 
            // clm5
            // 
            this.clm5.HeaderText = "";
            this.clm5.Name = "clm5";
            this.clm5.ReadOnly = true;
            this.clm5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clm5.Width = 50;
            // 
            // mtxtInput
            // 
            this.mtxtInput.Location = new System.Drawing.Point(13, 154);
            this.mtxtInput.Mask = "AAAAA";
            this.mtxtInput.Name = "mtxtInput";
            this.mtxtInput.Size = new System.Drawing.Size(84, 20);
            this.mtxtInput.TabIndex = 0;
            this.mtxtInput.ValidatingType = typeof(int);
            this.mtxtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox1_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 182);
            this.Controls.Add(this.mtxtInput);
            this.Controls.Add(this.dgvWords);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(288, 221);
            this.MinimumSize = new System.Drawing.Size(288, 221);
            this.Name = "Form1";
            this.Text = "Wordle";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm5;
        private System.Windows.Forms.MaskedTextBox mtxtInput;
    }
}


namespace NORTHWND.UI
{
    partial class frmMostrar
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
            this.btnsig = new System.Windows.Forms.Button();
            this.btnst = new System.Windows.Forms.Button();
            this.btnat = new System.Windows.Forms.Button();
            this.btnant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(853, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnsig
            // 
            this.btnsig.Location = new System.Drawing.Point(534, 376);
            this.btnsig.Name = "btnsig";
            this.btnsig.Size = new System.Drawing.Size(75, 23);
            this.btnsig.TabIndex = 1;
            this.btnsig.Text = ">";
            this.btnsig.UseVisualStyleBackColor = true;
            this.btnsig.Click += new System.EventHandler(this.btnsig_Click);
            // 
            // btnst
            // 
            this.btnst.Location = new System.Drawing.Point(686, 376);
            this.btnst.Name = "btnst";
            this.btnst.Size = new System.Drawing.Size(75, 23);
            this.btnst.TabIndex = 2;
            this.btnst.Text = ">>";
            this.btnst.UseVisualStyleBackColor = true;
            // 
            // btnat
            // 
            this.btnat.Location = new System.Drawing.Point(156, 376);
            this.btnat.Name = "btnat";
            this.btnat.Size = new System.Drawing.Size(75, 23);
            this.btnat.TabIndex = 3;
            this.btnat.Text = "<<";
            this.btnat.UseVisualStyleBackColor = true;
            // 
            // btnant
            // 
            this.btnant.Location = new System.Drawing.Point(340, 376);
            this.btnant.Name = "btnant";
            this.btnant.Size = new System.Drawing.Size(75, 23);
            this.btnant.TabIndex = 4;
            this.btnant.Text = "<";
            this.btnant.UseVisualStyleBackColor = true;
            // 
            // frmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 428);
            this.Controls.Add(this.btnant);
            this.Controls.Add(this.btnat);
            this.Controls.Add(this.btnst);
            this.Controls.Add(this.btnsig);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMostrar";
            this.Text = "frmMostrar";
            this.Load += new System.EventHandler(this.frmMostrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsig;
        private System.Windows.Forms.Button btnst;
        private System.Windows.Forms.Button btnat;
        private System.Windows.Forms.Button btnant;
    }
}
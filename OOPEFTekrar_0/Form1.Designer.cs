
namespace OOPEFTekrar_0
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
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.btnKategoriler = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCatName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(3, 22);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(1158, 408);
            this.dgvResult.TabIndex = 0;
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.Location = new System.Drawing.Point(12, 467);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(144, 35);
            this.btnKategoriler.TabIndex = 1;
            this.btnKategoriler.Text = "Kategori Listele";
            this.btnKategoriler.UseVisualStyleBackColor = true;
            this.btnKategoriler.Click += new System.EventHandler(this.btnKategoriler_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(213, 467);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(108, 35);
            this.btnWhere.TabIndex = 2;
            this.btnWhere.Text = "Where";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(370, 530);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(100, 20);
            this.txtCatName.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 626);
            this.Controls.Add(this.txtCatName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnKategoriler);
            this.Controls.Add(this.dgvResult);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Button btnKategoriler;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCatName;
    }
}


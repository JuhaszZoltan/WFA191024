namespace WFA191024
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
            this.lvAdatok = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCeg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbNevek = new System.Windows.Forms.ComboBox();
            this.tbKereses = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCeg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRogzit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvAdatok
            // 
            this.lvAdatok.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chNev,
            this.chCeg});
            this.lvAdatok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvAdatok.Location = new System.Drawing.Point(12, 147);
            this.lvAdatok.Name = "lvAdatok";
            this.lvAdatok.Size = new System.Drawing.Size(760, 286);
            this.lvAdatok.TabIndex = 0;
            this.lvAdatok.UseCompatibleStateImageBehavior = false;
            this.lvAdatok.View = System.Windows.Forms.View.Details;
            // 
            // chId
            // 
            this.chId.Text = "Id";
            this.chId.Width = 80;
            // 
            // chNev
            // 
            this.chNev.Text = "Név";
            this.chNev.Width = 300;
            // 
            // chCeg
            // 
            this.chCeg.Text = "Cég";
            this.chCeg.Width = 300;
            // 
            // cbNevek
            // 
            this.cbNevek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbNevek.FormattingEnabled = true;
            this.cbNevek.Location = new System.Drawing.Point(291, 69);
            this.cbNevek.Name = "cbNevek";
            this.cbNevek.Size = new System.Drawing.Size(273, 33);
            this.cbNevek.TabIndex = 1;
            // 
            // tbKereses
            // 
            this.tbKereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbKereses.Location = new System.Drawing.Point(291, 22);
            this.tbKereses.Name = "tbKereses";
            this.tbKereses.Size = new System.Drawing.Size(273, 30);
            this.tbKereses.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Keresés név alapján:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(27, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Szűrés cég alapján:";
            // 
            // tbCeg
            // 
            this.tbCeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCeg.Location = new System.Drawing.Point(323, 458);
            this.tbCeg.Name = "tbCeg";
            this.tbCeg.Size = new System.Drawing.Size(180, 30);
            this.tbCeg.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(17, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Név:";
            // 
            // btnRogzit
            // 
            this.btnRogzit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRogzit.Location = new System.Drawing.Point(523, 453);
            this.btnRogzit.Name = "btnRogzit";
            this.btnRogzit.Size = new System.Drawing.Size(236, 40);
            this.btnRogzit.TabIndex = 5;
            this.btnRogzit.Text = "Rögzít";
            this.btnRogzit.UseVisualStyleBackColor = true;
            this.btnRogzit.Click += new System.EventHandler(this.btnRogzit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(262, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cég:";
            // 
            // tnNev
            // 
            this.tbNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNev.Location = new System.Drawing.Point(76, 458);
            this.tbNev.Name = "tnNev";
            this.tbNev.Size = new System.Drawing.Size(180, 30);
            this.tbNev.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.btnRogzit);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.tbCeg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKereses);
            this.Controls.Add(this.cbNevek);
            this.Controls.Add(this.lvAdatok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvAdatok;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chNev;
        private System.Windows.Forms.ColumnHeader chCeg;
        private System.Windows.Forms.ComboBox cbNevek;
        private System.Windows.Forms.TextBox tbKereses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCeg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRogzit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNev;
    }
}


namespace Vector
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtBoxVector2 = new System.Windows.Forms.TextBox();
            this.txtBoxVector1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVectorSum = new System.Windows.Forms.Button();
            this.BtnVectorInter = new System.Windows.Forms.Button();
            this.txtVectorMinus = new System.Windows.Forms.Button();
            this.BtnVectorOut = new System.Windows.Forms.Button();
            this.BtnGeogebra = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxVector2
            // 
            this.txtBoxVector2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxVector2.Location = new System.Drawing.Point(326, 32);
            this.txtBoxVector2.Multiline = true;
            this.txtBoxVector2.Name = "txtBoxVector2";
            this.txtBoxVector2.Size = new System.Drawing.Size(137, 30);
            this.txtBoxVector2.TabIndex = 0;
            this.txtBoxVector2.Text = "(x,y,z)";
            this.txtBoxVector2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxVector1
            // 
            this.txtBoxVector1.Location = new System.Drawing.Point(90, 32);
            this.txtBoxVector1.Multiline = true;
            this.txtBoxVector1.Name = "txtBoxVector1";
            this.txtBoxVector1.Size = new System.Drawing.Size(135, 30);
            this.txtBoxVector1.TabIndex = 1;
            this.txtBoxVector1.Text = "(x,y,z)";
            this.txtBoxVector1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxVector1);
            this.groupBox1.Controls.Add(this.txtBoxVector2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vectors";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "vector 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "vector 2 :";
            // 
            // btnVectorSum
            // 
            this.btnVectorSum.Font = new System.Drawing.Font("IRANSans", 10F);
            this.btnVectorSum.Location = new System.Drawing.Point(14, 88);
            this.btnVectorSum.Name = "btnVectorSum";
            this.btnVectorSum.Size = new System.Drawing.Size(75, 31);
            this.btnVectorSum.TabIndex = 3;
            this.btnVectorSum.Text = "Add";
            this.btnVectorSum.UseVisualStyleBackColor = true;
            this.btnVectorSum.Click += new System.EventHandler(this.btnVectorSum_Click);
            // 
            // BtnVectorInter
            // 
            this.BtnVectorInter.Font = new System.Drawing.Font("IRANSans", 10F);
            this.BtnVectorInter.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnVectorInter.Location = new System.Drawing.Point(176, 88);
            this.BtnVectorInter.Name = "BtnVectorInter";
            this.BtnVectorInter.Size = new System.Drawing.Size(143, 31);
            this.BtnVectorInter.TabIndex = 5;
            this.BtnVectorInter.Text = "Multiple (internal)";
            this.BtnVectorInter.UseVisualStyleBackColor = true;
            this.BtnVectorInter.Click += new System.EventHandler(this.BtnVectorInter_Click);
            // 
            // txtVectorMinus
            // 
            this.txtVectorMinus.Font = new System.Drawing.Font("IRANSans", 10F);
            this.txtVectorMinus.Location = new System.Drawing.Point(95, 88);
            this.txtVectorMinus.Name = "txtVectorMinus";
            this.txtVectorMinus.Size = new System.Drawing.Size(75, 31);
            this.txtVectorMinus.TabIndex = 6;
            this.txtVectorMinus.Text = "Minus";
            this.txtVectorMinus.UseVisualStyleBackColor = true;
            this.txtVectorMinus.Click += new System.EventHandler(this.txtVectorMinus_Click);
            // 
            // BtnVectorOut
            // 
            this.BtnVectorOut.Font = new System.Drawing.Font("IRANSans", 10F);
            this.BtnVectorOut.Location = new System.Drawing.Point(325, 88);
            this.BtnVectorOut.Name = "BtnVectorOut";
            this.BtnVectorOut.Size = new System.Drawing.Size(143, 31);
            this.BtnVectorOut.TabIndex = 7;
            this.BtnVectorOut.Text = "Multiple (outernal)";
            this.BtnVectorOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnVectorOut.UseVisualStyleBackColor = true;
            this.BtnVectorOut.Click += new System.EventHandler(this.BtnVectorOut_Click);
            // 
            // BtnGeogebra
            // 
            this.BtnGeogebra.Location = new System.Drawing.Point(14, 125);
            this.BtnGeogebra.Name = "BtnGeogebra";
            this.BtnGeogebra.Size = new System.Drawing.Size(454, 34);
            this.BtnGeogebra.TabIndex = 8;
            this.BtnGeogebra.Text = "Geogebra";
            this.BtnGeogebra.UseVisualStyleBackColor = true;
            this.BtnGeogebra.Click += new System.EventHandler(this.BtnGeogebra_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 176);
            this.Controls.Add(this.BtnGeogebra);
            this.Controls.Add(this.BtnVectorOut);
            this.Controls.Add(this.txtVectorMinus);
            this.Controls.Add(this.BtnVectorInter);
            this.Controls.Add(this.btnVectorSum);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vectorzy";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVectorSum;
        private System.Windows.Forms.Button BtnVectorInter;
        private System.Windows.Forms.Button txtVectorMinus;
        private System.Windows.Forms.Button BtnVectorOut;
        private System.Windows.Forms.Button BtnGeogebra;
        public System.Windows.Forms.TextBox txtBoxVector2;
        public System.Windows.Forms.TextBox txtBoxVector1;
    }
}


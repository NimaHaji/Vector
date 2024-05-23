namespace Vector
{
    partial class frmOptions
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMultipleOTOption = new System.Windows.Forms.Button();
            this.btnMultipleINOption = new System.Windows.Forms.Button();
            this.btnMinusOption = new System.Windows.Forms.Button();
            this.btnSumOption = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMultipleOTOption);
            this.groupBox1.Controls.Add(this.btnMultipleINOption);
            this.groupBox1.Controls.Add(this.btnMinusOption);
            this.groupBox1.Controls.Add(this.btnSumOption);
            this.groupBox1.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose the operation : ";
            // 
            // btnMultipleOTOption
            // 
            this.btnMultipleOTOption.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultipleOTOption.Location = new System.Drawing.Point(290, 32);
            this.btnMultipleOTOption.Name = "btnMultipleOTOption";
            this.btnMultipleOTOption.Size = new System.Drawing.Size(127, 26);
            this.btnMultipleOTOption.TabIndex = 3;
            this.btnMultipleOTOption.Text = "Multiple(outernal)";
            this.btnMultipleOTOption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMultipleOTOption.UseVisualStyleBackColor = true;
            // 
            // btnMultipleINOption
            // 
            this.btnMultipleINOption.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultipleINOption.Location = new System.Drawing.Point(168, 32);
            this.btnMultipleINOption.Name = "btnMultipleINOption";
            this.btnMultipleINOption.Size = new System.Drawing.Size(116, 26);
            this.btnMultipleINOption.TabIndex = 2;
            this.btnMultipleINOption.Text = "Multiple(internal)";
            this.btnMultipleINOption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMultipleINOption.UseVisualStyleBackColor = true;
            // 
            // btnMinusOption
            // 
            this.btnMinusOption.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusOption.Location = new System.Drawing.Point(87, 32);
            this.btnMinusOption.Name = "btnMinusOption";
            this.btnMinusOption.Size = new System.Drawing.Size(75, 26);
            this.btnMinusOption.TabIndex = 1;
            this.btnMinusOption.Text = "Minus";
            this.btnMinusOption.UseVisualStyleBackColor = true;
            this.btnMinusOption.Click += new System.EventHandler(this.btnMinusOption_Click);
            // 
            // btnSumOption
            // 
            this.btnSumOption.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumOption.Location = new System.Drawing.Point(6, 32);
            this.btnSumOption.Name = "btnSumOption";
            this.btnSumOption.Size = new System.Drawing.Size(75, 26);
            this.btnSumOption.TabIndex = 0;
            this.btnSumOption.Text = "Sum";
            this.btnSumOption.UseVisualStyleBackColor = true;
            this.btnSumOption.Click += new System.EventHandler(this.btnSumOption_Click);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(448, 97);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOptions";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMultipleOTOption;
        private System.Windows.Forms.Button btnMultipleINOption;
        private System.Windows.Forms.Button btnMinusOption;
        private System.Windows.Forms.Button btnSumOption;
    }
}
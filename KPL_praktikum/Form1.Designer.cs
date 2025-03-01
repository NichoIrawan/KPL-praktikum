namespace KPL_praktikum
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
            this.submit_btn = new System.Windows.Forms.Button();
            this.name_field = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(546, 143);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(100, 30);
            this.submit_btn.TabIndex = 0;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // name_field
            // 
            this.name_field.Location = new System.Drawing.Point(204, 143);
            this.name_field.Name = "name_field";
            this.name_field.Size = new System.Drawing.Size(310, 26);
            this.name_field.TabIndex = 1;
            this.name_field.TextChanged += new System.EventHandler(this.name_field_TextChanged);
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Output.Location = new System.Drawing.Point(204, 190);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(443, 50);
            this.Output.TabIndex = 2;
            this.Output.Text = "OUTPUT";
            this.Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Output.UseMnemonic = false;
            this.Output.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.name_field);
            this.Controls.Add(this.submit_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.TextBox name_field;
        private System.Windows.Forms.Label Output;
    }
}


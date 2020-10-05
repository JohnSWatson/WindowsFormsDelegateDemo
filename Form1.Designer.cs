namespace WindowsFormsDelegateDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonDo = new System.Windows.Forms.Button();
            this.textBoxDid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonDo
            // 
            this.buttonDo.Location = new System.Drawing.Point(28, 49);
            this.buttonDo.Name = "buttonDo";
            this.buttonDo.Size = new System.Drawing.Size(75, 23);
            this.buttonDo.TabIndex = 0;
            this.buttonDo.Text = "Do";
            this.buttonDo.UseVisualStyleBackColor = true;
            this.buttonDo.Click += new System.EventHandler(this.buttonDo_Click);
            // 
            // textBoxDid
            // 
            this.textBoxDid.Location = new System.Drawing.Point(123, 49);
            this.textBoxDid.Name = "textBoxDid";
            this.textBoxDid.Size = new System.Drawing.Size(480, 22);
            this.textBoxDid.TabIndex = 1;
            this.textBoxDid.Text = "Do something (Press Do button).";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 136);
            this.Controls.Add(this.textBoxDid);
            this.Controls.Add(this.buttonDo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Demonstration Reporting progress to form using Delegates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDo;
        private System.Windows.Forms.TextBox textBoxDid;
    }
}


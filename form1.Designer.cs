namespace WinApps1
{
    partial class form1
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
            btnsms = new Button();
            lblsms = new Label();
            txtfrom = new TextBox();
            txtto = new TextBox();
            lblfrom = new Label();
            lblto = new Label();
            SuspendLayout();
            // 
            // btnsms
            // 
            btnsms.Location = new Point(391, 215);
            btnsms.Name = "btnsms";
            btnsms.Size = new Size(112, 34);
            btnsms.TabIndex = 0;
            btnsms.Text = "sms";
            btnsms.UseVisualStyleBackColor = true;
            btnsms.Click += btnsms_Click;
            // 
            // lblsms
            // 
            lblsms.AutoSize = true;
            lblsms.Location = new Point(351, 341);
            lblsms.Name = "lblsms";
            lblsms.Size = new Size(59, 25);
            lblsms.TabIndex = 1;
            lblsms.Text = "label1";
            // 
            // txtfrom
            // 
            txtfrom.Location = new Point(382, 60);
            txtfrom.Name = "txtfrom";
            txtfrom.Size = new Size(150, 31);
            txtfrom.TabIndex = 2;
            // 
            // txtto
            // 
            txtto.Location = new Point(409, 128);
            txtto.Name = "txtto";
            txtto.Size = new Size(150, 31);
            txtto.TabIndex = 3;
            // 
            // lblfrom
            // 
            lblfrom.AutoSize = true;
            lblfrom.Location = new Point(275, 69);
            lblfrom.Name = "lblfrom";
            lblfrom.Size = new Size(51, 25);
            lblfrom.TabIndex = 4;
            lblfrom.Text = "from";
            // 
            // lblto
            // 
            lblto.AutoSize = true;
            lblto.Location = new Point(300, 133);
            lblto.Name = "lblto";
            lblto.Size = new Size(29, 25);
            lblto.TabIndex = 6;
            lblto.Text = "to";
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblto);
            Controls.Add(lblfrom);
            Controls.Add(txtto);
            Controls.Add(txtfrom);
            Controls.Add(lblsms);
            Controls.Add(btnsms);
            Name = "form1";
            Text = "form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsms;
        private Label lblsms;
        private TextBox txtfrom;
        private TextBox txtto;
        private Label lblfrom;
        private Label lblto;
    }
}
namespace WinApps1
{
    partial class frm
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
            btnadd = new Button();
            btndivide = new Button();
            btnmul = new Button();
            btnmodulo = new Button();
            btnsubstract = new Button();
            SuspendLayout();
            // 
            // btnadd
            // 
            btnadd.Location = new Point(409, 31);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(112, 34);
            btnadd.TabIndex = 0;
            btnadd.Text = "addition";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += OneFunction;
            // 
            // btndivide
            // 
            btndivide.Location = new Point(431, 112);
            btndivide.Name = "btndivide";
            btndivide.Size = new Size(112, 34);
            btndivide.TabIndex = 1;
            btndivide.Text = "divide";
            btndivide.UseVisualStyleBackColor = true;
            btndivide.Click += OneFunction;
            // 
            // btnmul
            // 
            btnmul.Location = new Point(454, 196);
            btnmul.Name = "btnmul";
            btnmul.Size = new Size(112, 34);
            btnmul.TabIndex = 2;
            btnmul.Text = "multi";
            btnmul.UseVisualStyleBackColor = true;
            btnmul.Click += OneFunction;
            // 
            // btnmodulo
            // 
            btnmodulo.Location = new Point(437, 273);
            btnmodulo.Name = "btnmodulo";
            btnmodulo.Size = new Size(112, 34);
            btnmodulo.TabIndex = 3;
            btnmodulo.Text = "modulo";
            btnmodulo.UseVisualStyleBackColor = true;
            btnmodulo.Click += OneFunction;
            // 
            // btnsubstract
            // 
            btnsubstract.Location = new Point(431, 330);
            btnsubstract.Name = "btnsubstract";
            btnsubstract.Size = new Size(112, 34);
            btnsubstract.TabIndex = 4;
            btnsubstract.Text = "substract";
            btnsubstract.UseVisualStyleBackColor = true;
            btnsubstract.Click += OneFunction;
            // 
            // frm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnsubstract);
            Controls.Add(btnmodulo);
            Controls.Add(btnmul);
            Controls.Add(btndivide);
            Controls.Add(btnadd);
            Name = "frm";
            Text = "frm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnadd;
        private Button btndivide;
        private Button btnmul;
        private Button btnmodulo;
        private Button btnsubstract;
    }
}
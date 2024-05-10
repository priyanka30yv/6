namespace WinApps1
{
    partial class frmCollectionagain
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
            listoriginal = new ComboBox();
            listfinal = new ComboBox();
            cbooriginal = new ListBox();
            cbofinal = new ListBox();
            btnstack = new Button();
            btnqueue = new Button();
            SuspendLayout();
            // 
            // listoriginal
            // 
            listoriginal.FormattingEnabled = true;
            listoriginal.Location = new Point(136, 81);
            listoriginal.Name = "listoriginal";
            listoriginal.Size = new Size(182, 33);
            listoriginal.TabIndex = 0;
            // 
            // listfinal
            // 
            listfinal.FormattingEnabled = true;
            listfinal.Location = new Point(136, 161);
            listfinal.Name = "listfinal";
            listfinal.Size = new Size(182, 33);
            listfinal.TabIndex = 1;
            // 
            // cbooriginal
            // 
            cbooriginal.FormattingEnabled = true;
            cbooriginal.ItemHeight = 25;
            cbooriginal.Location = new Point(523, 27);
            cbooriginal.Name = "cbooriginal";
            cbooriginal.Size = new Size(180, 129);
            cbooriginal.TabIndex = 2;
            // 
            // cbofinal
            // 
            cbofinal.FormattingEnabled = true;
            cbofinal.ItemHeight = 25;
            cbofinal.Location = new Point(523, 186);
            cbofinal.Name = "cbofinal";
            cbofinal.Size = new Size(180, 129);
            cbofinal.TabIndex = 3;
            // 
            // btnstack
            // 
            btnstack.Location = new Point(106, 293);
            btnstack.Name = "btnstack";
            btnstack.Size = new Size(112, 34);
            btnstack.TabIndex = 4;
            btnstack.Text = "stack";
            btnstack.UseVisualStyleBackColor = true;
            // 
            // btnqueue
            // 
            btnqueue.Location = new Point(262, 293);
            btnqueue.Name = "btnqueue";
            btnqueue.Size = new Size(112, 34);
            btnqueue.TabIndex = 5;
            btnqueue.Text = "queue";
            btnqueue.UseVisualStyleBackColor = true;
            btnqueue.Click += btnqueue_Click;
            // 
            // frmCollectionagain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnqueue);
            Controls.Add(btnstack);
            Controls.Add(cbofinal);
            Controls.Add(cbooriginal);
            Controls.Add(listfinal);
            Controls.Add(listoriginal);
            Name = "frmCollectionagain";
            Text = "frmCollectionagain";
            Load += frmCollectionagain_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox listoriginal;
        private ComboBox listfinal;
        private ListBox cbooriginal;
        private ListBox cbofinal;
        private Button btnstack;
        private Button btnqueue;
    }
}
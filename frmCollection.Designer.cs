namespace WinApps1
{
    partial class frmCollection
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
            btnhash = new Button();
            btnarray = new Button();
            lblans1 = new Label();
            lblans2 = new Label();
            btnqueue = new Button();
            btnstack = new Button();
            SuspendLayout();
            // 
            // btnhash
            // 
            btnhash.Location = new Point(601, 91);
            btnhash.Name = "btnhash";
            btnhash.Size = new Size(112, 34);
            btnhash.TabIndex = 0;
            btnhash.Text = "HashTable";
            btnhash.UseVisualStyleBackColor = true;
            btnhash.Click += btnhash_Click;
            // 
            // btnarray
            // 
            btnarray.Location = new Point(184, 96);
            btnarray.Name = "btnarray";
            btnarray.Size = new Size(112, 34);
            btnarray.TabIndex = 1;
            btnarray.Text = "ArrayList";
            btnarray.UseVisualStyleBackColor = true;
            btnarray.Click += btnarray_Click;
            // 
            // lblans1
            // 
            lblans1.AutoSize = true;
            lblans1.Location = new Point(407, 230);
            lblans1.Name = "lblans1";
            lblans1.Size = new Size(59, 25);
            lblans1.TabIndex = 2;
            lblans1.Text = "label1";
            // 
            // lblans2
            // 
            lblans2.AutoSize = true;
            lblans2.Location = new Point(422, 330);
            lblans2.Name = "lblans2";
            lblans2.Size = new Size(59, 25);
            lblans2.TabIndex = 3;
            lblans2.Text = "label2";
            // 
            // btnqueue
            // 
            btnqueue.Location = new Point(601, 159);
            btnqueue.Name = "btnqueue";
            btnqueue.Size = new Size(112, 34);
            btnqueue.TabIndex = 4;
            btnqueue.Text = "Queue";
            btnqueue.UseVisualStyleBackColor = true;
            btnqueue.Click += btnqueue_Click;
            // 
            // btnstack
            // 
            btnstack.Location = new Point(187, 178);
            btnstack.Name = "btnstack";
            btnstack.Size = new Size(112, 34);
            btnstack.TabIndex = 5;
            btnstack.Text = "stack";
            btnstack.UseVisualStyleBackColor = true;
            btnstack.Click += btnstack_Click;
            // 
            // frmCollection
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnstack);
            Controls.Add(btnqueue);
            Controls.Add(lblans2);
            Controls.Add(lblans1);
            Controls.Add(btnarray);
            Controls.Add(btnhash);
            Name = "frmCollection";
            Text = "frmCollection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnhash;
        private Button btnarray;
        private Label lblans1;
        private Label lblans2;
        private Button btnqueue;
        private Button btnstack;
    }
}
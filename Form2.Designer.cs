namespace Assignment3
{
    partial class Form2
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
            label1 = new Label();
            txtName = new TextBox();
            txtTeam = new TextBox();
            label2 = new Label();
            txtPoints = new TextBox();
            label3 = new Label();
            txtAssists = new TextBox();
            label4 = new Label();
            txtRebounds = new TextBox();
            label5 = new Label();
            txtFg = new TextBox();
            label6 = new Label();
            btnSelectImage = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            lblImageName = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 73);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // txtName
            // 
            txtName.Location = new Point(96, 70);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // txtTeam
            // 
            txtTeam.Location = new Point(96, 108);
            txtTeam.Name = "txtTeam";
            txtTeam.Size = new Size(100, 23);
            txtTeam.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 111);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "Team :";
            // 
            // txtPoints
            // 
            txtPoints.Location = new Point(96, 147);
            txtPoints.Name = "txtPoints";
            txtPoints.Size = new Size(100, 23);
            txtPoints.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 150);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 4;
            label3.Text = "Points :";
            // 
            // txtAssists
            // 
            txtAssists.Location = new Point(96, 188);
            txtAssists.Name = "txtAssists";
            txtAssists.Size = new Size(100, 23);
            txtAssists.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 191);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 6;
            label4.Text = "Assists :";
            // 
            // txtRebounds
            // 
            txtRebounds.Location = new Point(96, 226);
            txtRebounds.Name = "txtRebounds";
            txtRebounds.Size = new Size(100, 23);
            txtRebounds.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 229);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 8;
            label5.Text = "Rebounds :";
            // 
            // txtFg
            // 
            txtFg.Location = new Point(96, 265);
            txtFg.Name = "txtFg";
            txtFg.Size = new Size(100, 23);
            txtFg.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 268);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 10;
            label6.Text = "FG :";
            // 
            // btnSelectImage
            // 
            btnSelectImage.Location = new Point(56, 12);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(105, 23);
            btnSelectImage.TabIndex = 14;
            btnSelectImage.Text = "Select Image";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(24, 311);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(121, 311);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // lblImageName
            // 
            lblImageName.AutoSize = true;
            lblImageName.Location = new Point(81, 41);
            lblImageName.Name = "lblImageName";
            lblImageName.Size = new Size(0, 15);
            lblImageName.TabIndex = 17;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(221, 368);
            Controls.Add(lblImageName);
            Controls.Add(btnSelectImage);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtFg);
            Controls.Add(label6);
            Controls.Add(txtRebounds);
            Controls.Add(label5);
            Controls.Add(txtAssists);
            Controls.Add(label4);
            Controls.Add(txtPoints);
            Controls.Add(label3);
            Controls.Add(txtTeam);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtTeam;
        private Label label2;
        private TextBox txtPoints;
        private Label label3;
        private TextBox txtAssists;
        private Label label4;
        private TextBox txtRebounds;
        private Label label5;
        private TextBox txtFg;
        private Label label6;
        private Button btnSelectImage;
        private Button btnSave;
        private Button btnCancel;
        private Label lblImageName;
    }
}
namespace ModernWindows
{
    partial class Names
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            label1 = new Label();
            lstNames = new ListBox();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(333, 186);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(220, 68);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Name";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 89);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 1;
            label1.Text = "Names";
            label1.Click += label1_Click;
            // 
            // lstNames
            // 
            lstNames.FormattingEnabled = true;
            lstNames.ItemHeight = 25;
            lstNames.Location = new Point(72, 132);
            lstNames.Name = "lstNames";
            lstNames.Size = new Size(230, 229);
            lstNames.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(332, 132);
            txtName.Name = "txtName";
            txtName.Size = new Size(221, 31);
            txtName.TabIndex = 3;
            // 
            // Names
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtName);
            Controls.Add(lstNames);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Name = "Names";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label label1;
        private ListBox lstNames;
        private TextBox txtName;
    }
}

namespace MVVM_WinForms
{
    partial class AdditionalTask1
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
            panel1 = new Panel();
            addButton = new Button();
            ageNumericUpDown = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            nameTextBox = new TextBox();
            listBox1 = new ListBox();
            deleteButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(ageNumericUpDown);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(nameTextBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(563, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 450);
            panel1.TabIndex = 3;
            // 
            // addButton
            // 
            addButton.Location = new Point(82, 151);
            addButton.Name = "addButton";
            addButton.Size = new Size(90, 26);
            addButton.TabIndex = 4;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            // 
            // ageNumericUpDown
            // 
            ageNumericUpDown.Location = new Point(104, 98);
            ageNumericUpDown.Maximum = new decimal(new int[] { 65, 0, 0, 0 });
            ageNumericUpDown.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            ageNumericUpDown.Name = "ageNumericUpDown";
            ageNumericUpDown.Size = new Size(100, 23);
            ageNumericUpDown.TabIndex = 3;
            ageNumericUpDown.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 100);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 2;
            label2.Text = "Возраст : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 46);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Имя : ";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(104, 43);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Left;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(563, 450);
            listBox1.TabIndex = 2;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(82, 202);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(90, 26);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // AdditionalTask1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Name = "AdditionalTask1";
            Text = "AdditionalTask1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button addButton;
        private NumericUpDown ageNumericUpDown;
        private Label label2;
        private Label label1;
        private TextBox nameTextBox;
        private ListBox listBox1;
        private Button deleteButton;
    }
}
namespace MVVM_WinForms
{
    partial class CreateUpdateBookForm
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
            yearDateTimePicker = new DateTimePicker();
            titleTextBox = new TextBox();
            authorTextBox = new TextBox();
            genreTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            applyButton = new Button();
            SuspendLayout();
            // 
            // yearDateTimePicker
            // 
            yearDateTimePicker.Location = new Point(50, 224);
            yearDateTimePicker.Name = "yearDateTimePicker";
            yearDateTimePicker.Size = new Size(194, 23);
            yearDateTimePicker.TabIndex = 0;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(125, 45);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(126, 23);
            titleTextBox.TabIndex = 1;
            // 
            // authorTextBox
            // 
            authorTextBox.Location = new Point(125, 89);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new Size(126, 23);
            authorTextBox.TabIndex = 1;
            // 
            // genreTextBox
            // 
            genreTextBox.Location = new Point(125, 141);
            genreTextBox.Name = "genreTextBox";
            genreTextBox.Size = new Size(126, 23);
            genreTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 48);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 2;
            label1.Text = "Название :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 92);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Автор :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 144);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Жанр :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 199);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 3;
            label4.Text = "Год издания :";
            // 
            // applyButton
            // 
            applyButton.FlatStyle = FlatStyle.Flat;
            applyButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            applyButton.Location = new Point(96, 283);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(95, 31);
            applyButton.TabIndex = 4;
            applyButton.Text = "Применить";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += applyButton_Click;
            // 
            // CreateUpdateBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 339);
            Controls.Add(applyButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(genreTextBox);
            Controls.Add(authorTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(yearDateTimePicker);
            Name = "CreateUpdateBookForm";
            Text = "CreateUpdateBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker yearDateTimePicker;
        private TextBox titleTextBox;
        private TextBox authorTextBox;
        private TextBox genreTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button applyButton;
    }
}
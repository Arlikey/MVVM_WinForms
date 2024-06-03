namespace MVVM_WinForms
{
    partial class AdditionalTask2
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
            booksListBox = new ListBox();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            aboutButton = new Button();
            SuspendLayout();
            // 
            // booksListBox
            // 
            booksListBox.Dock = DockStyle.Right;
            booksListBox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            booksListBox.FormattingEnabled = true;
            booksListBox.ItemHeight = 25;
            booksListBox.Location = new Point(199, 0);
            booksListBox.Name = "booksListBox";
            booksListBox.Size = new Size(601, 450);
            booksListBox.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addButton.Location = new Point(30, 41);
            addButton.Name = "addButton";
            addButton.Size = new Size(135, 40);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить книгу";
            addButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            editButton.Location = new Point(30, 104);
            editButton.Name = "editButton";
            editButton.Size = new Size(135, 56);
            editButton.TabIndex = 1;
            editButton.Text = "Редактировать книгу";
            editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteButton.Location = new Point(30, 385);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(135, 40);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Удалить книгу";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // aboutButton
            // 
            aboutButton.FlatStyle = FlatStyle.Flat;
            aboutButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            aboutButton.Location = new Point(30, 183);
            aboutButton.Name = "aboutButton";
            aboutButton.Size = new Size(135, 59);
            aboutButton.TabIndex = 1;
            aboutButton.Text = "Доп. инфо. про книгу";
            aboutButton.UseVisualStyleBackColor = true;
            // 
            // AdditionalTask2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(aboutButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(booksListBox);
            Name = "AdditionalTask2";
            Text = "AdditionalTask2";
            ResumeLayout(false);
        }

        #endregion

        private ListBox booksListBox;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Button aboutButton;
    }
}
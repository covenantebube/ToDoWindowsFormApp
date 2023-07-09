namespace TODOLIST_windform_App
{
    partial class ToDoLsit
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

        private TextBox GetTitleTextBox()
        {
            return titleTextBox;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            titleTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            textdescription = new Label();
            textTitle = new Label();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            searchButton = new Button();
            dueDateTextBox = new TextBox();
            textDueDate = new Label();
            existButton = new Button();
            todoIdTextBox = new TextBox();
            searchDateTextBox = new TextBox();
            keywordTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(94, 55);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(1705, 148);
            label1.TabIndex = 0;
            label1.Text = "TO DO LIST";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(47, 440);
            titleTextBox.Margin = new Padding(1, 2, 1, 2);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(1908, 78);
            titleTextBox.TabIndex = 1;
            titleTextBox.TextChanged += titleTextBox_TextChanged;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(40, 611);
            descriptionTextBox.Margin = new Padding(1, 2, 1, 2);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(1908, 78);
            descriptionTextBox.TabIndex = 2;
            descriptionTextBox.TextChanged += descriptionTextBox_TextChanged;
            // 
            // textdescription
            // 
            textdescription.Font = new Font("Segoe UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            textdescription.Location = new Point(40, 545);
            textdescription.Margin = new Padding(1, 0, 1, 0);
            textdescription.Name = "textdescription";
            textdescription.Size = new Size(1741, 51);
            textdescription.TabIndex = 3;
            textdescription.Text = "DESCRIPTION";
            // 
            // textTitle
            // 
            textTitle.Font = new Font("Segoe UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            textTitle.Location = new Point(47, 348);
            textTitle.Margin = new Padding(1, 0, 1, 0);
            textTitle.Name = "textTitle";
            textTitle.Size = new Size(1741, 65);
            textTitle.TabIndex = 4;
            textTitle.Text = "TITLE";
            // 
            // addButton
            // 
            addButton.Location = new Point(40, 973);
            addButton.Margin = new Padding(1, 2, 1, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(1908, 91);
            addButton.TabIndex = 5;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(796, 1139);
            editButton.Margin = new Padding(1, 2, 1, 2);
            editButton.Name = "editButton";
            editButton.Size = new Size(864, 91);
            editButton.TabIndex = 6;
            editButton.Text = "Edit ";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(47, 1296);
            deleteButton.Margin = new Padding(1, 2, 1, 2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(1883, 91);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(796, 160);
            searchButton.Margin = new Padding(1, 2, 1, 2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(312, 114);
            searchButton.TabIndex = 8;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // dueDateTextBox
            // 
            dueDateTextBox.Location = new Point(40, 812);
            dueDateTextBox.Margin = new Padding(1, 2, 1, 2);
            dueDateTextBox.Name = "dueDateTextBox";
            dueDateTextBox.Size = new Size(1908, 78);
            dueDateTextBox.TabIndex = 10;
            // 
            // textDueDate
            // 
            textDueDate.Font = new Font("Segoe UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            textDueDate.Location = new Point(40, 720);
            textDueDate.Margin = new Padding(1, 0, 1, 0);
            textDueDate.Name = "textDueDate";
            textDueDate.Size = new Size(1741, 80);
            textDueDate.TabIndex = 11;
            textDueDate.Text = "DUE DATE (yyyy-mm-dd)";
            textDueDate.Click += textDueDate_Click;
            // 
            // existButton
            // 
            existButton.BackColor = SystemColors.ActiveCaption;
            existButton.Location = new Point(1693, 22);
            existButton.Margin = new Padding(1, 2, 1, 2);
            existButton.Name = "existButton";
            existButton.Size = new Size(262, 91);
            existButton.TabIndex = 12;
            existButton.Text = "Exist";
            existButton.UseVisualStyleBackColor = false;
            existButton.Click += existButton_Click;
            // 
            // todoIdTextBox
            // 
            todoIdTextBox.ForeColor = SystemColors.InactiveCaption;
            todoIdTextBox.Location = new Point(601, 1146);
            todoIdTextBox.Margin = new Padding(1, 2, 1, 2);
            todoIdTextBox.Name = "todoIdTextBox";
            todoIdTextBox.Size = new Size(125, 78);
            todoIdTextBox.TabIndex = 13;
            todoIdTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // searchDateTextBox
            // 
            searchDateTextBox.ForeColor = SystemColors.Desktop;
            searchDateTextBox.Location = new Point(525, 288);
            searchDateTextBox.Margin = new Padding(1, 2, 1, 2);
            searchDateTextBox.Name = "searchDateTextBox";
            searchDateTextBox.Size = new Size(409, 78);
            searchDateTextBox.TabIndex = 14;
            searchDateTextBox.TextAlign = HorizontalAlignment.Right;
            searchDateTextBox.TextChanged += searchDateTextBox_TextChanged;
            // 
            // keywordTextBox
            // 
            keywordTextBox.ForeColor = SystemColors.Desktop;
            keywordTextBox.Location = new Point(975, 288);
            keywordTextBox.Margin = new Padding(1, 2, 1, 2);
            keywordTextBox.Name = "keywordTextBox";
            keywordTextBox.Size = new Size(389, 78);
            keywordTextBox.TabIndex = 15;
            keywordTextBox.TextAlign = HorizontalAlignment.Right;
            keywordTextBox.TextChanged += keywordTextBox_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(525, 238);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 48);
            label2.TabIndex = 16;
            label2.Text = "Date";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1180, 238);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(205, 48);
            label3.TabIndex = 17;
            label3.Text = "KEYWORD";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(40, 1150);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(559, 80);
            label4.TabIndex = 18;
            label4.Text = "Input Id to Edit or Delete";
            label4.Click += label4_Click;
            // 
            // ToDoLsit
            // 
            AutoScaleDimensions = new SizeF(29F, 71F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1976, 1470);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(keywordTextBox);
            Controls.Add(searchDateTextBox);
            Controls.Add(todoIdTextBox);
            Controls.Add(existButton);
            Controls.Add(textDueDate);
            Controls.Add(dueDateTextBox);
            Controls.Add(searchButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(textTitle);
            Controls.Add(textdescription);
            Controls.Add(descriptionTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "ToDoLsit";
            Text = "To Do List";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
        private Label textdescription;
        private Label textTitle;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Button searchButton;
        private TextBox dueDateTextBox;
        private Label textDueDate;
        private Button existButton;
        private TextBox todoIdTextBox;
        private TextBox searchDateTextBox;
        private TextBox keywordTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
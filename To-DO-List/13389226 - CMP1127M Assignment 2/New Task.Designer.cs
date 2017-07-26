namespace _13389226___CMP1127M_Assignment_2
{
    partial class NewTask
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.taskTitleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.taskDescTextBox = new System.Windows.Forms.RichTextBox();
            this.taskPriorityCombo = new System.Windows.Forms.ComboBox();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.finishDateLabel = new System.Windows.Forms.Label();
            this.taskFinishDate = new System.Windows.Forms.DateTimePicker();
            this.createTaskButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(114, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Task Title";
            // 
            // taskTitleTextBox
            // 
            this.taskTitleTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTitleTextBox.Location = new System.Drawing.Point(17, 53);
            this.taskTitleTextBox.MaxLength = 32;
            this.taskTitleTextBox.Name = "taskTitleTextBox";
            this.taskTitleTextBox.Size = new System.Drawing.Size(182, 27);
            this.taskTitleTextBox.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(12, 90);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(187, 25);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Task Description";
            // 
            // taskDescTextBox
            // 
            this.taskDescTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskDescTextBox.Location = new System.Drawing.Point(12, 126);
            this.taskDescTextBox.MaxLength = 256;
            this.taskDescTextBox.Name = "taskDescTextBox";
            this.taskDescTextBox.Size = new System.Drawing.Size(465, 135);
            this.taskDescTextBox.TabIndex = 3;
            this.taskDescTextBox.Text = "";
            // 
            // taskPriorityCombo
            // 
            this.taskPriorityCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taskPriorityCombo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskPriorityCombo.FormattingEnabled = true;
            this.taskPriorityCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.taskPriorityCombo.Location = new System.Drawing.Point(117, 267);
            this.taskPriorityCombo.MaxDropDownItems = 10;
            this.taskPriorityCombo.Name = "taskPriorityCombo";
            this.taskPriorityCombo.Size = new System.Drawing.Size(52, 26);
            this.taskPriorityCombo.TabIndex = 4;
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityLabel.Location = new System.Drawing.Point(23, 267);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(88, 25);
            this.priorityLabel.TabIndex = 5;
            this.priorityLabel.Text = "Priority";
            // 
            // finishDateLabel
            // 
            this.finishDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finishDateLabel.AutoSize = true;
            this.finishDateLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishDateLabel.Location = new System.Drawing.Point(187, 267);
            this.finishDateLabel.Name = "finishDateLabel";
            this.finishDateLabel.Size = new System.Drawing.Size(130, 25);
            this.finishDateLabel.TabIndex = 6;
            this.finishDateLabel.Text = "Finish Date";
            // 
            // taskFinishDate
            // 
            this.taskFinishDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskFinishDate.CalendarFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskFinishDate.Location = new System.Drawing.Point(323, 271);
            this.taskFinishDate.MinDate = new System.DateTime(2015, 4, 29, 0, 0, 0, 0);
            this.taskFinishDate.Name = "taskFinishDate";
            this.taskFinishDate.Size = new System.Drawing.Size(148, 20);
            this.taskFinishDate.TabIndex = 7;
            // 
            // createTaskButton
            // 
            this.createTaskButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTaskButton.Location = new System.Drawing.Point(161, 316);
            this.createTaskButton.Name = "createTaskButton";
            this.createTaskButton.Size = new System.Drawing.Size(173, 46);
            this.createTaskButton.TabIndex = 8;
            this.createTaskButton.Text = "Save Task";
            this.createTaskButton.UseVisualStyleBackColor = true;
            this.createTaskButton.Click += new System.EventHandler(this.createTaskButtonClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(489, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.closeWindow);
            // 
            // NewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 374);
            this.Controls.Add(this.createTaskButton);
            this.Controls.Add(this.taskFinishDate);
            this.Controls.Add(this.finishDateLabel);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.taskPriorityCombo);
            this.Controls.Add(this.taskDescTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.taskTitleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(505, 412);
            this.MinimumSize = new System.Drawing.Size(505, 412);
            this.Name = "NewTask";
            this.Text = "New Task";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.Label finishDateLabel;
        private System.Windows.Forms.Button createTaskButton;
        public System.Windows.Forms.Label titleLabel;
        public System.Windows.Forms.TextBox taskTitleTextBox;
        public System.Windows.Forms.RichTextBox taskDescTextBox;
        public System.Windows.Forms.ComboBox taskPriorityCombo;
        public System.Windows.Forms.DateTimePicker taskFinishDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}
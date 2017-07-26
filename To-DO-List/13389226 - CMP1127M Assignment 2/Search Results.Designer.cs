namespace _13389226___CMP1127M_Assignment_2
{
    partial class SearchResults
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
            this.taskTitle = new System.Windows.Forms.Label();
            this.taskDescription = new System.Windows.Forms.RichTextBox();
            this.taskPriority = new System.Windows.Forms.Label();
            this.finishDateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.taskDate = new System.Windows.Forms.Label();
            this.taskComplete = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.taskIncomplete = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskTitle
            // 
            this.taskTitle.AutoSize = true;
            this.taskTitle.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTitle.Location = new System.Drawing.Point(12, 30);
            this.taskTitle.Name = "taskTitle";
            this.taskTitle.Size = new System.Drawing.Size(125, 25);
            this.taskTitle.TabIndex = 0;
            this.taskTitle.Text = "Task Title";
            // 
            // taskDescription
            // 
            this.taskDescription.Enabled = false;
            this.taskDescription.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDescription.Location = new System.Drawing.Point(16, 80);
            this.taskDescription.Name = "taskDescription";
            this.taskDescription.Size = new System.Drawing.Size(435, 139);
            this.taskDescription.TabIndex = 1;
            this.taskDescription.Text = "";
            // 
            // taskPriority
            // 
            this.taskPriority.AutoSize = true;
            this.taskPriority.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskPriority.Location = new System.Drawing.Point(119, 247);
            this.taskPriority.Name = "taskPriority";
            this.taskPriority.Size = new System.Drawing.Size(28, 18);
            this.taskPriority.TabIndex = 3;
            this.taskPriority.Text = "10";
            // 
            // finishDateLabel
            // 
            this.finishDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finishDateLabel.AutoSize = true;
            this.finishDateLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishDateLabel.Location = new System.Drawing.Point(198, 244);
            this.finishDateLabel.Name = "finishDateLabel";
            this.finishDateLabel.Size = new System.Drawing.Size(141, 23);
            this.finishDateLabel.TabIndex = 7;
            this.finishDateLabel.Text = "Finish Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Priority:";
            // 
            // taskDate
            // 
            this.taskDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskDate.AutoSize = true;
            this.taskDate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDate.Location = new System.Drawing.Point(335, 247);
            this.taskDate.Name = "taskDate";
            this.taskDate.Size = new System.Drawing.Size(102, 18);
            this.taskDate.TabIndex = 9;
            this.taskDate.Text = "12/12/2000";
            // 
            // taskComplete
            // 
            this.taskComplete.AutoSize = true;
            this.taskComplete.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskComplete.ForeColor = System.Drawing.Color.Green;
            this.taskComplete.Location = new System.Drawing.Point(145, 291);
            this.taskComplete.Name = "taskComplete";
            this.taskComplete.Size = new System.Drawing.Size(184, 25);
            this.taskComplete.TabIndex = 12;
            this.taskComplete.Text = "Task Complete";
            this.taskComplete.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(122, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 53);
            this.button1.TabIndex = 13;
            this.button1.Text = "Next Search result >>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.nextResult);
            // 
            // taskIncomplete
            // 
            this.taskIncomplete.AutoSize = true;
            this.taskIncomplete.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskIncomplete.ForeColor = System.Drawing.Color.Red;
            this.taskIncomplete.Location = new System.Drawing.Point(126, 291);
            this.taskIncomplete.Name = "taskIncomplete";
            this.taskIncomplete.Size = new System.Drawing.Size(207, 25);
            this.taskIncomplete.TabIndex = 14;
            this.taskIncomplete.Text = "Task Incomplete";
            this.taskIncomplete.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(469, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.closeWindow);
            // 
            // SearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 410);
            this.Controls.Add(this.taskIncomplete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.taskComplete);
            this.Controls.Add(this.taskDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.finishDateLabel);
            this.Controls.Add(this.taskPriority);
            this.Controls.Add(this.taskDescription);
            this.Controls.Add(this.taskTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(485, 448);
            this.MinimumSize = new System.Drawing.Size(485, 448);
            this.Name = "SearchResults";
            this.Text = "Search_Results";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskTitle;
        private System.Windows.Forms.RichTextBox taskDescription;
        private System.Windows.Forms.Label taskPriority;
        private System.Windows.Forms.Label finishDateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label taskDate;
        private System.Windows.Forms.Label taskComplete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label taskIncomplete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}
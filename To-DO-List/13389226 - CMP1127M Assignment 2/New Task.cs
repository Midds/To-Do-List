using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13389226___CMP1127M_Assignment_2
{
    public partial class NewTask : Form
    {
        public static bool createTaskButtonClicked; // Used in MainMenu.cs to ensure that data is ONLY passed back if the create task button is clicked (as opposed to using the close window button as well).

        // This constructor is used for new tasks.
        public NewTask()
        {
            InitializeComponent();
            taskFinishDate.MinDate = DateTime.Today; // Stops the user from selecting an end date in the past.
        }

        // This constructor is used for editing tasks.
        public NewTask(string title, string description, string priority, string finish)
        {
            InitializeComponent();

            // Stops issues when importing a save file with a date lower than MinDate.
            if (Convert.ToDateTime(finish) < taskFinishDate.MinDate) 
                taskFinishDate.Text = Convert.ToString(DateTime.Today);
            else
                taskFinishDate.Text = finish;

            // Updates fields with any current information on a task.
            createTaskButtonClicked = false;
            taskTitleTextBox.Text = title;
            taskDescTextBox.Text = description;
            taskPriorityCombo.Text = priority;
        }

        private void createTaskButtonClick(object sender, EventArgs e)
        {
            string format = "d MMMM yyyy"; // creating a date format
            string errorCaption = "Error Detected in Input"; // used at the title in my error Messageboxes
            string dateMessage = "Your task finishing date is listed as today's date, was this intentional?"; // used in dateTime error message
            MessageBoxButtons buttons = MessageBoxButtons.YesNo; // used in dateTime error message
            DialogResult result; // used in dateTime error message

            // If finishing date is todays date, asks if user made a mistake.
            if (taskFinishDate.Text == DateTime.Today.ToString(format))
            {
                result = MessageBox.Show(dateMessage, errorCaption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (taskTitleTextBox.Text != "" && taskDescTextBox.Text != "" && taskPriorityCombo.Text != "")
                    {
                        createTaskButtonClicked = true;
                        this.Close();
                    }
                }
            }

            // Makes sure the user has input values into all the boxes before closing.
            if (taskTitleTextBox.Text == "")
                MessageBox.Show("You forgot to give your task a title!", errorCaption);
            if (taskDescTextBox.Text == "")
                MessageBox.Show("You forgot to give your task a description!", errorCaption);
            if (taskPriorityCombo.Text == "")
                MessageBox.Show("You forgot to give your task a priority!", errorCaption);
            else if (taskTitleTextBox.Text != "" && taskDescTextBox.Text != "" && taskPriorityCombo.Text != "" && taskFinishDate.Text != DateTime.Today.ToString(format))
            {
                createTaskButtonClicked = true;
                this.Close();
            }
        }

        private void closeWindow(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class SearchResults : Form
    {
        List<ToDoTask> searchResults = new List<ToDoTask>();
        int taskCounter = 0;

        public SearchResults(List<ToDoTask> results, int counter)
        {
            InitializeComponent();

            searchResults = results;
            taskCounter = counter;

            // Checks if task is completed or not to display the correct label.
            if (searchResults[counter].taskCompletionStatus == true)
                taskComplete.Show();
            else if (searchResults[counter].taskCompletionStatus == false)
                taskIncomplete.Show();

            taskTitle.Text = searchResults[counter].taskTitle;
            taskDescription.Text = searchResults[counter].taskDescription;
            taskPriority.Text = searchResults[counter].taskPriority;
            taskDate.Text = searchResults[counter].taskFinish;
        }

        // Each time the next result button is pressed it will increase taskCounter by 1 and then display the new information.
        private void nextResult(object sender, EventArgs e)
        {
            taskCounter++;
            if (taskCounter == searchResults.Count)// Prevents exceptions from being thrown.
            {
                MessageBox.Show("No more results to display", "End of Results.");
                this.Close();
            }
            else
            {
                if (searchResults[taskCounter].taskCompletionStatus == true)
                    taskComplete.Show();
                else if (searchResults[taskCounter].taskCompletionStatus == false)
                    taskIncomplete.Show();

                taskTitle.Text = searchResults[taskCounter].taskTitle;
                taskDescription.Text = searchResults[taskCounter].taskDescription;
                taskPriority.Text = searchResults[taskCounter].taskPriority;
                taskDate.Text = searchResults[taskCounter].taskFinish;                
            }
        }

        private void closeWindow(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

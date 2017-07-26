using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _13389226___CMP1127M_Assignment_2
{
    public partial class MainMenu : Form
    {
        static public int taskCount = 0; // Counts how many tasks there are.
        static public int currentlyViewedTask = -1; // Keeps track of which task is currently in the task viewer.
        List<ToDoTask> tasks = new List<ToDoTask>(); // List of ToDoTasks

        public MainMenu()
        {
            InitializeComponent();
        }

        // Method that creates a new task.
        private void createNewTask(object sender, EventArgs e)
        {
            taskCount++; // taskCount keeps track of how many tasks in total there are and is useful to know when updating the GUI later.
            NewTask createNew = new NewTask();

            if (taskCount <= 10) // Stops the user from making more than 10 tasks.
            {
                // Opening the second new task form
                createNew.ShowDialog();
            }
            if (taskCount > 10) // Shows an error if the user tries to make a task if at task limit.
            {
                string errorCaption = "Task limit reached";
                MessageBox.Show("You have reached the limit of tasks that you can make, please delete a task before creating another one.", errorCaption);
            }
            if (NewTask.createTaskButtonClicked == true) // Makes sure the user accepted the task (aka it won't create the task if the close window button is clicked instead)
            {
                viewTaskInstruction.Visible = true;
                tasks.Add(new ToDoTask() // Adding a new task to the list.
                {
                    taskTitle = createNew.taskTitleTextBox.Text,
                    taskDescription = createNew.taskDescTextBox.Text,
                    taskPriority = createNew.taskPriorityCombo.Text,
                    taskFinish = createNew.taskFinishDate.Text,
                });

                setTask(); // Changes the GUI to reflect and new tasks.
            }
        }

        // This method acts as a middle-man between updating the GUI in "updateTaskInfo" and changes made to the tasks elsewhere in the application.
        public void setTask()
        {
                updateTaskInfo(taskTitle1, taskFinish1, taskPriority1, task1Status, editButton1, deleteButton1, 0);
                updateTaskInfo(taskTitle2, taskFinish2, taskPriority2, task2Status, editButton2, deleteButton2, 1);
                updateTaskInfo(taskTitle3, taskFinish3, taskPriority3, task3Status, editButton3, deleteButton3, 2);
                updateTaskInfo(taskTitle4, taskFinish4, taskPriority4, task4Status, editButton4, deleteButton4, 3);
                updateTaskInfo(taskTitle5, taskFinish5, taskPriority5, task5Status, editButton5, deleteButton5, 4);
                updateTaskInfo(taskTitle6, taskFinish6, taskPriority6, task6Status, editButton6, deleteButton6, 5);
                updateTaskInfo(taskTitle7, taskFinish7, taskPriority7, task7Status, editButton7, deleteButton7, 6);
                updateTaskInfo(taskTitle8, taskFinish8, taskPriority8, task8Status, editButton8, deleteButton8, 7);
                updateTaskInfo(taskTitle9, taskFinish9, taskPriority9, task9Status, editButton9, deleteButton9, 8);
                updateTaskInfo(taskTitle10, taskFinish10, taskPriority10, task10Status, editButton10, deleteButton10, 9);
        }

        // This updates the GUI (specifically the table with all the tasks in) to dislay any new changes made by the user.
        public void updateTaskInfo(Label taskTitle, Label taskFinish, Label taskPriority, CheckBox status, Button edit, Button delete, int id)
        {
            if (tasks.Count == 0 || tasks.Count <= id) // If this is true then it means that a task has been deleted, therefore the task information should be hidden.
            {
                taskTitle.Text = "";
                taskFinish.Text = "";
                taskPriority.Text = "";
                status.Hide();
                edit.Hide();
                delete.Hide();
                return;
            }
            else
            {
                taskTitle.Text = tasks[id].taskTitle;
                taskFinish.Text = tasks[id].taskFinish;
                taskPriority.Text = tasks[id].taskPriority;
                bool tempChecked = tasks[id].taskCompletionStatus; // Created a temporary variable to store the completionStatus
                status.Checked = tasks[id].taskCompletionStatus; // This line was causing issues giving the wrong status when loading a save file, the above temp method fixed the issue.
                tasks[id].taskCompletionStatus = tempChecked; // Makes taskCompletionStatus whatever it was orgininally.
                status.Show();
                edit.Show();
                delete.Show();
            }

        }

        // Opens a message box detailing program information.
        private void aboutProgram(object sender, EventArgs e)
        {
            string aboutMessage = "This program is a To-Do list\n\nTo create a new task use the File menu.\n";
            string aboutMessage2 = "Up to 10 tasks may be created.\n\nTo view a task in more detail simply click on it's name.";
            string aboutMessage3 = "\n\n\u00A9James Middleton";
            MessageBox.Show(aboutMessage + aboutMessage2 + aboutMessage3,  "About Program");
        }

        // Exits the program.
        private void exitProgram(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Edit task buttons, each button calls setEditTask but sends a different number depending on which button is pressed
        // to ensure that the correct task is edited. (number corresponds to list position of task)
        private void editTaskButton1(object sender, EventArgs e) { setEditTask(0); }
        private void editTaskButton2(object sender, EventArgs e) { setEditTask(1); }
        private void editTaskButton3(object sender, EventArgs e) { setEditTask(2); }
        private void editTaskButton4(object sender, EventArgs e) { setEditTask(3); }
        private void editTaskButton5(object sender, EventArgs e) { setEditTask(4); }
        private void editTaskButton6(object sender, EventArgs e) { setEditTask(5); }
        private void editTaskButton7(object sender, EventArgs e) { setEditTask(6); }
        private void editTaskButton8(object sender, EventArgs e) { setEditTask(7); }
        private void editTaskButton9(object sender, EventArgs e) { setEditTask(8); }
        private void editTaskButton10(object sender, EventArgs e) { setEditTask(9); }

        // Opens a new form for the user to re-enter information to edit a task.
        public void setEditTask(int taskId)
        {
            // Opening the form. Currently held data on the task to be edited is sent to fill the fields on the new form.
            NewTask editTask = new NewTask(tasks[taskId].taskTitle, tasks[taskId].taskDescription, tasks[taskId].taskPriority, tasks[taskId].taskFinish);
            editTask.ShowDialog();

            if (NewTask.createTaskButtonClicked == true) // Makes sure the user accepted the new info (aka it won't update the task if the close window button is clicked instead)
            {
                // Updates the list with the new info, but not the gui.
                tasks[taskId].taskTitle = (editTask.taskTitleTextBox.Text);
                tasks[taskId].taskDescription = (editTask.taskDescTextBox.Text);
                tasks[taskId].taskPriority = (editTask.taskPriorityCombo.Text);
                tasks[taskId].taskFinish = (editTask.taskFinishDate.Text);

                setTask(); // This updates the GUI.

                // If the current task in the task viewer is the task being edited, then it will re-display the new information.
                if (currentlyViewedTask == taskId)
                    displayTask(taskId);
            }
        }

        // Delete task buttons.
        private void deleteTaskButton1(object sender, EventArgs e)
        {
            tasks.RemoveAt(0); // Removes the task in the ToDoTask list at the position given, doesn't update the GUI though.
            taskCount--; // Keeps track of how many tasks there are.
            if (currentlyViewedTask == 0) // If the current task in the task viewer is the task to be deleted then hide it.
                hideTask();
            
            setTask(); // Calls setTask() to update the GUI
        }
        private void deleteTaskButton2(object sender, EventArgs e)
        {
            tasks.RemoveAt(1);
            taskCount--;
            if (currentlyViewedTask == 1)
                hideTask();

            setTask();
        }
        private void deleteTaskButton3(object sender, EventArgs e)
        {
            tasks.RemoveAt(2);
            taskCount--;
            if (currentlyViewedTask == 2)
                hideTask();

            setTask();
        }
        private void deleteTaskButton4(object sender, EventArgs e)
        {
            tasks.RemoveAt(3);
            taskCount--;
            if (currentlyViewedTask == 3)
                hideTask();

            setTask();
        }
        private void deleteTaskButton5(object sender, EventArgs e)
        {
            tasks.RemoveAt(4);
            taskCount--;
            if (currentlyViewedTask == 4)
                hideTask();

            setTask();
        }
        private void deleteTaskButton6(object sender, EventArgs e)
        {
            tasks.RemoveAt(5);
            taskCount--;
            if (currentlyViewedTask == 5)
                hideTask();

            setTask();
        }
        private void deleteTaskButton7(object sender, EventArgs e)
        {
            tasks.RemoveAt(6);
            taskCount--;
            if (currentlyViewedTask == 6)
                hideTask();

            setTask();
        }
        private void deleteTaskButton8(object sender, EventArgs e)
        {
            tasks.RemoveAt(7);
            taskCount--;
            if (currentlyViewedTask == 7)
                hideTask();

            setTask();
        }
        private void deleteTaskButton9(object sender, EventArgs e)
        {
            tasks.RemoveAt(8);
            taskCount--;
            if (currentlyViewedTask == 8)
                hideTask();

            setTask();
        }
        private void deleteTaskButton10(object sender, EventArgs e)
        {
            tasks.RemoveAt(9);
            taskCount--;
            if (currentlyViewedTask == 9)
                hideTask();

            setTask();
        }

        // View task click events, activated upon clicking a task name.
        private void viewTask1(object sender, EventArgs e) { displayTask(0); }
        private void viewTask2(object sender, EventArgs e) { displayTask(1); }
        private void viewTask3(object sender, EventArgs e) { displayTask(2); }
        private void viewTask4(object sender, EventArgs e) { displayTask(3); }
        private void viewTask5(object sender, EventArgs e) { displayTask(4); }
        private void viewTask6(object sender, EventArgs e) { displayTask(5); }
        private void viewTask7(object sender, EventArgs e) { displayTask(6); }
        private void viewTask8(object sender, EventArgs e) { displayTask(7); }
        private void viewTask9(object sender, EventArgs e) { displayTask(8); }
        private void viewTask10(object sender, EventArgs e) { displayTask(9); }

        // Displays a task in the task viewer. taskNumber corresponds to tasks in the ToDoTask list.
        public void displayTask(int taskNumber)
        {

            currentlyViewedTask = taskNumber; // currentlyViewedTask can now be used to identify which task is being viewed

            viewTaskInstruction.Visible = false; // Hide the instruction message...
            displayTaskTitle.Visible = true; // Display title
            displayTaskDescription.Visible = true; // Display description
            displayTaskPriority.Visible = true; // Display priority label
            displayTaskPNumber.Visible = true; // Display priorirty number
            displayTaskFinish.Visible = true; // Display finish date label
            displayTaskFDate.Visible = true; // Display finish date

            // Fill the newly displayed labels and text boxes with task information.
            displayTaskTitle.Text = tasks[taskNumber].taskTitle;
            displayTaskDescription.Text = tasks[taskNumber].taskDescription;
            displayTaskPNumber.Text = tasks[taskNumber].taskPriority;
            displayTaskFDate.Text = tasks[taskNumber].taskFinish;
            if (tasks[taskNumber].taskCompletionStatus == true) // If the task is ticked as complete then show "complete"...
            {
                taskComplete.Visible = true;
                taskIncomplete.Visible = false;
            }
            if (tasks[taskNumber].taskCompletionStatus == false)   // Otherwise show "incomplete"
            {
                taskIncomplete.Visible = true;
                taskComplete.Visible = false;
            }
        }

        // Hides the current task from the taskviewer.
        public void hideTask()
        {
            viewTaskInstruction.Visible = true; // Display the instruction message
            displayTaskTitle.Visible = false; // Hide title
            displayTaskDescription.Visible = false; // Hide description
            displayTaskPriority.Visible = false; // Hide priority label
            displayTaskPNumber.Visible = false; // Hide priority number
            displayTaskFinish.Visible = false; // Hide task finish date label
            displayTaskFDate.Visible = false; // Hide the finish date
            taskComplete.Visible = false; // Hide the completion message
            taskIncomplete.Visible = false; // Hide the incompletion message
        }

        // Changes the cursor to a hand when hovering over a task name. This tells the user it can be clicked.
        private void mouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }
        // Changed the cursor back to default if the user stops hovering over a task name.
        private void mouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        // taskCompletionStatus checkbox check events. Checking a task to signify completion will active this.
        private void task1StatusChange(object sender, EventArgs e) { changeTaskStatus(0); }
        private void task2StatusChange(object sender, EventArgs e) { changeTaskStatus(1); }
        private void task3StatusChange(object sender, EventArgs e) { changeTaskStatus(2); }
        private void task4StatusChange(object sender, EventArgs e) { changeTaskStatus(3); }
        private void task5StatusChange(object sender, EventArgs e) { changeTaskStatus(4); }
        private void task6StatusChange(object sender, EventArgs e) { changeTaskStatus(5); }
        private void task7StatusChange(object sender, EventArgs e) { changeTaskStatus(6); }
        private void task8StatusChange(object sender, EventArgs e) { changeTaskStatus(7); }
        private void task9StatusChange(object sender, EventArgs e) { changeTaskStatus(8); }
        private void task10StatusChange(object sender, EventArgs e) { changeTaskStatus(9); }

        // Changes the task viewer to signify if a task has been completed or not.
        private void changeTaskStatus(int taskNumber)
        {
            if (tasks[taskNumber].taskCompletionStatus == false)
                tasks[taskNumber].taskCompletionStatus = true;
            else if (tasks[taskNumber].taskCompletionStatus == true)
                tasks[taskNumber].taskCompletionStatus = false;
            
            if (currentlyViewedTask == taskNumber) // If the task which has just been checked is currently in the task viewer then it will update the task viewer to display the new information.
                displayTask(taskNumber);
        }
        
        // Open a list of tasks from a txt file, the file must be correctly formatted and in the right order.
        private void openTasks(object sender, EventArgs e)
        {
            OpenSaving open = new OpenSaving();
            open.openList(sender, e, tasks);

            hideTask(); // Resetting the task viewer
            setTask(); // Updating the GUI
        }

        // Save the list of tasks to file, each task variable will be saved to a line each.
        private void saveTasks(object sender, EventArgs e)
        {
            OpenSaving save = new OpenSaving();
            save.saveList(sender, e, tasks);
        }

        // Sort the list of tasks by their priority, 1 at the top 10 at the bottom.
        private void sortByPriority(object sender, EventArgs e)
        {
            if (tasks.Count != 0) 
            {
                Sorting sort = new Sorting();
                sort.bubbleSort(tasks);
                setTask();
                hideTask();
            }
            else if (tasks.Count == 0 || tasks.Count == 1) // Wont sorting if there are no tasks to sort.
                MessageBox.Show("There are not enough tasks to sort!");
        }

        private void searchTasks(object sender, EventArgs e)
        {
            string userSearch = searchTextBox.Text;
            TaskSearch searchTask = new TaskSearch();
            if (searchTextBox.Text != "")// Prevents the user from searching nothing
            {
                List<ToDoTask> searchResults = searchTask.linearSearch(tasks, userSearch);

                if (searchResults.Count >= 1) // Only shows search results if there are any (notification for no results is in the searchTask method).
                {
                    SearchResults displayResults = new SearchResults(searchResults, 0);

                    // Opening the search results form
                    displayResults.ShowDialog();
                }
            }
            if (searchTextBox.Text == "")
            {
                MessageBox.Show("Enter a word to search your tasks... ", "No Search term entered");
            }
        }
    }

    // My task object
    public class ToDoTask
    {
        public string taskTitle;
        public string taskDescription;
        public string taskPriority;
        public string taskFinish;
        public bool taskCompletionStatus;

        public ToDoTask()
        {
        }

        public ToDoTask(string ataskTitle, string ataskDescription, string ataskPriority, string ataskFinish, bool ataskCompletionStatus)
        {
            taskTitle = ataskTitle;
            taskDescription = ataskDescription;
            taskPriority = ataskPriority;
            taskFinish = ataskFinish;
            taskCompletionStatus = ataskCompletionStatus;
        }
    }

    // Contains bubblesort sorting algorithm to sort tasks in priority order.
    public class Sorting
    {
        public List<ToDoTask> bubbleSort(List<ToDoTask> tasks)
        {
            int[] taskPriorityArray = new int[tasks.Count];

            for (int i = 0; i < tasks.Count; i++)
            {
                // creating an array of just the task priorities to be sorted.
                taskPriorityArray[i] = Convert.ToInt32(tasks[i].taskPriority);
            }

            int n = tasks.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (taskPriorityArray[j + 1] < taskPriorityArray[j])
                    {

                        // Whatever gets carried out onto "taskPriorityArray" gets carried out onto the list as well.
                        int tempPriority = taskPriorityArray[j];
                        taskPriorityArray[j] = taskPriorityArray[j + 1];
                        taskPriorityArray[j + 1] = tempPriority;

                        ToDoTask tempList;
                        tempList = tasks[j];
                        tasks[j] = tasks[j + 1];
                        tasks[j + 1] = tempList;
                    }
                }
            }

            return tasks;
        }
    }

    // Contains methods for opening txt files and saving to txr file.
    public class OpenSaving
    {
        public List<ToDoTask> openList(object sender, EventArgs e, List<ToDoTask> tasks)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "saved ToDo lists";
            open.Filter = "txt files (*.txt)|*.txt";

            if (open.ShowDialog() == DialogResult.OK)
            {
                string fileName = open.FileName;
                MainMenu task = new MainMenu();
                task.setTask();
                // Deleting all the current tasks before i open the new ones.
                int taskCountTemp = tasks.Count; // This temp int is needed for the taskRemoval for loop.
                for (int i = 0; i < taskCountTemp; i++)
                {
                    tasks.RemoveAt(0);
                }
                MainMenu.taskCount = 0; // resetting task count

                try
                {
                    // Reading in the new file and assigning each line to a different variable of each object in the list.
                    string[] lines = File.ReadAllLines(fileName);
                    for (int i = 0; i < lines.Length; i = i + 5)
                    {
                        tasks.Add(new ToDoTask()
                        {
                            taskTitle = lines[i],
                            taskDescription = lines[i + 1],
                            taskPriority = lines[i + 2],
                            taskFinish = lines[i + 3],
                            taskCompletionStatus = Convert.ToBoolean(lines[i + 4])
                        });
                    }
                    MainMenu.taskCount = lines.Length / 5;
                    MainMenu.currentlyViewedTask = -1; // Resetting the task viewer
                }
                catch (Exception myE)
                {
                    // The tasks will still often load but some will be missing.
                    MessageBox.Show("This file is not correctly formatted for this application...\n It may still be able to be opened but some or all data may be warped/lost", "Error: incorrect formatting");
                }
            }
            return tasks;
        }

        // Save to a txt file. Each line of the txt file is a different variable.
        public void saveList(object sender, EventArgs e, List<ToDoTask> tasks)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = "saved ToDo lists";
            save.Filter = "txt files (*.txt)|*.txt";
            save.DefaultExt = ".txt";

            DialogResult result = save.ShowDialog();

            if (result == DialogResult.OK)
            {
                FileStream fStream = new FileStream(save.FileName, FileMode.Create);
                StreamWriter sWriter = new StreamWriter(fStream);

                for (int i = 0; i < MainMenu.taskCount; i++)
                {
                    sWriter.WriteLine(tasks[i].taskTitle);
                    sWriter.WriteLine(tasks[i].taskDescription);
                    sWriter.WriteLine(tasks[i].taskPriority);
                    sWriter.WriteLine(tasks[i].taskFinish);
                    sWriter.WriteLine(tasks[i].taskCompletionStatus);
                }
                sWriter.Close();
            }
        }//close saveList method
    }//close OpenSaving class

    public class TaskSearch
    {
        List<ToDoTask> searchResults = new List<ToDoTask>();
        public List<ToDoTask> linearSearch(List<ToDoTask> tasks, string userSearch)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].taskDescription.Contains(userSearch) || tasks[i].taskTitle.Contains(userSearch))
                {
                    searchResults.Add(new ToDoTask() // Adding a new task to the results.
                    {
                        taskTitle = tasks[i].taskTitle,
                        taskDescription = tasks[i].taskDescription,
                        taskPriority = tasks[i].taskPriority,
                        taskFinish = tasks[i].taskFinish,
                        taskCompletionStatus = tasks[i].taskCompletionStatus
                    });
                }
                else
                    continue;
            }
            if (searchResults.Count == 0)
                MessageBox.Show("No results found.", "Search Results");
            return searchResults;
        }
    }//close class
}//close namespace
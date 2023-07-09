using TODOLIST_windform_App;




namespace TODOLIST_windform_App
{
    public partial class ToDoLsit : Form
    {
        private TodoRepository repository;
        public ToDoLsit()
        {
            InitializeComponent();
            repository = new TodoRepository();
        }




        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDueDate_Click(object sender, EventArgs e)
        {

        }

        private void existButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void todoListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {


            var item = new TodoItem();
            item.Title = titleTextBox.Text;
            item.Description = descriptionTextBox.Text;
            if (DateTime.TryParse(dueDateTextBox.Text, out var dueDate))
            {
                item.DueDate = dueDate;
            }

            repository.AddTodoItem(item);
            MessageBox.Show("Todo item added successfully.");

            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
            dueDateTextBox.Text = "";
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(todoIdTextBox.Text, out var id))
            {
                var item = repository.SearchTodoItems(null, null).FirstOrDefault(i => i.Id == id);
                if (item != null)
                {
                    item.Title = titleTextBox.Text;
                    item.Description = descriptionTextBox.Text;
                    if (DateTime.TryParse(dueDateTextBox.Text, out var dueDate))
                    {
                        item.DueDate = dueDate;
                    }

                    repository.UpdateTodoItem(item);
                    MessageBox.Show("Todo item updated successfully.");
                }
                else
                {
                    MessageBox.Show("Invalid Todo Item ID.");
                }
            }

            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
            dueDateTextBox.Text = "";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DateTime? date = null;
            if (DateTime.TryParse(searchDateTextBox.Text, out var searchDate))
            {
                date = searchDate;
            }

            var keyword = keywordTextBox.Text;
            var items = repository.SearchTodoItems(date, keyword);
            if (items.Count > 0)
            {
                string searchResults = "Search Results:\n";
                foreach (var item in items)
                {
                    searchResults += $"ID: {item.Id}\n";
                    searchResults += $"Title: {item.Title}\n";
                    searchResults += $"Description: {item.Description}\n";
                    searchResults += $"Due Date: {item.DueDate.ToShortDateString()}\n\n";
                }

                MessageBox.Show(searchResults);
            }
            else
            {
                MessageBox.Show("No items found.");
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(todoIdTextBox.Text, out var id))
            {
                repository.DeleteTodoItem(id);
                MessageBox.Show("Todo item deleted successfully.");
            }
            else
            {
                MessageBox.Show("Invalid Todo Item ID.");
            }
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchDateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void keywordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
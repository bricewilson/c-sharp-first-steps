namespace ToDoApp
{
    interface IToDoItem
    {
        string Description { get; set; }
        bool Completed { get; set; }

        void LogProgress();
    }
}
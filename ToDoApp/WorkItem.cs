using System;

namespace ToDoApp
{
    class WorkItem : IToDoItem
    {
        public WorkItem(string description)
        {
            Description = description;
        }

        public bool Completed { get; set; }
        public int Priority { get; set; }

        private string _description;
        public string Description
        {
          get
          {
            if (Priority == 1 && Completed == false)
            {
              return _description.ToUpper();
            }
            return _description;
          }
          set
          {
            _description = value;
          }
        }

        public void IncreasePriority()
        {
          if (Priority > 1)
          {
            Priority -= 1;
          }
        }

        public void DecreasePriority()
        {
          Priority += 1;
        }

    public void LogProgress()
    {
      Console.WriteLine($"Completed: {Completed}");
    }
  }
}
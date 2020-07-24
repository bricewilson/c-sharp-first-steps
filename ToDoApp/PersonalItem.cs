namespace ToDoApp
{
  class PersonalItem : IToDoItem
  {
    public string Description { get; set; }
    public bool Completed { get; set; }

    public void LogProgress()
    {
      throw new System.NotImplementedException();
    }
  }
}
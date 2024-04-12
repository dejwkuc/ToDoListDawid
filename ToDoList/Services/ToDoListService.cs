using System.Collections.Generic;
using ToDoList.DataModel;

namespace ToDoList.Services
{
    public class ToDoListService
    {
        public IEnumerable<ToDoItem> GetItems() => new[]
        {
            new ToDoItem { Description = "Orzechy" },
            new ToDoItem { Description = "Masło" },
            new ToDoItem { Description = "Kapusta" },
            new ToDoItem { Description = "Wieprzowina" },
            new ToDoItem { Description = "Kotlety" },
            new ToDoItem { Description = "Tarta" },
            new ToDoItem { Description = "Ziemniaki 5kg" },
        };
    }
}
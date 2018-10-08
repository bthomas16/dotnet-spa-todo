using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo_vue.Models
{
    public class Todo
    {
    public Guid Id { get; set; }
    public string Description { get; set; }
    public bool IsDone { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoAppV1.Models
{
    public class TodoListDto
    {
        public int Id { get; set; }
        public string Contents { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public string ImageUrl { get; set; }
        public Nullable<int> PriorityNo { get; set; }
        public int CategoriId { get; set; }
    }
}
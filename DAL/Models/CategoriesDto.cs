using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoAppV1.Models
{
    public class CategoriesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public bool IsActive { get; set; }
    }
}
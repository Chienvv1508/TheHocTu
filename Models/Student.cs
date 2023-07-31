using System;
using System.Collections.Generic;

namespace ProjectPrn211.Models
{
    public partial class Student
    {
        public Student()
        {
            Logs = new HashSet<Log>();
            Topics = new HashSet<Topic>();
        }

        public int StudentId { get; set; }
        public string StudentName { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string PassWord { get; set; } = null!;

        public virtual ICollection<Log> Logs { get; set; }
        public virtual ICollection<Topic> Topics { get; set; }
    }
}

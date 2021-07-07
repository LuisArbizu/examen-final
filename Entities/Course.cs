using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUCA.Entities
{
    public class Course
    {
        public Course(string Title, int Modules, string Topic, string Author,  string Duration, string Schedule)
        {
            this.Title = Title;
            this.Modules = Modules;
            this.Topic = Topic;
            this.Author = Author;
            this.Duration = Duration;
            this.Schedule = Schedule;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public int Modules{ get; set; }

        public string Topic { get; set; }

        public string Author { get; set; }

        public string Duration { get; set; }

        public string Schedule { get; set; }
    }
}

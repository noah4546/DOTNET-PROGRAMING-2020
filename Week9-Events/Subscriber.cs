using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9_Events
{
    class Subscriber
    {
        public string Name { get; set; }
        public NewIssueEventArgs LastIssue { get; set; }

        public Subscriber(string name)
        {
            Name = name;
            LastIssue = new NewIssueEventArgs();
        }

        public void NewIssueCallback(object sender, EventArgs e)
        {

        }

        public void NewIssueCustomCallback(object sender, NewIssueEventArgs e)
        {
            LastIssue.Name = e.Name;
            LastIssue.Time = e.Time;
        }

        public override string ToString()
        {
            return $"{Name}, {LastIssue.Name}, {LastIssue.Time}";
        }
    }
}

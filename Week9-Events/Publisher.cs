using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Week9_Events
{
    class Publisher
    {
        public string Name { get; set; }
        public event EventHandler NewIssue;
        public event EventHandler<NewIssueEventArgs> NewIssueCustomArgs;

        public Publisher(string name)
        {
            Name = name;
        }

        public void NewRelease()
        {
            NewIssueEventArgs args = new NewIssueEventArgs();
            args.Name = Name;
            args.Time = DateTime.Now;
            OnNewIssue();
            OnNewIssueCustomArgs(args);
        }

        internal static void Add(Publisher pub)
        {
            throw new NotImplementedException();
        }

        private void OnNewIssueCustomArgs(NewIssueEventArgs args)
        {
            if (NewIssueCustomArgs != null)
                NewIssueCustomArgs(this, args);
        }

        private void OnNewIssue()
        {
            if (NewIssue != null)
                NewIssue(this, EventArgs.Empty);
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class NewIssueEventArgs : EventArgs
    {
        public string Name { get; set; }
        public DateTime Time { get; set; }
    }
}

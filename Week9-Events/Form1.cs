using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Week9_Events
{
    public partial class Events : Form
    {
        private List<Subscriber> Subscribers { get; set; } = new List<Subscriber>();
        private List<Publisher> Publishers { get; set; } = new List<Publisher>();
        public Events()
        {
            InitializeComponent();
        }

        private void addPubBtn_Click(object sender, EventArgs e)
        {
            Publisher pub = new Publisher(pubTB.Text);
            Publishers.Add(pub);
            pubCLB.Items.Add(pub);
        }

        private void addSubBtn_Click(object sender, EventArgs e)
        {
            Subscriber sub = new Subscriber(subTB.Text);
            Subscribers.Add(sub);
            subLB.Items.Add(sub);
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            if (pubCLB.SelectedIndex == -1)
                return;

            Publisher pub = pubCLB.SelectedItem as Publisher;
            pub.NewRelease();

            RefreshSubscribers();
        }

        private void RefreshSubscribers()
        {
            subLB.Items.Clear();
            foreach (Subscriber sub in Subscribers)
                subLB.Items.Add(sub);
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            if (subLB.SelectedIndex == -1)
                return;

            Subscriber sub = subLB.SelectedItem as Subscriber;

            foreach (Publisher pub in pubCLB.Items)
            {
                pub.NewIssue -= sub.NewIssueCallback;
                pub.NewIssueCustomArgs -= sub.NewIssueCustomCallback;
            }

            foreach (Publisher pub in pubCLB.CheckedItems)
            {
                pub.NewIssue += sub.NewIssueCallback;
                pub.NewIssueCustomArgs += sub.NewIssueCustomCallback;
            }
        }
    }
}

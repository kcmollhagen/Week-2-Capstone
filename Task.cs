using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Task
    {
        private string memberName;
        private string description;
        private DateTime dueDate;
        private bool completed;
        public Task(string memberName, string description, DateTime dueDate, bool completed)

        {
            this.memberName = memberName;
            this.description = description;
            this.dueDate = dueDate;
            this.completed = completed;
        }
        public Task()
        {

        }

        public string GetName()
        {
            return memberName;
        }

        public void SetName (string memberName)
        {
            this.memberName = memberName;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetDescription (string description)
        {
            this.description = description;
        }

        public DateTime GetDueDate()
        {
            return dueDate;
        }

        public void SetDueDate (DateTime dueDate)
        {
            this.dueDate = dueDate;
        }

        public bool GetCompleted()
        {
            return completed;
        }

        public void SetCompleted(bool completed)
        {
            this.completed = completed;
        }
    }
}
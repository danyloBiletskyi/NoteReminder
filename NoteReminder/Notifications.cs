using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteReminder
{
    class Notifications
    {
        private string _title = "New notification";
        
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value ?? "Undefined";
            }
        }

        private string description;
        public  string Description
        {
            get { return description; }
            set
            {
                if (value != null) description = value;
            }
        }

        public DateTime? timePreference { get; set; }
        public DateTime? datePreference { get; set; }
        
        public Notifications(string title = "New notif")
        {
            Title = title;
        }
    }
}

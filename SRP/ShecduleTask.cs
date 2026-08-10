using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public class ShecduleTask
    {
        private int _taskId;
        private string _content;
        private DateTime _executeOn;

        public ShecduleTask(int taskId, String Content, DateTime ExecuteOn )
        {
            _taskId = taskId;
            _content = Content;
            _executeOn = ExecuteOn;
        }

        public int TaskId { get => _taskId; }
        public string Content { get => _content;  }
        public DateTime ExecuteOn { get => _executeOn; }
    }
}

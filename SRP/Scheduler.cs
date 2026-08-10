using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public class Scheduler : IEntryManager<ShecduleTask>
    {
        private List<ShecduleTask> _schedulesTasks;
        public Scheduler()
        {
            _schedulesTasks = new List<ShecduleTask>();
        }
        public void AddEntity(ShecduleTask entity)
        {
            _schedulesTasks.Add(entity);
        }

        public void RemoveEntryAt(int index)
        {
            _schedulesTasks.RemoveAt(index);
        }

        public override string ToString() =>
        string.Join(Environment.NewLine, _schedulesTasks.Select(x => $"Task with id: {x.TaskId} with content: {x.Content} is going to be executed on: {x.ExecuteOn}"));

    }
}

using System.Collections.Generic;

namespace Berg8.Model.DTO
{
    public class Workflow : DTOBase
    {
        public string Description { get; set; }
        public ICollection<Activity> Activities { get; set; }

        public Workflow()
        {
            this.Activities = new HashSet<Activity>();
        }
    }
}

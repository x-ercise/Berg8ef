using System.Collections.Generic;

namespace Berg8.Model.DTO
{
    public class Activity : DTOBase
    {

        public string ActivityName { get; set; }
        public ICollection<State> States { get; set; }
        public Activity()
        {
            this.States = new HashSet<State>();
        }
    }
}

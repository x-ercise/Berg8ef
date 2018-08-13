using System.Collections.Generic;

namespace Berg8.Model.DTO
{
    public class State : DTOBase
    {
        public string StateName { get; set; }
        public virtual ICollection<CommandItem> Commands { get; set; }
        public State()
        {
            this.Commands = new HashSet<CommandItem>();
        }
    }
}

using System;
using System.Collections.Generic;

namespace Berg8.Model.DTO
{
    public class Folio : DTOBase
    {
        public Workflow Workflow { get; set; }
        public Activity Activity { get; set; }
        public bool Success { get; set; }
        public string Requestor { get; set; }
        public string Deligate { get; set; }
    }
}

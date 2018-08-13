﻿using System;

namespace Berg8.Model.DTO
{
    public abstract class DTOBase
    {
        public int ID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}

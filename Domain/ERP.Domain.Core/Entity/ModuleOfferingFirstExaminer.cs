﻿namespace ERP.Domain.Core.Entity
{
    public class ModuleOfferingFirstExaminer
    {
        public int ModuleOfferingId { get; set; }
        public ModuleOffering ModuleOffering { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
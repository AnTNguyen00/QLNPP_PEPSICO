﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Serializable]
    public class PlanData
    {
        private List<PlanItem> job;

        public List<PlanItem> Job { get => job; set => job = value; }
    }
}

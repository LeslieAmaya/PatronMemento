﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronMemento.Interfaces
{
    public interface IOriginator
    {
        public void SetState(string url);
        public void Save();

    }
}

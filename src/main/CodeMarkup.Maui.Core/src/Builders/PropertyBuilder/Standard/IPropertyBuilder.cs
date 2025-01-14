﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMarkup.Maui
{
    public interface IPropertyBuilder<T>
    {
        public PropertyContext<T> Context { get; set; }
        public virtual bool Build() => false;
    }
}

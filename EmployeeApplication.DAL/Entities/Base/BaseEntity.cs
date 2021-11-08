using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApplication.DAL.Entities.Base
{
    public abstract class BaseEntity<T> 
        where T : struct
    {
        public virtual T Id { get; set; }
    }
}

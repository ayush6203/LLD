using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public partial class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
    }

    //public partial class Employee : ICloneable
    //{
    //    public object Clone()
    //    {
    //        return this.MemberwiseClone();
    //    }
    //}

    public partial class Employee : ClonablePrototype<Employee>
    {
        public Address Address { get; set; }
        public override string ToString()
        {
            return string.Format(" Name : {0}, DepartmentId : {1}, Address : {2}", this.Name, this.DepartmentId, this.Address.ToString());
        }
    }
}

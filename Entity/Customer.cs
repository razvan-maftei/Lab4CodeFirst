using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstModel.Entity
{
    using System;
    using System.Collections.Generic;
    public partial class Customer {
        public int Id { get; set; }
        public string Name { get; set; }
        public String City { get; set; }
        public List<order> Orders { get; set; }
    }
}

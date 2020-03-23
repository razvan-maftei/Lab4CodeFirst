using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstModel.Entity
{
    using System;
    using System.Collections.Generic;
    public partial class order
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public Customer Customer { get; set; }
    }
}

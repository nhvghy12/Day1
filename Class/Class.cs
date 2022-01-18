using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D1.Class
{
    class Class{
        public List<Member> list { get; private set; }
        public Class(List<Member> list)
        {
            this.list = list;
        }
    }
    
}
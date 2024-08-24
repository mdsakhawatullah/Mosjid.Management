using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosjid.Management
{
    public class MemberInfo : CommonInfo
    {
        public MemberInfo(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}

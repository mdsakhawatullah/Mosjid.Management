using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosjid.Management
{
    public class EventInfo : CommonInfo
    {
        public double Time { get; set; }
        public string TopicInfo { get; set; }
        public EventInfo(int id, string name, string topic, double time)
        {
            this.Id = id;
            this.Name = name;
            this.TopicInfo = topic;
            this.Time = time;
        }

       

    }
}

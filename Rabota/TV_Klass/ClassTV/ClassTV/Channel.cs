using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTV
{
    class Channel
    {
        int channelNumber;
        string channelName;

        public Channel(int channelNumber, string channelName)
        {
            this.channelNumber = channelNumber;
            if (channelNumber < 0) throw new ArgumentException();
            this.channelName = channelName;
        }

        public int GetChannelNumber
        {
            get
            {
                return channelNumber;
            }
        }

        public string GetChannelName
        {
            get
            {
                return channelName;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTV
{
    class TV
    {
        private int currentChannel = 0;
        private List<Channel> channelsList = new List<Channel>();

        public TV()
        {
            for (int i = 0; i < 5; i++)
            {
                Channel chnl = new Channel(i, "Канал");
                channelsList.Add(chnl);
            }
        }

        public void SwitchChannelUp()
        {
            if (currentChannel == channelsList.Count - 1)
            {
                currentChannel = 0;
            }
            else
                currentChannel++;
        }
        public void SwitchChannelDown()
        {
            if (currentChannel == 0)
            {
                currentChannel = channelsList.Count - 1;
            }
            else
                currentChannel--;
        }
        public void ShowCurrentChannel()
        {
            Console.WriteLine(channelsList[currentChannel].GetChannelNumber);
            Console.WriteLine(channelsList[currentChannel].GetChannelName);
        }
    }
}

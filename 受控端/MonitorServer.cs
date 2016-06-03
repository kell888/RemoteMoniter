using System;
using System.Runtime.Remoting;
using System.IO;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace 远程监控
{
    class MonitorServer
    {
        static void Main(string[] args)
        {
            TcpServerChannel channel = new TcpServerChannel(9000);
            ChannelServices.RegisterChannel(channel,false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Monitor), "MonitorServerUrl", WellKnownObjectMode.SingleCall);
            Console.ReadLine(); 
        }
    }
}

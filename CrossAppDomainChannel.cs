internal class CrossAppDomainChannel : IChannel, IChannelSender, IChannelReceiver // TypeDefIndex: 1189
{
	private static object s_lock; 

public virtual string ChannelName { get; }
public virtual int ChannelPriority { get; }
public virtual object ChannelData { get; }


internal static void RegisterCrossAppDomainChannel() { }

public virtual string get_ChannelName() { }

public virtual int get_ChannelPriority() { }

public virtual object get_ChannelData() { }

public virtual void StartListening(object data) { }

public virtual IMessageSink CreateMessageSink(string url, object data, out string uri) { }

public void .ctor() { }

private static void .cctor() { }

}


internal class CrossContextChannel : IMessageSink // TypeDefIndex: 1175
{

public IMessage SyncProcessMessage(IMessage msg) { }

public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

public void .ctor() { }

}

private class CrossContextChannel.ContextRestoreSink : IMessageSink // TypeDefIndex: 1176
{
	private IMessageSink _next; 
	private Context _context; 
	private IMessage _call; 


public void .ctor(IMessageSink next, Context context, IMessage call) { }

public IMessage SyncProcessMessage(IMessage msg) { }

public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}


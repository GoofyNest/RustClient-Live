internal class CrossContextChannel : IMessageSink // TypeDefIndex: 1175
{
	public IMessage SyncProcessMessage(IMessage msg) { }

	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	public void .ctor() { }

}

private class CrossContextChannel.ContextRestoreSink : IMessageSink // TypeDefIndex: 1176
{	private IMessageSink _next; // 0x10
	private Context _context; // 0x18
	private IMessage _call; // 0x20


	public void .ctor(IMessageSink next, Context context, IMessage call) { }

	public IMessage SyncProcessMessage(IMessage msg) { }

	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}


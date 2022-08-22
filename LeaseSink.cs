internal class LeaseSink : IMessageSink // TypeDefIndex: 1168
{	private IMessageSink _nextSink; // 0x10


	public void .ctor(IMessageSink nextSink) { }

	public IMessage SyncProcessMessage(IMessage msg) { }

	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	private void RenewLease(IMessage msg) { }

}


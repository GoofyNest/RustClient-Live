internal class DisposerReplySink : IMessageSink // TypeDefIndex: 1149
{	private IMessageSink _next; // 0x10
	private IDisposable _disposable; // 0x18


	public void .ctor(IMessageSink next, IDisposable disposable) { }

	public IMessage SyncProcessMessage(IMessage msg) { }

	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}


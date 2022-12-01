internal class DisposerReplySink : IMessageSink // TypeDefIndex: 1149
{
	private IMessageSink _next;
	private IDisposable _disposable;


	public void .ctor(IMessageSink next, IDisposable disposable) { }

	public IMessage SyncProcessMessage(IMessage msg) { }

	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}


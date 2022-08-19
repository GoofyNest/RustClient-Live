internal class DisposerReplySink : IMessageSink // TypeDefIndex: 1149
{	// Fields
	private IMessageSink _next; // 0x10
	private IDisposable _disposable; // 0x18

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	public void .ctor(IMessageSink next, IDisposable disposable) { }

	// RVA: 0x1471750 Offset: 0x1470B50 VA: 0x181471750 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1471700 Offset: 0x1470B00 VA: 0x181471700 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}


internal class LeaseSink : IMessageSink // TypeDefIndex: 1168
{	// Fields
	private IMessageSink _nextSink; // 0x10

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	public void .ctor(IMessageSink nextSink) { }

	// RVA: 0x1473EE0 Offset: 0x14732E0 VA: 0x181473EE0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1473C60 Offset: 0x1473060 VA: 0x181473C60 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x1473CE0 Offset: 0x14730E0 VA: 0x181473CE0
	private void RenewLease(IMessage msg) { }

}


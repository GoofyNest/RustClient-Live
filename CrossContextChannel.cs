internal class CrossContextChannel : IMessageSink // TypeDefIndex: 1175
{	// Methods

	// RVA: 0x1470F20 Offset: 0x1470320 VA: 0x181470F20 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1470AE0 Offset: 0x146FEE0 VA: 0x181470AE0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private class CrossContextChannel.ContextRestoreSink : IMessageSink // TypeDefIndex: 1176
{	// Fields
	private IMessageSink _next; // 0x10
	private Context _context; // 0x18
	private IMessage _call; // 0x20

	// Methods

	// RVA: 0x146E710 Offset: 0x146DB10 VA: 0x18146E710
	public void .ctor(IMessageSink next, Context context, IMessage call) { }

	// RVA: 0x146E4E0 Offset: 0x146D8E0 VA: 0x18146E4E0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x146E490 Offset: 0x146D890 VA: 0x18146E490 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}


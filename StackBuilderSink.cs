internal class StackBuilderSink : IMessageSink // TypeDefIndex: 1262
{	// Fields
	private MarshalByRefObject _target; // 0x10
	private RealProxy _rp; // 0x18

	// Methods

	// RVA: 0x1488F00 Offset: 0x1488300 VA: 0x181488F00
	public void .ctor(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x1488DD0 Offset: 0x14881D0 VA: 0x181488DD0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x14883C0 Offset: 0x14877C0 VA: 0x1814883C0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x1488890 Offset: 0x1487C90 VA: 0x181488890
	private void ExecuteAsyncMessage(object ob) { }

	// RVA: 0x1488510 Offset: 0x1487910 VA: 0x181488510
	private void CheckParameters(IMessage msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1488EA0 Offset: 0x14882A0 VA: 0x181488EA0
	private void <AsyncProcessMessage>b__4_0(object data) { }

}


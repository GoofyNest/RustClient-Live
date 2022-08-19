internal class CrossAppDomainSink : IMessageSink // TypeDefIndex: 1190
{	// Fields
	private static Hashtable s_sinks; // 0x0
	private static MethodInfo processMessageMethod; // 0x8
	private int _domainID; // 0x10

	// Properties
	internal int TargetDomainId { get; }

	// Methods

	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	internal void .ctor(int domainID) { }

	// RVA: 0xFE0140 Offset: 0xFDF540 VA: 0x180FE0140
	internal static CrossAppDomainSink GetSink(int domainID) { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	internal int get_TargetDomainId() { }

	// RVA: 0xFE0440 Offset: 0xFDF840 VA: 0x180FE0440
	private static CrossAppDomainSink.ProcessMessageRes ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg) { }

	// RVA: 0xFE0620 Offset: 0xFDFA20 VA: 0x180FE0620 Slot: 6
	public virtual IMessage SyncProcessMessage(IMessage msgRequest) { }

	// RVA: 0xFE0080 Offset: 0xFDF480 VA: 0x180FE0080 Slot: 7
	public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink) { }

	// RVA: 0xFE0560 Offset: 0xFDF960 VA: 0x180FE0560
	public void SendAsyncMessage(object data) { }

	// RVA: 0xFE0A80 Offset: 0xFDFE80 VA: 0x180FE0A80
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFE0980 Offset: 0xFDFD80 VA: 0x180FE0980
	private void <AsyncProcessMessage>b__10_0(object data) { }

}

private struct CrossAppDomainSink.ProcessMessageRes // TypeDefIndex: 1191
{	// Fields
	public byte[] arrResponse; // 0x0
	public CADMethodReturnMessage cadMrm; // 0x8

}


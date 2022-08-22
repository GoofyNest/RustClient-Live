internal class CrossAppDomainSink : IMessageSink // TypeDefIndex: 1190
{	private static Hashtable s_sinks; // 0x0
	private static MethodInfo processMessageMethod; // 0x8
	private int _domainID; // 0x10

	internal int TargetDomainId { get; }


	internal void .ctor(int domainID) { }

	internal static CrossAppDomainSink GetSink(int domainID) { }

	internal int get_TargetDomainId() { }

	private static CrossAppDomainSink.ProcessMessageRes ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg) { }

	public virtual IMessage SyncProcessMessage(IMessage msgRequest) { }

	public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink) { }

	public void SendAsyncMessage(object data) { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <AsyncProcessMessage>b__10_0(object data) { }

}

private struct CrossAppDomainSink.ProcessMessageRes // TypeDefIndex: 1191
{	public byte[] arrResponse; // 0x0
	public CADMethodReturnMessage cadMrm; // 0x8

}


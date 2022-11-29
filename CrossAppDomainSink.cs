internal class CrossAppDomainSink : IMessageSink // TypeDefIndex: 1190
{
	private static Hashtable s_sinks; 
	private static MethodInfo processMessageMethod; 
	private int _domainID; 

	internal int TargetDomainId { get; }


	internal void .ctor(int domainID) { }

	internal static CrossAppDomainSink GetSink(int domainID) { }

	internal int get_TargetDomainId() { }

	private static CrossAppDomainSink.ProcessMessageRes ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg) { }

	public virtual IMessage SyncProcessMessage(IMessage msgRequest) { }

	public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink) { }

	public void SendAsyncMessage(object data) { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] 
	private void <AsyncProcessMessage>

}

private struct CrossAppDomainSink.ProcessMessageRes // TypeDefIndex: 1191
{
	public byte[] arrResponse; 
	public CADMethodReturnMessage cadMrm; 

}


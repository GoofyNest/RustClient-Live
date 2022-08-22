public sealed class LogicalCallContext : ISerializable, ICloneable // TypeDefIndex: 1217
{	private static Type s_callContextType; // 0x0
	private const string s_CorrelationMgrSlotName = "System.Diagnostics.Trace.CorrelationManagerSlot";
	private Hashtable m_Datastore; // 0x10
	private CallContextRemotingData m_RemotingData; // 0x18
	private CallContextSecurityData m_SecurityData; // 0x20
	private object m_HostContext; // 0x28
	private bool m_IsCorrelationMgr; // 0x30
	private Header[] _sendHeaders; // 0x38
	private Header[] _recvHeaders; // 0x40

	public bool HasInfo { get; }
	private bool HasUserData { get; }
	private Hashtable Datastore { get; }


	internal void .ctor() { }

	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public object Clone() { }

	internal void Merge(LogicalCallContext lc) { }

	public bool get_HasInfo() { }

	private bool get_HasUserData() { }

	private Hashtable get_Datastore() { }

	public object GetData(string name) { }

	public void SetData(string name, object data) { }

	private static void .cctor() { }

}

internal struct LogicalCallContext.Reader // TypeDefIndex: 1218
{	private LogicalCallContext m_ctx; // 0x0

	public bool IsNull { get; }
	public bool HasInfo { get; }


	public void .ctor(LogicalCallContext ctx) { }

	public bool get_IsNull() { }

	public bool get_HasInfo() { }

	public LogicalCallContext Clone() { }

	public object GetData(string name) { }

}


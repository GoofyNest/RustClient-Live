public sealed class LogicalCallContext : ISerializable, ICloneable // TypeDefIndex: 1217
{
	private static Type s_callContextType; 
private const string s_CorrelationMgrSlotName = "System.Diagnostics.Trace.CorrelationManagerSlot";
	private Hashtable m_Datastore; 
	private CallContextRemotingData m_RemotingData; 
	private CallContextSecurityData m_SecurityData; 
	private object m_HostContext; 
	private bool m_IsCorrelationMgr; 
	private Header[] _sendHeaders; 
	private Header[] _recvHeaders; 

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
{
	private LogicalCallContext m_ctx; 

public bool IsNull { get; }
public bool HasInfo { get; }


public void .ctor(LogicalCallContext ctx) { }

public bool get_IsNull() { }

public bool get_HasInfo() { }

public LogicalCallContext Clone() { }

public object GetData(string name) { }

}


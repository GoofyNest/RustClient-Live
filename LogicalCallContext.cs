public sealed class LogicalCallContext : ISerializable, ICloneable // TypeDefIndex: 1217
{	// Fields
	private static Type s_callContextType; // 0x0
	private const string s_CorrelationMgrSlotName = "System.Diagnostics.Trace.CorrelationManagerSlot";
	private Hashtable m_Datastore; // 0x10
	private CallContextRemotingData m_RemotingData; // 0x18
	private CallContextSecurityData m_SecurityData; // 0x20
	private object m_HostContext; // 0x28
	private bool m_IsCorrelationMgr; // 0x30
	private Header[] _sendHeaders; // 0x38
	private Header[] _recvHeaders; // 0x40

	// Properties
	public bool HasInfo { get; }
	private bool HasUserData { get; }
	private Hashtable Datastore { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x1476030 Offset: 0x1475430 VA: 0x181476030
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14758C0 Offset: 0x1474CC0 VA: 0x1814758C0 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1475180 Offset: 0x1474580 VA: 0x181475180 Slot: 5
	public object Clone() { }

	// RVA: 0x1475C00 Offset: 0x1475000 VA: 0x181475C00
	internal void Merge(LogicalCallContext lc) { }

	// RVA: 0x14763B0 Offset: 0x14757B0 VA: 0x1814763B0
	public bool get_HasInfo() { }

	// RVA: 0x1472EA0 Offset: 0x14722A0 VA: 0x181472EA0
	private bool get_HasUserData() { }

	// RVA: 0x1476340 Offset: 0x1475740 VA: 0x181476340
	private Hashtable get_Datastore() { }

	// RVA: 0x1475820 Offset: 0x1474C20 VA: 0x181475820
	public object GetData(string name) { }

	// RVA: 0x1475ED0 Offset: 0x14752D0 VA: 0x181475ED0
	public void SetData(string name, object data) { }

	// RVA: 0x1475FC0 Offset: 0x14753C0 VA: 0x181475FC0
	private static void .cctor() { }

}

internal struct LogicalCallContext.Reader // TypeDefIndex: 1218
{	// Fields
	private LogicalCallContext m_ctx; // 0x0

	// Properties
	public bool IsNull { get; }
	public bool HasInfo { get; }

	// Methods

	// RVA: 0xF1380 Offset: 0xF0780 VA: 0x1800F1380
	public void .ctor(LogicalCallContext ctx) { }

	// RVA: 0x1186B0 Offset: 0x117AB0 VA: 0x1801186B0
	public bool get_IsNull() { }

	// RVA: 0x1EFC60 Offset: 0x1EF060 VA: 0x1801EFC60
	public bool get_HasInfo() { }

	// RVA: 0x1EFBE0 Offset: 0x1EEFE0 VA: 0x1801EFBE0
	public LogicalCallContext Clone() { }

	// RVA: 0x1EFC50 Offset: 0x1EF050 VA: 0x1801EFC50
	public object GetData(string name) { }

}


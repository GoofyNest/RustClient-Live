internal class IllogicalCallContext // TypeDefIndex: 1216
{	private Hashtable m_Datastore; // 0x10
	private object m_HostContext; // 0x18

	private Hashtable Datastore { get; }
	internal object HostContext { get; set; }
	internal bool HasUserData { get; }


	private Hashtable get_Datastore() { }

	internal object get_HostContext() { }

	internal void set_HostContext(object value) { }

	internal bool get_HasUserData() { }

	public void FreeNamedDataSlot(string name) { }

	public IllogicalCallContext CreateCopy() { }

	public void .ctor() { }

}


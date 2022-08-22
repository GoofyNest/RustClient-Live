internal class InvokableCallList // TypeDefIndex: 3637
{	private readonly List<BaseInvokableCall> m_PersistentCalls; // 0x10
	private readonly List<BaseInvokableCall> m_RuntimeCalls; // 0x18
	private readonly List<BaseInvokableCall> m_ExecutingCalls; // 0x20
	private bool m_NeedsUpdate; // 0x28


	public void AddPersistentInvokableCall(BaseInvokableCall call) { }

	public void AddListener(BaseInvokableCall call) { }

	public void RemoveListener(object targetObj, MethodInfo method) { }

	public void Clear() { }

	public void ClearPersistent() { }

	public List<BaseInvokableCall> PrepareInvoke() { }

	public void .ctor() { }

}


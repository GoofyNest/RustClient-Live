internal class InvokableCallList // TypeDefIndex: 3637
{	// Fields
	private readonly List<BaseInvokableCall> m_PersistentCalls; // 0x10
	private readonly List<BaseInvokableCall> m_RuntimeCalls; // 0x18
	private readonly List<BaseInvokableCall> m_ExecutingCalls; // 0x20
	private bool m_NeedsUpdate; // 0x28

	// Methods

	// RVA: 0x182AC20 Offset: 0x182A020 VA: 0x18182AC20
	public void AddPersistentInvokableCall(BaseInvokableCall call) { }

	// RVA: 0x182ABC0 Offset: 0x1829FC0 VA: 0x18182ABC0
	public void AddListener(BaseInvokableCall call) { }

	// RVA: 0x182ADB0 Offset: 0x182A1B0 VA: 0x18182ADB0
	public void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x182ACD0 Offset: 0x182A0D0 VA: 0x18182ACD0
	public void Clear() { }

	// RVA: 0x182AC80 Offset: 0x182A080 VA: 0x18182AC80
	public void ClearPersistent() { }

	// RVA: 0x182AD20 Offset: 0x182A120 VA: 0x18182AD20
	public List<BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x182AF30 Offset: 0x182A330 VA: 0x18182AF30
	public void .ctor() { }

}


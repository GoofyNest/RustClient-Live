public abstract class UnityEventBase : ISerializationCallbackReceiver // TypeDefIndex: 3638
{	// Fields
	private InvokableCallList m_Calls; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0xE09D0 Offset: 0xDFDD0 VA: 0x1800E09D0
	[SerializeField] // RVA: 0xE09D0 Offset: 0xDFDD0 VA: 0x1800E09D0
	private PersistentCallGroup m_PersistentCalls; // 0x18
	private bool m_CallsDirty; // 0x20

	// Methods

	// RVA: 0x182EE60 Offset: 0x182E260 VA: 0x18182EE60
	protected void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x182E350 Offset: 0x182D750 VA: 0x18182E350 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract MethodInfo FindMethod_Impl(string name, object targetObj);

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction);

	// RVA: 0x182E3B0 Offset: 0x182D7B0 VA: 0x18182E3B0
	internal MethodInfo FindMethod(PersistentCall call) { }

	// RVA: 0x182E520 Offset: 0x182D920 VA: 0x18182E520
	internal MethodInfo FindMethod(string name, object listener, PersistentListenerMode mode, Type argumentType) { }

	// RVA: 0x182E350 Offset: 0x182D750 VA: 0x18182E350
	private void DirtyPersistentCalls() { }

	// RVA: 0x182EBC0 Offset: 0x182DFC0 VA: 0x18182EBC0
	private void RebuildPersistentCallsIfNeeded() { }

	// RVA: 0x182E2F0 Offset: 0x182D6F0 VA: 0x18182E2F0
	internal void AddCall(BaseInvokableCall call) { }

	// RVA: 0x182EC50 Offset: 0x182E050 VA: 0x18182EC50
	protected void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x182EC00 Offset: 0x182E000 VA: 0x18182EC00
	public void RemoveAllListeners() { }

	// RVA: 0x182EB00 Offset: 0x182DF00 VA: 0x18182EB00
	internal List<BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x182EDE0 Offset: 0x182E1E0 VA: 0x18182EDE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x182E920 Offset: 0x182DD20 VA: 0x18182E920
	public static MethodInfo GetValidMethodInfo(object obj, string functionName, Type[] argumentTypes) { }

}


public abstract class UnityEventBase : ISerializationCallbackReceiver // TypeDefIndex: 3638
{	private InvokableCallList m_Calls; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0xE09D0 Offset: 0xDFDD0 VA: 0x1800E09D0
	[SerializeField] // RVA: 0xE09D0 Offset: 0xDFDD0 VA: 0x1800E09D0
	private PersistentCallGroup m_PersistentCalls; // 0x18
	private bool m_CallsDirty; // 0x20


	protected void .ctor() { }

	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	protected abstract MethodInfo FindMethod_Impl(string name, object targetObj);

	internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction);

	internal MethodInfo FindMethod(PersistentCall call) { }

	internal MethodInfo FindMethod(string name, object listener, PersistentListenerMode mode, Type argumentType) { }

	private void DirtyPersistentCalls() { }

	private void RebuildPersistentCallsIfNeeded() { }

	internal void AddCall(BaseInvokableCall call) { }

	protected void RemoveListener(object targetObj, MethodInfo method) { }

	public void RemoveAllListeners() { }

	internal List<BaseInvokableCall> PrepareInvoke() { }

	public override string ToString() { }

	public static MethodInfo GetValidMethodInfo(object obj, string functionName, Type[] argumentTypes) { }

}


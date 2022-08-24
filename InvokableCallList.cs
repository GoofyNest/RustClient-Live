internal class InvokableCallList // TypeDefIndex: 3637
{
	private readonly List<BaseInvokableCall> m_PersistentCalls; 
	private readonly List<BaseInvokableCall> m_RuntimeCalls; 
	private readonly List<BaseInvokableCall> m_ExecutingCalls; 
	private bool m_NeedsUpdate; 


public void AddPersistentInvokableCall(BaseInvokableCall call) { }

public void AddListener(BaseInvokableCall call) { }

public void RemoveListener(object targetObj, MethodInfo method) { }

public void Clear() { }

public void ClearPersistent() { }

public List<BaseInvokableCall> PrepareInvoke() { }

public void .ctor() { }

}


public class UnityEvent : UnityEventBase // TypeDefIndex: 3642
{
	private object[] m_InvokeArray; 


	[RequiredByNativeCodeAttribute] 
	public void .ctor() { }

	public void AddListener(UnityAction call) { }

	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }

	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	private static BaseInvokableCall GetDelegate(UnityAction action) { }

	public void Invoke() { }

}


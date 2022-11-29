internal class PersistentCall // TypeDefIndex: 3638
{
	[SerializeField] 
	[FormerlySerializedAsAttribute] 
	private Object m_Target; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private string m_MethodName; 
	[SerializeField] 
	[FormerlySerializedAsAttribute] 
	private PersistentListenerMode m_Mode; 
	[SerializeField] 
	[FormerlySerializedAsAttribute] 
	private ArgumentCache m_Arguments; 
	[FormerlySerializedAsAttribute] 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private UnityEventCallState m_CallState; 

	public Object target { get; }
	public string methodName { get; }
	public PersistentListenerMode mode { get; }
	public ArgumentCache arguments { get; }


	public Object get_target() { }

	public string get_methodName() { }

	public PersistentListenerMode get_mode() { }

	public ArgumentCache get_arguments() { }

	public bool IsValid() { }

	public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) { }

	private static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments) { }

	public void .ctor() { }

}


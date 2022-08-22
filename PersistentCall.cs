internal class PersistentCall // TypeDefIndex: 3635
{	[SerializeField] // RVA: 0xDFED0 Offset: 0xDF2D0 VA: 0x1800DFED0
	[FormerlySerializedAsAttribute] // RVA: 0xDFED0 Offset: 0xDF2D0 VA: 0x1800DFED0
	private Object m_Target; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0xE00B0 Offset: 0xDF4B0 VA: 0x1800E00B0
	[SerializeField] // RVA: 0xE00B0 Offset: 0xDF4B0 VA: 0x1800E00B0
	private string m_MethodName; // 0x18
	[SerializeField] // RVA: 0xE0190 Offset: 0xDF590 VA: 0x1800E0190
	[FormerlySerializedAsAttribute] // RVA: 0xE0190 Offset: 0xDF590 VA: 0x1800E0190
	private PersistentListenerMode m_Mode; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xE0300 Offset: 0xDF700 VA: 0x1800E0300
	[SerializeField] // RVA: 0xE0300 Offset: 0xDF700 VA: 0x1800E0300
	private ArgumentCache m_Arguments; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0xE0400 Offset: 0xDF800 VA: 0x1800E0400
	[SerializeField] // RVA: 0xE0400 Offset: 0xDF800 VA: 0x1800E0400
	[FormerlySerializedAsAttribute] // RVA: 0xE0400 Offset: 0xDF800 VA: 0x1800E0400
	private UnityEventCallState m_CallState; // 0x30

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


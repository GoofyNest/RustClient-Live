internal class PersistentCall // TypeDefIndex: 3635
{	// Fields
	[SerializeField] // RVA: 0xDFED0 Offset: 0xDF2D0 VA: 0x1800DFED0
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

	// Properties
	public Object target { get; }
	public string methodName { get; }
	public PersistentListenerMode mode { get; }
	public ArgumentCache arguments { get; }

	// Methods

	// RVA: 0x1818780 Offset: 0x1817B80 VA: 0x181818780
	public Object get_target() { }

	// RVA: 0x1818770 Offset: 0x1817B70 VA: 0x181818770
	public string get_methodName() { }

	// RVA: 0x1818750 Offset: 0x1817B50 VA: 0x181818750
	public PersistentListenerMode get_mode() { }

	// RVA: 0x1818760 Offset: 0x1817B60 VA: 0x181818760
	public ArgumentCache get_arguments() { }

	// RVA: 0x182D5F0 Offset: 0x182C9F0 VA: 0x18182D5F0
	public bool IsValid() { }

	// RVA: 0x182D290 Offset: 0x182C690 VA: 0x18182D290
	public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) { }

	// RVA: 0x182CD40 Offset: 0x182C140 VA: 0x18182CD40
	private static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments) { }

	// RVA: 0x182D680 Offset: 0x182CA80 VA: 0x18182D680
	public void .ctor() { }

}


public class UnityEvent : UnityEventBase // TypeDefIndex: 3640
{	// Fields
	private object[] m_InvokeArray; // 0x28

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x182F430 Offset: 0x182E830 VA: 0x18182F430
	public void .ctor() { }

	// RVA: 0x182EFF0 Offset: 0x182E3F0 VA: 0x18182EFF0
	public void AddListener(UnityAction call) { }

	// RVA: 0x182F0A0 Offset: 0x182E4A0 VA: 0x18182F0A0 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }

	// RVA: 0x182F100 Offset: 0x182E500 VA: 0x18182F100 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x182F170 Offset: 0x182E570 VA: 0x18182F170
	private static BaseInvokableCall GetDelegate(UnityAction action) { }

	// RVA: 0x182F1D0 Offset: 0x182E5D0 VA: 0x18182F1D0
	public void Invoke() { }

}


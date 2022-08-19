public class TouchInputModule : PointerInputModule // TypeDefIndex: 5087
{	// Fields
	private Vector2 m_LastMousePosition; // 0x58
	private Vector2 m_MousePosition; // 0x60
	private PointerEventData m_InputPointerEvent; // 0x68
	[SerializeField] // RVA: 0x88F50 Offset: 0x88350 VA: 0x180088F50
	[FormerlySerializedAsAttribute] // RVA: 0x88F50 Offset: 0x88350 VA: 0x180088F50
	private bool m_ForceModuleActive; // 0x70

	// Properties
	[ObsoleteAttribute] // RVA: 0x89010 Offset: 0x88410 VA: 0x180089010
	public bool allowActivationOnStandalone { get; set; }
	public bool forceModuleActive { get; set; }

	// Methods

	// RVA: 0x10C9A90 Offset: 0x10C8E90 VA: 0x1810C9A90
	protected void .ctor() { }

	// RVA: 0xC2CA80 Offset: 0xC2BE80 VA: 0x180C2CA80
	public bool get_allowActivationOnStandalone() { }

	// RVA: 0xC2DBA0 Offset: 0xC2CFA0 VA: 0x180C2DBA0
	public void set_allowActivationOnStandalone(bool value) { }

	// RVA: 0xC2CA80 Offset: 0xC2BE80 VA: 0x180C2CA80
	public bool get_forceModuleActive() { }

	// RVA: 0xC2DBA0 Offset: 0xC2CFA0 VA: 0x180C2DBA0
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x10C98F0 Offset: 0x10C8CF0 VA: 0x1810C98F0 Slot: 24
	public override void UpdateModule() { }

	// RVA: 0x10C84C0 Offset: 0x10C78C0 VA: 0x1810C84C0 Slot: 25
	public override bool IsModuleSupported() { }

	// RVA: 0x10C94F0 Offset: 0x10C88F0 VA: 0x1810C94F0 Slot: 21
	public override bool ShouldActivateModule() { }

	// RVA: 0x10C9A50 Offset: 0x10C8E50 VA: 0x1810C9A50
	private bool UseFakeInput() { }

	// RVA: 0x10C94A0 Offset: 0x10C88A0 VA: 0x1810C94A0 Slot: 17
	public override void Process() { }

	// RVA: 0x10C8340 Offset: 0x10C7740 VA: 0x1810C8340
	private void FakeTouches() { }

	// RVA: 0x10C8500 Offset: 0x10C7900 VA: 0x1810C8500
	private void ProcessTouchEvents() { }

	// RVA: 0x10C8D90 Offset: 0x10C8190 VA: 0x1810C8D90
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x10C5840 Offset: 0x10C4C40 VA: 0x1810C5840 Slot: 22
	public override void DeactivateModule() { }

	// RVA: 0x10C9680 Offset: 0x10C8A80 VA: 0x1810C9680 Slot: 3
	public override string ToString() { }

}


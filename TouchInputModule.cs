public class TouchInputModule : PointerInputModule // TypeDefIndex: 5087
{	private Vector2 m_LastMousePosition; // 0x58
	private Vector2 m_MousePosition; // 0x60
	private PointerEventData m_InputPointerEvent; // 0x68
	[SerializeField] // RVA: 0x88F50 Offset: 0x88350 VA: 0x180088F50
	[FormerlySerializedAsAttribute] // RVA: 0x88F50 Offset: 0x88350 VA: 0x180088F50
	private bool m_ForceModuleActive; // 0x70

	[ObsoleteAttribute] // RVA: 0x89010 Offset: 0x88410 VA: 0x180089010
	public bool allowActivationOnStandalone { get; set; }
	public bool forceModuleActive { get; set; }


	protected void .ctor() { }

	public bool get_allowActivationOnStandalone() { }

	public void set_allowActivationOnStandalone(bool value) { }

	public bool get_forceModuleActive() { }

	public void set_forceModuleActive(bool value) { }

	public override void UpdateModule() { }

	public override bool IsModuleSupported() { }

	public override bool ShouldActivateModule() { }

	private bool UseFakeInput() { }

	public override void Process() { }

	private void FakeTouches() { }

	private void ProcessTouchEvents() { }

	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	public override void DeactivateModule() { }

	public override string ToString() { }

}


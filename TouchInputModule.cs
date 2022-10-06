public class TouchInputModule : PointerInputModule // TypeDefIndex: 5091
{
	private Vector2 m_LastMousePosition; 
	private Vector2 m_MousePosition; 
	private PointerEventData m_InputPointerEvent; 
	[SerializeField] 
	[FormerlySerializedAsAttribute] 
	private bool m_ForceModuleActive; 

	[ObsoleteAttribute] 
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


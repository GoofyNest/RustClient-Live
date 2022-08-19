public class StandaloneInputModule : PointerInputModule // TypeDefIndex: 5085
{	// Fields
	private float m_PrevActionTime; // 0x58
	private Vector2 m_LastMoveVector; // 0x5C
	private int m_ConsecutiveMoveCount; // 0x64
	private Vector2 m_LastMousePosition; // 0x68
	private Vector2 m_MousePosition; // 0x70
	private GameObject m_CurrentFocusedGameObject; // 0x78
	private PointerEventData m_InputPointerEvent; // 0x80
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string m_HorizontalAxis; // 0x88
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string m_VerticalAxis; // 0x90
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string m_SubmitButton; // 0x98
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string m_CancelButton; // 0xA0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_InputActionsPerSecond; // 0xA8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_RepeatDelay; // 0xAC
	[SerializeField] // RVA: 0x88420 Offset: 0x87820 VA: 0x180088420
	[FormerlySerializedAsAttribute] // RVA: 0x88420 Offset: 0x87820 VA: 0x180088420
	private bool m_ForceModuleActive; // 0xB0

	// Properties
	[ObsoleteAttribute] // RVA: 0x88780 Offset: 0x87B80 VA: 0x180088780
	public StandaloneInputModule.InputMode inputMode { get; }
	[ObsoleteAttribute] // RVA: 0x888D0 Offset: 0x87CD0 VA: 0x1800888D0
	public bool allowActivationOnMobileDevice { get; set; }
	public bool forceModuleActive { get; set; }
	public float inputActionsPerSecond { get; set; }
	public float repeatDelay { get; set; }
	public string horizontalAxis { get; set; }
	public string verticalAxis { get; set; }
	public string submitButton { get; set; }
	public string cancelButton { get; set; }

	// Methods

	// RVA: 0x10C8250 Offset: 0x10C7650 VA: 0x1810C8250
	protected void .ctor() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80
	public StandaloneInputModule.InputMode get_inputMode() { }

	// RVA: 0x10C82F0 Offset: 0x10C76F0 VA: 0x1810C82F0
	public bool get_allowActivationOnMobileDevice() { }

	// RVA: 0x10C8320 Offset: 0x10C7720 VA: 0x1810C8320
	public void set_allowActivationOnMobileDevice(bool value) { }

	// RVA: 0x10C82F0 Offset: 0x10C76F0 VA: 0x1810C82F0
	public bool get_forceModuleActive() { }

	// RVA: 0x10C8320 Offset: 0x10C7720 VA: 0x1810C8320
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x10C8300 Offset: 0x10C7700 VA: 0x1810C8300
	public float get_inputActionsPerSecond() { }

	// RVA: 0xC1B2A0 Offset: 0xC1A6A0 VA: 0x180C1B2A0
	public void set_inputActionsPerSecond(float value) { }

	// RVA: 0x10C8310 Offset: 0x10C7710 VA: 0x1810C8310
	public float get_repeatDelay() { }

	// RVA: 0x10C8330 Offset: 0x10C7730 VA: 0x1810C8330
	public void set_repeatDelay(float value) { }

	// RVA: 0x58DBD0 Offset: 0x58CFD0 VA: 0x18058DBD0
	public string get_horizontalAxis() { }

	// RVA: 0x58DC60 Offset: 0x58D060 VA: 0x18058DC60
	public void set_horizontalAxis(string value) { }

	// RVA: 0x4E09F0 Offset: 0x4DFDF0 VA: 0x1804E09F0
	public string get_verticalAxis() { }

	// RVA: 0x4E0A00 Offset: 0x4DFE00 VA: 0x1804E0A00
	public void set_verticalAxis(string value) { }

	// RVA: 0x58DBE0 Offset: 0x58CFE0 VA: 0x18058DBE0
	public string get_submitButton() { }

	// RVA: 0x58DC70 Offset: 0x58D070 VA: 0x18058DC70
	public void set_submitButton(string value) { }

	// RVA: 0x58DBC0 Offset: 0x58CFC0 VA: 0x18058DBC0
	public string get_cancelButton() { }

	// RVA: 0x58DC50 Offset: 0x58D050 VA: 0x18058DC50
	public void set_cancelButton(string value) { }

	// RVA: 0x10C80C0 Offset: 0x10C74C0 VA: 0x1810C80C0
	private bool ShouldIgnoreEventsOnNoFocus() { }

	// RVA: 0x10C80E0 Offset: 0x10C74E0 VA: 0x1810C80E0 Slot: 24
	public override void UpdateModule() { }

	// RVA: 0x10C72F0 Offset: 0x10C66F0 VA: 0x1810C72F0
	private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo) { }

	// RVA: 0x10C59E0 Offset: 0x10C4DE0 VA: 0x1810C59E0 Slot: 25
	public override bool IsModuleSupported() { }

	// RVA: 0x10C7E10 Offset: 0x10C7210 VA: 0x1810C7E10 Slot: 21
	public override bool ShouldActivateModule() { }

	// RVA: 0x10C56D0 Offset: 0x10C4AD0 VA: 0x1810C56D0 Slot: 23
	public override void ActivateModule() { }

	// RVA: 0x10C5840 Offset: 0x10C4C40 VA: 0x1810C5840 Slot: 22
	public override void DeactivateModule() { }

	// RVA: 0x10C70F0 Offset: 0x10C64F0 VA: 0x1810C70F0 Slot: 17
	public override void Process() { }

	// RVA: 0x10C6120 Offset: 0x10C5520 VA: 0x1810C6120
	private bool ProcessTouchEvents() { }

	// RVA: 0x10C69E0 Offset: 0x10C5DE0 VA: 0x1810C69E0
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x10C7A40 Offset: 0x10C6E40 VA: 0x1810C7A40
	protected bool SendSubmitEventToSelectedObject() { }

	// RVA: 0x10C5850 Offset: 0x10C4C50 VA: 0x1810C5850
	private Vector2 GetRawMoveVector() { }

	// RVA: 0x10C7610 Offset: 0x10C6A10 VA: 0x1810C7610
	protected bool SendMoveEventToSelectedObject() { }

	// RVA: 0x10C5A50 Offset: 0x10C4E50 VA: 0x1810C5A50
	protected void ProcessMouseEvent() { }

	[ObsoleteAttribute] // RVA: 0x88700 Offset: 0x87B00 VA: 0x180088700
	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 30
	protected virtual bool ForceAutoSelect() { }

	// RVA: 0x10C5A60 Offset: 0x10C4E60 VA: 0x1810C5A60
	protected void ProcessMouseEvent(int id) { }

	// RVA: 0x10C7CB0 Offset: 0x10C70B0 VA: 0x1810C7CB0
	protected bool SendUpdateEventToSelectedObject() { }

	// RVA: 0x10C5D30 Offset: 0x10C5130 VA: 0x1810C5D30
	protected void ProcessMousePress(PointerInputModule.MouseButtonEventData data) { }

	// RVA: 0x4E4EC0 Offset: 0x4E42C0 VA: 0x1804E4EC0
	protected GameObject GetCurrentFocusedGameObject() { }

}

public enum StandaloneInputModule.InputMode // TypeDefIndex: 5086
{	// Fields
	public int value__; // 0x0
	public const StandaloneInputModule.InputMode Mouse = 0;
	public const StandaloneInputModule.InputMode Buttons = 1;

}


public class StandaloneInputModule : PointerInputModule // TypeDefIndex: 5085
{	private float m_PrevActionTime; // 0x58
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


	protected void .ctor() { }

	public StandaloneInputModule.InputMode get_inputMode() { }

	public bool get_allowActivationOnMobileDevice() { }

	public void set_allowActivationOnMobileDevice(bool value) { }

	public bool get_forceModuleActive() { }

	public void set_forceModuleActive(bool value) { }

	public float get_inputActionsPerSecond() { }

	public void set_inputActionsPerSecond(float value) { }

	public float get_repeatDelay() { }

	public void set_repeatDelay(float value) { }

	public string get_horizontalAxis() { }

	public void set_horizontalAxis(string value) { }

	public string get_verticalAxis() { }

	public void set_verticalAxis(string value) { }

	public string get_submitButton() { }

	public void set_submitButton(string value) { }

	public string get_cancelButton() { }

	public void set_cancelButton(string value) { }

	private bool ShouldIgnoreEventsOnNoFocus() { }

	public override void UpdateModule() { }

	private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo) { }

	public override bool IsModuleSupported() { }

	public override bool ShouldActivateModule() { }

	public override void ActivateModule() { }

	public override void DeactivateModule() { }

	public override void Process() { }

	private bool ProcessTouchEvents() { }

	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	protected bool SendSubmitEventToSelectedObject() { }

	private Vector2 GetRawMoveVector() { }

	protected bool SendMoveEventToSelectedObject() { }

	protected void ProcessMouseEvent() { }

	[ObsoleteAttribute] // RVA: 0x88700 Offset: 0x87B00 VA: 0x180088700
	protected virtual bool ForceAutoSelect() { }

	protected void ProcessMouseEvent(int id) { }

	protected bool SendUpdateEventToSelectedObject() { }

	protected void ProcessMousePress(PointerInputModule.MouseButtonEventData data) { }

	protected GameObject GetCurrentFocusedGameObject() { }

}

public enum StandaloneInputModule.InputMode // TypeDefIndex: 5086
{	public int value__; // 0x0
	public const StandaloneInputModule.InputMode Mouse = 0;
	public const StandaloneInputModule.InputMode Buttons = 1;

}


public class StandaloneInputModule : PointerInputModule // TypeDefIndex: 5089
{
	private float m_PrevActionTime; 
	private Vector2 m_LastMoveVector; 
	private int m_ConsecutiveMoveCount; 
	private Vector2 m_LastMousePosition; 
	private Vector2 m_MousePosition; 
	private GameObject m_CurrentFocusedGameObject; 
	private PointerEventData m_InputPointerEvent; 
	[SerializeField] 
	private string m_HorizontalAxis; 
	[SerializeField] 
	private string m_VerticalAxis; 
	[SerializeField] 
	private string m_SubmitButton; 
	[SerializeField] 
	private string m_CancelButton; 
	[SerializeField] 
	private float m_InputActionsPerSecond; 
	[SerializeField] 
	private float m_RepeatDelay; 
	[SerializeField] 
	[FormerlySerializedAsAttribute] 
	private bool m_ForceModuleActive; 

	[ObsoleteAttribute] 
	public StandaloneInputModule.InputMode inputMode { get; }
	[ObsoleteAttribute] 
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

	[ObsoleteAttribute] 
	protected virtual bool ForceAutoSelect() { }

	protected void ProcessMouseEvent(int id) { }

	protected bool SendUpdateEventToSelectedObject() { }

	protected void ProcessMousePress(PointerInputModule.MouseButtonEventData data) { }

	protected GameObject GetCurrentFocusedGameObject() { }

}

public enum StandaloneInputModule.InputMode // TypeDefIndex: 5090
{
	public int value__; 
	public const StandaloneInputModule.InputMode Mouse = 0;
	public const StandaloneInputModule.InputMode Buttons = 1;

}


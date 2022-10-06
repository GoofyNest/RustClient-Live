public abstract class BaseInputModule : UIBehaviour // TypeDefIndex: 5084
{
	protected List<RaycastResult> m_RaycastResultCache; 
	private AxisEventData m_AxisEventData; 
	private EventSystem m_EventSystem; 
	private BaseEventData m_BaseEventData; 
	protected BaseInput m_InputOverride; 
	private BaseInput m_DefaultInput; 

	public BaseInput input { get; }
	public BaseInput inputOverride { get; set; }
	protected EventSystem eventSystem { get; }


	public BaseInput get_input() { }

	public BaseInput get_inputOverride() { }

	public void set_inputOverride(BaseInput value) { }

	protected EventSystem get_eventSystem() { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	public abstract void Process();

	protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates) { }

	protected static MoveDirection DetermineMoveDirection(float x, float y) { }

	protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone) { }

	protected static GameObject FindCommonRoot(GameObject g1, GameObject g2) { }

	protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget) { }

	protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone) { }

	protected virtual BaseEventData GetBaseEventData() { }

	public virtual bool IsPointerOverGameObject(int pointerId) { }

	public virtual bool ShouldActivateModule() { }

	public virtual void DeactivateModule() { }

	public virtual void ActivateModule() { }

	public virtual void UpdateModule() { }

	public virtual bool IsModuleSupported() { }

	protected void .ctor() { }

}


public abstract class BaseInputModule : UIBehaviour // TypeDefIndex: 5080
{	// Fields
	protected List<RaycastResult> m_RaycastResultCache; // 0x18
	private AxisEventData m_AxisEventData; // 0x20
	private EventSystem m_EventSystem; // 0x28
	private BaseEventData m_BaseEventData; // 0x30
	protected BaseInput m_InputOverride; // 0x38
	private BaseInput m_DefaultInput; // 0x40

	// Properties
	public BaseInput input { get; }
	public BaseInput inputOverride { get; set; }
	protected EventSystem eventSystem { get; }

	// Methods

	// RVA: 0x10B13E0 Offset: 0x10B07E0 VA: 0x1810B13E0
	public BaseInput get_input() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public BaseInput get_inputOverride() { }

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	public void set_inputOverride(BaseInput value) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	protected EventSystem get_eventSystem() { }

	// RVA: 0x10B12D0 Offset: 0x10B06D0 VA: 0x1810B12D0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10B12B0 Offset: 0x10B06B0 VA: 0x1810B12B0 Slot: 7
	protected override void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Process();

	// RVA: 0x10B0A10 Offset: 0x10AFE10 VA: 0x1810B0A10
	protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates) { }

	// RVA: 0x10B0840 Offset: 0x10AFC40 VA: 0x1810B0840
	protected static MoveDirection DetermineMoveDirection(float x, float y) { }

	// RVA: 0x10B0750 Offset: 0x10AFB50 VA: 0x1810B0750
	protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone) { }

	// RVA: 0x10B0850 Offset: 0x10AFC50 VA: 0x1810B0850
	protected static GameObject FindCommonRoot(GameObject g1, GameObject g2) { }

	// RVA: 0x10B0DB0 Offset: 0x10B01B0 VA: 0x1810B0DB0
	protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget) { }

	// RVA: 0x10B0B60 Offset: 0x10AFF60 VA: 0x1810B0B60 Slot: 18
	protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone) { }

	// RVA: 0x10B0D00 Offset: 0x10B0100 VA: 0x1810B0D00 Slot: 19
	protected virtual BaseEventData GetBaseEventData() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 20
	public virtual bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x10B1330 Offset: 0x10B0730 VA: 0x1810B1330 Slot: 21
	public virtual bool ShouldActivateModule() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 22
	public virtual void DeactivateModule() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 23
	public virtual void ActivateModule() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 24
	public virtual void UpdateModule() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 25
	public virtual bool IsModuleSupported() { }

	// RVA: 0x10B1370 Offset: 0x10B0770 VA: 0x1810B1370
	protected void .ctor() { }

}


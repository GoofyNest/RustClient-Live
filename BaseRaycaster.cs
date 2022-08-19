public abstract class BaseRaycaster : UIBehaviour // TypeDefIndex: 5091
{	// Fields
	private BaseRaycaster m_RootRaycaster; // 0x18

	// Properties
	public abstract Camera eventCamera { get; }
	[ObsoleteAttribute] // RVA: 0x890B0 Offset: 0x884B0 VA: 0x1800890B0
	public virtual int priority { get; }
	public virtual int sortOrderPriority { get; }
	public virtual int renderOrderPriority { get; }
	public BaseRaycaster rootRaycaster { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract Camera get_eventCamera();

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 19
	public virtual int get_priority() { }

	// RVA: 0x10B2160 Offset: 0x10B1560 VA: 0x1810B2160 Slot: 20
	public virtual int get_sortOrderPriority() { }

	// RVA: 0x10B2160 Offset: 0x10B1560 VA: 0x1810B2160 Slot: 21
	public virtual int get_renderOrderPriority() { }

	// RVA: 0x10B2170 Offset: 0x10B1570 VA: 0x1810B2170
	public BaseRaycaster get_rootRaycaster() { }

	// RVA: 0x10B1D90 Offset: 0x10B1190 VA: 0x1810B1D90 Slot: 3
	public override string ToString() { }

	// RVA: 0x10B1C80 Offset: 0x10B1080 VA: 0x1810B1C80 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10B1B70 Offset: 0x10B0F70 VA: 0x1810B1B70 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xA792C0 Offset: 0xA786C0 VA: 0x180A792C0 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0xA792C0 Offset: 0xA786C0 VA: 0x180A792C0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	protected void .ctor() { }

}


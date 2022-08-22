public abstract class BaseRaycaster : UIBehaviour // TypeDefIndex: 5091
{	private BaseRaycaster m_RootRaycaster; // 0x18

	public abstract Camera eventCamera { get; }
	[ObsoleteAttribute] // RVA: 0x890B0 Offset: 0x884B0 VA: 0x1800890B0
	public virtual int priority { get; }
	public virtual int sortOrderPriority { get; }
	public virtual int renderOrderPriority { get; }
	public BaseRaycaster rootRaycaster { get; }


	public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);

	public abstract Camera get_eventCamera();

	public virtual int get_priority() { }

	public virtual int get_sortOrderPriority() { }

	public virtual int get_renderOrderPriority() { }

	public BaseRaycaster get_rootRaycaster() { }

	public override string ToString() { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	protected override void OnCanvasHierarchyChanged() { }

	protected override void OnTransformParentChanged() { }

	protected void .ctor() { }

}


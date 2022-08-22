public class RustLayout : UIBehaviour, ILayoutGroup, ILayoutController, IAutoLayout // TypeDefIndex: 7023
{	public RustLayout.LayoutMode Mode; // 0x18
	public bool ReverseOrder; // 0x1C
	public float Spacing; // 0x20
	public RectOffset Padding; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0x71530 Offset: 0x70930 VA: 0x180071530
	[TooltipAttribute] // RVA: 0x71530 Offset: 0x70930 VA: 0x180071530
	public bool ChildrenFill; // 0x30
	[FormerlySerializedAsAttribute] // RVA: 0x71730 Offset: 0x70B30 VA: 0x180071730
	[TooltipAttribute] // RVA: 0x71730 Offset: 0x70B30 VA: 0x180071730
	public bool ResizeToChildren; // 0x31
	[TooltipAttribute] // RVA: 0x71850 Offset: 0x70C50 VA: 0x180071850
	public bool ResizeToChildrenOpposite; // 0x32
	public RectTransform[] IgnoreLayout; // 0x38
	public int MaxHeight; // 0x40
	[TooltipAttribute] // RVA: 0x719B0 Offset: 0x70DB0 VA: 0x1800719B0
	public RustLayout ParentLayout; // 0x48
	private bool doingLayout; // 0x50
	private bool changedSize; // 0x51


	protected override void Awake() { }

	public virtual void SetLayoutHorizontal() { }

	public virtual void SetLayoutVertical() { }

	public virtual void DoLayout() { }

	protected override void OnTransformParentChanged() { }

	private void DoHorizontalLayout(RectTransform.Edge edge) { }

	private void DoTopLayout(RectTransform.Edge edge) { }

	private bool Ignoring(RectTransform child) { }

	protected void SetDirty() { }

	protected override void OnRectTransformDimensionsChange() { }

	protected virtual void OnTransformChildrenChanged() { }

	public void .ctor() { }

}

public enum RustLayout.LayoutMode // TypeDefIndex: 7024
{	public int value__; // 0x0
	public const RustLayout.LayoutMode Top = 0;
	public const RustLayout.LayoutMode Left = 1;
	public const RustLayout.LayoutMode Right = 2;
	public const RustLayout.LayoutMode Bottom = 3;

}


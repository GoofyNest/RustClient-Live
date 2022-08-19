public class RustLayout : UIBehaviour, ILayoutGroup, ILayoutController, IAutoLayout // TypeDefIndex: 7023
{	// Fields
	public RustLayout.LayoutMode Mode; // 0x18
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

	// Methods

	// RVA: 0xFC7FF0 Offset: 0xFC73F0 VA: 0x180FC7FF0 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFC9580 Offset: 0xFC8980 VA: 0x180FC9580 Slot: 20
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0xFC9580 Offset: 0xFC8980 VA: 0x180FC9580 Slot: 21
	public virtual void SetLayoutVertical() { }

	// RVA: 0xFC8890 Offset: 0xFC7C90 VA: 0x180FC8890 Slot: 22
	public virtual void DoLayout() { }

	// RVA: 0xFC9410 Offset: 0xFC8810 VA: 0x180FC9410 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0xFC8010 Offset: 0xFC7410 VA: 0x180FC8010
	private void DoHorizontalLayout(RectTransform.Edge edge) { }

	// RVA: 0xFC8A00 Offset: 0xFC7E00 VA: 0x180FC8A00
	private void DoTopLayout(RectTransform.Edge edge) { }

	// RVA: 0xFC9310 Offset: 0xFC8710 VA: 0x180FC9310
	private bool Ignoring(RectTransform child) { }

	// RVA: 0xFC94F0 Offset: 0xFC88F0 VA: 0x180FC94F0
	protected void SetDirty() { }

	// RVA: 0xFC93E0 Offset: 0xFC87E0 VA: 0x180FC93E0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0xFC9400 Offset: 0xFC8800 VA: 0x180FC9400 Slot: 23
	protected virtual void OnTransformChildrenChanged() { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

}

public enum RustLayout.LayoutMode // TypeDefIndex: 7024
{	// Fields
	public int value__; // 0x0
	public const RustLayout.LayoutMode Top = 0;
	public const RustLayout.LayoutMode Left = 1;
	public const RustLayout.LayoutMode Right = 2;
	public const RustLayout.LayoutMode Bottom = 3;

}


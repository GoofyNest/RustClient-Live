public class RustLayout : UIBehaviour, ILayoutGroup, ILayoutController, IAutoLayout // TypeDefIndex: 7067
{
	public RustLayout.LayoutMode Mode;
	public bool ReverseOrder;
	public float Spacing;
	public RectOffset Padding;
	[FormerlySerializedAsAttribute]
	[TooltipAttribute]
	public bool ChildrenFill;
	[FormerlySerializedAsAttribute]
	[TooltipAttribute]
	public bool ResizeToChildren;
	[TooltipAttribute]
	public bool ResizeToChildrenOpposite;
	public RectTransform[] IgnoreLayout;
	public int MaxHeight;
	[TooltipAttribute]
	public RustLayout ParentLayout;
	private bool doingLayout;
	private bool changedSize;


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

public enum RustLayout.LayoutMode // TypeDefIndex: 7068
{
	public int value__;
	public const RustLayout.LayoutMode Top = 0;
	public const RustLayout.LayoutMode Left = 1;
	public const RustLayout.LayoutMode Right = 2;
	public const RustLayout.LayoutMode Bottom = 3;

}


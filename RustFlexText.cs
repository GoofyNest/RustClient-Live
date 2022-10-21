public class RustFlexText : RustText, IFlexNode // TypeDefIndex: 7054
{
	[TooltipAttribute] 
	public FlexLength Basis; 
	[MinAttribute] 
	[TooltipAttribute] 
	public int Grow; 
	[MinAttribute] 
	[TooltipAttribute] 
	public int Shrink; 
	[TooltipAttribute] 
	public FlexAlignSelf AlignSelf; 
	[TooltipAttribute] 
	public FlexLength FlexMinWidth; 
	[TooltipAttribute] 
	public FlexLength FlexMaxWidth; 
	[TooltipAttribute] 
	public FlexLength FlexMinHeight; 
	[TooltipAttribute] 
	public FlexLength FlexMaxHeight; 
	private bool _isDirty; 
	private float _preferredWidth; 
	private float _preferredHeight; 

	private RectTransform Facepunch.Flexbox.IFlexNode.Transform { get; }
	private bool Facepunch.Flexbox.IFlexNode.IsActive { get; }
	private bool Facepunch.Flexbox.IFlexNode.IsAbsolute { get; }
	private bool Facepunch.Flexbox.IFlexNode.IsDirty { get; }
	private FlexLength Facepunch.Flexbox.IFlexNode.MinWidth { get; }
	private FlexLength Facepunch.Flexbox.IFlexNode.MaxWidth { get; }
	private FlexLength Facepunch.Flexbox.IFlexNode.MinHeight { get; }
	private FlexLength Facepunch.Flexbox.IFlexNode.MaxHeight { get; }
	private FlexLength Facepunch.Flexbox.IFlexNode.Basis { get; }
	private int Facepunch.Flexbox.IFlexNode.Grow { get; }
	private int Facepunch.Flexbox.IFlexNode.Shrink { get; }
	private FlexAlignSelf Facepunch.Flexbox.IFlexNode.AlignSelf { get; }


	protected override void OnEnable() { }

	protected override void OnDisable() { }

	public override void SetLayoutDirty() { }

	private void SetupTransform() { }

	public override void DoAutoSize() { }

	private RectTransform Facepunch.Flexbox.IFlexNode.get_Transform() { }

	private bool Facepunch.Flexbox.IFlexNode.get_IsActive() { }

	private bool Facepunch.Flexbox.IFlexNode.get_IsAbsolute() { }

	private bool Facepunch.Flexbox.IFlexNode.get_IsDirty() { }

	private FlexLength Facepunch.Flexbox.IFlexNode.get_MinWidth() { }

	private FlexLength Facepunch.Flexbox.IFlexNode.get_MaxWidth() { }

	private FlexLength Facepunch.Flexbox.IFlexNode.get_MinHeight() { }

	private FlexLength Facepunch.Flexbox.IFlexNode.get_MaxHeight() { }

	private FlexLength Facepunch.Flexbox.IFlexNode.get_Basis() { }

	private int Facepunch.Flexbox.IFlexNode.get_Grow() { }

	private int Facepunch.Flexbox.IFlexNode.get_Shrink() { }

	private FlexAlignSelf Facepunch.Flexbox.IFlexNode.get_AlignSelf() { }

	private void Facepunch.Flexbox.IFlexNode.SetLayoutDirty(bool force) { }

	private void Facepunch.Flexbox.IFlexNode.MeasureHorizontal() { }

	private void Facepunch.Flexbox.IFlexNode.LayoutHorizontal(float maxWidth, float maxHeight) { }

	private void Facepunch.Flexbox.IFlexNode.MeasureVertical() { }

	private void Facepunch.Flexbox.IFlexNode.LayoutVertical(float maxWidth, float maxHeight) { }

	private void Facepunch.Flexbox.IFlexNode.GetScale(out float scaleX, out float scaleY) { }

	private void Facepunch.Flexbox.IFlexNode.GetPreferredSize(out float preferredWidth, out float preferredHeight) { }

	public void .ctor() { }

}


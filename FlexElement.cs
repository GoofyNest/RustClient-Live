public class FlexElement : UIBehaviour, IFlexNode // TypeDefIndex: 6819
{
	private static readonly List<IFlexNode> SizingChildren; 
	[TooltipAttribute] 
	public FlexDirection FlexDirection; 
	[TooltipAttribute] 
	public FlexJustify JustifyContent; 
	[TooltipAttribute] 
	public FlexAlign AlignItems; 
	[TooltipAttribute] 
	public FlexPadding Padding; 
	[MinAttribute] 
	[TooltipAttribute] 
	public float Gap; 
	[TooltipAttribute] 
	public FlexLength Basis; 
	[MinAttribute] 
	[TooltipAttribute] 
	public int Grow; 
	[TooltipAttribute] 
	public FlexAlignSelf AlignSelf; 
	[MinAttribute] 
	[TooltipAttribute] 
	public int Shrink; 
	[TooltipAttribute] 
	public bool IsAbsolute; 
	[TooltipAttribute] 
	public bool AutoSizeX; 
	[TooltipAttribute] 
	public bool AutoSizeY; 
	[TooltipAttribute] 
	public FlexLength MinWidth; 
	[TooltipAttribute] 
	public FlexLength MaxWidth; 
	[TooltipAttribute] 
	public FlexLength MinHeight; 
	[TooltipAttribute] 
	public FlexLength MaxHeight; 
	private bool _isDirty; 
	private bool _isDoingLayout; 
	private float _prefWidth; 
	private float _prefHeight; 
	private int _growSum; 
	private int _shrinkSum; 
	private readonly List<IFlexNode> _children; 
	private FlexElement.ChildSizingParameters[] _childSizes; 

	private bool IsHorizontal { get; }
	private bool IsReversed { get; }
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


	private bool get_IsHorizontal() { }

	private bool get_IsReversed() { }

	public void SetLayoutDirty(bool force = False) { }

	internal void PerformLayout() { }

	private void MeasureMainAxis() { }

	private void LayoutMainAxis(float maxWidth, float maxHeight) { }

	private void MeasureCrossAxis() { }

	private void LayoutCrossAxis(float maxWidth, float maxHeight) { }

	private static ref T Pick<T>(bool value, ref T ifTrue, ref T ifFalse) { }
	/* GenericInstMethod :
	|
	|-FlexElement.Pick<object>
	|-FlexElement.Pick<float>
	*/

	private static float CalculateLengthValue(in FlexLength length, float fillValue, float defaultValue) { }

	private void SetupTransform() { }

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

	private void Facepunch.Flexbox.IFlexNode.MeasureHorizontal() { }

	private void Facepunch.Flexbox.IFlexNode.LayoutHorizontal(float maxWidth, float maxHeight) { }

	private void Facepunch.Flexbox.IFlexNode.MeasureVertical() { }

	private void Facepunch.Flexbox.IFlexNode.LayoutVertical(float maxWidth, float maxHeight) { }

	private void Facepunch.Flexbox.IFlexNode.GetScale(out float scaleX, out float scaleY) { }

	private void Facepunch.Flexbox.IFlexNode.GetPreferredSize(out float preferredWidth, out float preferredHeight) { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	protected override void OnRectTransformDimensionsChange() { }

	protected override void OnBeforeTransformParentChanged() { }

	protected override void OnTransformParentChanged() { }

	protected virtual void OnTransformChildrenChanged() { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] 
	private bool <LayoutMainAxis>g__TakeGrowth|33_2(ref float value, float maxValue, float scale, ref FlexElement.<>c

	[CompilerGeneratedAttribute] 
	private bool <LayoutMainAxis>g__TakeShrink|33_3(ref float value, float minValue, float scale, ref FlexElement.<>c

	[CompilerGeneratedAttribute] 
	private float <LayoutMainAxis>g__GetMainAxisStart|33_1(bool isHorizontal, bool isReversed, ref FlexElement.<>c

	[CompilerGeneratedAttribute] 
	private float <LayoutCrossAxis>g__GetCrossAxis|35_0(FlexAlign align, bool isHorizontal, float childWidth, float childHeight, ref FlexElement.<>c

}

private struct FlexElement.ChildSizingParameters // TypeDefIndex: 6820
{
	public float Size; 
	public float MinSize; 
	public float MaxSize; 
	public bool IsFlexible; 
	public float Scale; 

}

private struct FlexElement.<>c__DisplayClass33_0 // TypeDefIndex: 6821
{
	public float growthAllowance; 
	public float shrinkAllowance; 
	public FlexElement <>4__this; 
	public float innerSize; 
	public float actualMainSize; 

}

private struct FlexElement.<>c__DisplayClass33_1 // TypeDefIndex: 6822
{
	public int growSum; 
	public int shrinkSum; 

}

private struct FlexElement.<>c__DisplayClass33_2 // TypeDefIndex: 6823
{
	public IFlexNode child; 

}

private sealed class FlexElement.<>c // TypeDefIndex: 6824
{
	public static readonly FlexElement.<>c <>9; 
	public static Predicate<IFlexNode> <>9__33_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <LayoutMainAxis>

}

private struct FlexElement.<>c__DisplayClass35_0 // TypeDefIndex: 6825
{
	public FlexElement <>4__this; 
	public float innerSize; 

}


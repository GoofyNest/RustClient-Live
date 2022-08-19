public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup, ILayoutController // TypeDefIndex: 4977
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected RectOffset m_Padding; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected TextAnchor m_ChildAlignment; // 0x20
	private RectTransform m_Rect; // 0x28
	protected DrivenRectTransformTracker m_Tracker; // 0x30
	private Vector2 m_TotalMinSize; // 0x34
	private Vector2 m_TotalPreferredSize; // 0x3C
	private Vector2 m_TotalFlexibleSize; // 0x44
	private List<RectTransform> m_RectChildren; // 0x50

	// Properties
	public RectOffset padding { get; set; }
	public TextAnchor childAlignment { get; set; }
	protected RectTransform rectTransform { get; }
	protected List<RectTransform> rectChildren { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }
	private bool isRootLayoutGroup { get; }

	// Methods

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public RectOffset get_padding() { }

	// RVA: 0x170CB70 Offset: 0x170BF70 VA: 0x18170CB70
	public void set_padding(RectOffset value) { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public TextAnchor get_childAlignment() { }

	// RVA: 0x170CB20 Offset: 0x170BF20 VA: 0x18170CB20
	public void set_childAlignment(TextAnchor value) { }

	// RVA: 0x170CA80 Offset: 0x170BE80 VA: 0x18170CA80
	protected RectTransform get_rectTransform() { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	protected List<RectTransform> get_rectChildren() { }

	// RVA: 0x170B9A0 Offset: 0x170ADA0 VA: 0x18170B9A0 Slot: 28
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void CalculateLayoutInputVertical();

	// RVA: 0x170CA50 Offset: 0x170BE50 VA: 0x18170CA50 Slot: 30
	public virtual float get_minWidth() { }

	// RVA: 0x170CA70 Offset: 0x170BE70 VA: 0x18170CA70 Slot: 31
	public virtual float get_preferredWidth() { }

	// RVA: 0x170C900 Offset: 0x170BD00 VA: 0x18170C900 Slot: 32
	public virtual float get_flexibleWidth() { }

	// RVA: 0x170CA40 Offset: 0x170BE40 VA: 0x18170CA40 Slot: 33
	public virtual float get_minHeight() { }

	// RVA: 0x170CA60 Offset: 0x170BE60 VA: 0x18170CA60 Slot: 34
	public virtual float get_preferredHeight() { }

	// RVA: 0x170C8F0 Offset: 0x170BCF0 VA: 0x18170C8F0 Slot: 35
	public virtual float get_flexibleHeight() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 36
	public virtual int get_layoutPriority() { }

	// RVA: -1 Offset: -1 Slot: 37
	public abstract void SetLayoutHorizontal();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract void SetLayoutVertical();

	// RVA: 0x170C790 Offset: 0x170BB90 VA: 0x18170C790
	protected void .ctor() { }

	// RVA: 0x170BF20 Offset: 0x170B320 VA: 0x18170BF20 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x170BEA0 Offset: 0x170B2A0 VA: 0x18170BEA0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x170BE90 Offset: 0x170B290 VA: 0x18170BE90 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x170BE70 Offset: 0x170B270 VA: 0x18170BE70
	protected float GetTotalMinSize(int axis) { }

	// RVA: 0x170BE80 Offset: 0x170B280 VA: 0x18170BE80
	protected float GetTotalPreferredSize(int axis) { }

	// RVA: 0x170BE60 Offset: 0x170B260 VA: 0x18170BE60
	protected float GetTotalFlexibleSize(int axis) { }

	// RVA: 0x170BD30 Offset: 0x170B130 VA: 0x18170BD30
	protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding) { }

	// RVA: 0x170BCE0 Offset: 0x170B0E0 VA: 0x18170BCE0
	protected float GetAlignmentOnAxis(int axis) { }

	// RVA: 0x170C720 Offset: 0x170BB20 VA: 0x18170C720
	protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis) { }

	// RVA: 0x170C540 Offset: 0x170B940 VA: 0x18170C540
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos) { }

	// RVA: 0x170C270 Offset: 0x170B670 VA: 0x18170C270
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor) { }

	// RVA: 0x170C480 Offset: 0x170B880 VA: 0x18170C480
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size) { }

	// RVA: 0x170C080 Offset: 0x170B480 VA: 0x18170C080
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor) { }

	// RVA: 0x170C910 Offset: 0x170BD10 VA: 0x18170C910
	private bool get_isRootLayoutGroup() { }

	// RVA: 0x170BF40 Offset: 0x170B340 VA: 0x18170BF40 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x170BE90 Offset: 0x170B290 VA: 0x18170BE90 Slot: 39
	protected virtual void OnTransformChildrenChanged() { }

	// RVA: -1 Offset: -1
	protected void SetProperty<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EABC0 Offset: 0x5E9FC0 VA: 0x1805EABC0
	|-LayoutGroup.SetProperty<bool>
	|
	|-RVA: 0x5EAD20 Offset: 0x5EA120 VA: 0x1805EAD20
	|-LayoutGroup.SetProperty<int>
	|
	|-RVA: 0x5EAC50 Offset: 0x5EA050 VA: 0x1805EAC50
	|-LayoutGroup.SetProperty<Int32Enum>
	|-LayoutGroup.SetProperty<TextAnchor>
	|-LayoutGroup.SetProperty<GridLayoutGroup.Axis>
	|-LayoutGroup.SetProperty<GridLayoutGroup.Constraint>
	|-LayoutGroup.SetProperty<GridLayoutGroup.Corner>
	|
	|-RVA: 0x5EADB0 Offset: 0x5EA1B0 VA: 0x1805EADB0
	|-LayoutGroup.SetProperty<object>
	|-LayoutGroup.SetProperty<RectOffset>
	|
	|-RVA: 0x5EAE30 Offset: 0x5EA230 VA: 0x1805EAE30
	|-LayoutGroup.SetProperty<float>
	|
	|-RVA: 0x5EAEC0 Offset: 0x5EA2C0 VA: 0x1805EAEC0
	|-LayoutGroup.SetProperty<Vector2>
	*/

	// RVA: 0x170C5F0 Offset: 0x170B9F0 VA: 0x18170C5F0
	protected void SetDirty() { }

	[IteratorStateMachineAttribute] // RVA: 0x72450 Offset: 0x71850 VA: 0x180072450
	// RVA: 0x170BC70 Offset: 0x170B070 VA: 0x18170BC70
	private IEnumerator DelayedSetDirty(RectTransform rectTransform) { }

}

private sealed class LayoutGroup.<DelayedSetDirty>d__56 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 4978
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RectTransform rectTransform; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1721D40 Offset: 0x1721140 VA: 0x181721D40 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1721DE0 Offset: 0x17211E0 VA: 0x181721DE0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}


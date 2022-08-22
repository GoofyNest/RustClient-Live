public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer // TypeDefIndex: 4976
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_IgnoreLayout; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_MinWidth; // 0x1C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_MinHeight; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_PreferredWidth; // 0x24
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_PreferredHeight; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_FlexibleWidth; // 0x2C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_FlexibleHeight; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_LayoutPriority; // 0x34

	public virtual bool ignoreLayout { get; set; }
	public virtual float minWidth { get; set; }
	public virtual float minHeight { get; set; }
	public virtual float preferredWidth { get; set; }
	public virtual float preferredHeight { get; set; }
	public virtual float flexibleWidth { get; set; }
	public virtual float flexibleHeight { get; set; }
	public virtual int layoutPriority { get; set; }


	public virtual bool get_ignoreLayout() { }

	public virtual void set_ignoreLayout(bool value) { }

	public virtual void CalculateLayoutInputHorizontal() { }

	public virtual void CalculateLayoutInputVertical() { }

	public virtual float get_minWidth() { }

	public virtual void set_minWidth(float value) { }

	public virtual float get_minHeight() { }

	public virtual void set_minHeight(float value) { }

	public virtual float get_preferredWidth() { }

	public virtual void set_preferredWidth(float value) { }

	public virtual float get_preferredHeight() { }

	public virtual void set_preferredHeight(float value) { }

	public virtual float get_flexibleWidth() { }

	public virtual void set_flexibleWidth(float value) { }

	public virtual float get_flexibleHeight() { }

	public virtual void set_flexibleHeight(float value) { }

	public virtual int get_layoutPriority() { }

	public virtual void set_layoutPriority(int value) { }

	protected void .ctor() { }

	protected override void OnEnable() { }

	protected override void OnTransformParentChanged() { }

	protected override void OnDisable() { }

	protected override void OnDidApplyAnimationProperties() { }

	protected override void OnBeforeTransformParentChanged() { }

	protected void SetDirty() { }

}


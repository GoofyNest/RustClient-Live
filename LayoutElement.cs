public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer // TypeDefIndex: 4976
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Properties
	public virtual bool ignoreLayout { get; set; }
	public virtual float minWidth { get; set; }
	public virtual float minHeight { get; set; }
	public virtual float preferredWidth { get; set; }
	public virtual float preferredHeight { get; set; }
	public virtual float flexibleWidth { get; set; }
	public virtual float flexibleHeight { get; set; }
	public virtual int layoutPriority { get; set; }

	// Methods

	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0 Slot: 27
	public virtual bool get_ignoreLayout() { }

	// RVA: 0x170B760 Offset: 0x170AB60 VA: 0x18170B760 Slot: 28
	public virtual void set_ignoreLayout(bool value) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 29
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 30
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x7723E0 Offset: 0x7717E0 VA: 0x1807723E0 Slot: 31
	public virtual float get_minWidth() { }

	// RVA: 0x170B880 Offset: 0x170AC80 VA: 0x18170B880 Slot: 32
	public virtual void set_minWidth(float value) { }

	// RVA: 0x772400 Offset: 0x771800 VA: 0x180772400 Slot: 33
	public virtual float get_minHeight() { }

	// RVA: 0x170B820 Offset: 0x170AC20 VA: 0x18170B820 Slot: 34
	public virtual void set_minHeight(float value) { }

	// RVA: 0x7E8600 Offset: 0x7E7A00 VA: 0x1807E8600 Slot: 35
	public virtual float get_preferredWidth() { }

	// RVA: 0x170B940 Offset: 0x170AD40 VA: 0x18170B940 Slot: 36
	public virtual void set_preferredWidth(float value) { }

	// RVA: 0x93F110 Offset: 0x93E510 VA: 0x18093F110 Slot: 37
	public virtual float get_preferredHeight() { }

	// RVA: 0x170B8E0 Offset: 0x170ACE0 VA: 0x18170B8E0 Slot: 38
	public virtual void set_preferredHeight(float value) { }

	// RVA: 0x93F170 Offset: 0x93E570 VA: 0x18093F170 Slot: 39
	public virtual float get_flexibleWidth() { }

	// RVA: 0x170B700 Offset: 0x170AB00 VA: 0x18170B700 Slot: 40
	public virtual void set_flexibleWidth(float value) { }

	// RVA: 0x516B60 Offset: 0x515F60 VA: 0x180516B60 Slot: 41
	public virtual float get_flexibleHeight() { }

	// RVA: 0x170B6A0 Offset: 0x170AAA0 VA: 0x18170B6A0 Slot: 42
	public virtual void set_flexibleHeight(float value) { }

	// RVA: 0x5FC780 Offset: 0x5FBB80 VA: 0x1805FC780 Slot: 43
	public virtual int get_layoutPriority() { }

	// RVA: 0x170B7C0 Offset: 0x170ABC0 VA: 0x18170B7C0 Slot: 44
	public virtual void set_layoutPriority(int value) { }

	// RVA: 0x170B660 Offset: 0x170AA60 VA: 0x18170B660
	protected void .ctor() { }

	// RVA: 0x170B5B0 Offset: 0x170A9B0 VA: 0x18170B5B0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x170B580 Offset: 0x170A980 VA: 0x18170B580 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x170B590 Offset: 0x170A990 VA: 0x18170B590 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x170B580 Offset: 0x170A980 VA: 0x18170B580 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x170B580 Offset: 0x170A980 VA: 0x18170B580 Slot: 11
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x170B5D0 Offset: 0x170A9D0 VA: 0x18170B5D0
	protected void SetDirty() { }

}


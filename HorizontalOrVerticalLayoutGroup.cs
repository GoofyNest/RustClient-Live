public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup // TypeDefIndex: 4970
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected float m_Spacing; // 0x58
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_ChildForceExpandWidth; // 0x5C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_ChildForceExpandHeight; // 0x5D
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_ChildControlWidth; // 0x5E
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_ChildControlHeight; // 0x5F
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_ChildScaleWidth; // 0x60
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_ChildScaleHeight; // 0x61

	// Properties
	public float spacing { get; set; }
	public bool childForceExpandWidth { get; set; }
	public bool childForceExpandHeight { get; set; }
	public bool childControlWidth { get; set; }
	public bool childControlHeight { get; set; }
	public bool childScaleWidth { get; set; }
	public bool childScaleHeight { get; set; }

	// Methods

	// RVA: 0x58DC20 Offset: 0x58D020 VA: 0x18058DC20
	public float get_spacing() { }

	// RVA: 0x15ECE00 Offset: 0x15EC200 VA: 0x1815ECE00
	public void set_spacing(float value) { }

	// RVA: 0x15ECC10 Offset: 0x15EC010 VA: 0x1815ECC10
	public bool get_childForceExpandWidth() { }

	// RVA: 0x15ECD10 Offset: 0x15EC110 VA: 0x1815ECD10
	public void set_childForceExpandWidth(bool value) { }

	// RVA: 0x15ECC00 Offset: 0x15EC000 VA: 0x1815ECC00
	public bool get_childForceExpandHeight() { }

	// RVA: 0x15ECCC0 Offset: 0x15EC0C0 VA: 0x1815ECCC0
	public void set_childForceExpandHeight(bool value) { }

	// RVA: 0x15ECBF0 Offset: 0x15EBFF0 VA: 0x1815ECBF0
	public bool get_childControlWidth() { }

	// RVA: 0x15ECC70 Offset: 0x15EC070 VA: 0x1815ECC70
	public void set_childControlWidth(bool value) { }

	// RVA: 0x15ECBE0 Offset: 0x15EBFE0 VA: 0x1815ECBE0
	public bool get_childControlHeight() { }

	// RVA: 0x15ECC20 Offset: 0x15EC020 VA: 0x1815ECC20
	public void set_childControlHeight(bool value) { }

	// RVA: 0xA2DBD0 Offset: 0xA2CFD0 VA: 0x180A2DBD0
	public bool get_childScaleWidth() { }

	// RVA: 0x15ECDB0 Offset: 0x15EC1B0 VA: 0x1815ECDB0
	public void set_childScaleWidth(bool value) { }

	// RVA: 0x10813A0 Offset: 0x10807A0 VA: 0x1810813A0
	public bool get_childScaleHeight() { }

	// RVA: 0x15ECD60 Offset: 0x15EC160 VA: 0x1815ECD60
	public void set_childScaleHeight(bool value) { }

	// RVA: 0x15EBE30 Offset: 0x15EB230 VA: 0x1815EBE30
	protected void CalcAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x15EC380 Offset: 0x15EB780 VA: 0x1815EC380
	protected void SetChildrenAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x15EC250 Offset: 0x15EB650 VA: 0x1815EC250
	private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible) { }

	// RVA: 0x15EBE20 Offset: 0x15EB220 VA: 0x1815EBE20
	protected void .ctor() { }

}


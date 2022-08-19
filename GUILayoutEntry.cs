internal class GUILayoutEntry // TypeDefIndex: 4053
{	// Fields
	public float minWidth; // 0x10
	public float maxWidth; // 0x14
	public float minHeight; // 0x18
	public float maxHeight; // 0x1C
	public Rect rect; // 0x20
	public int stretchWidth; // 0x30
	public int stretchHeight; // 0x34
	public bool consideredForMargin; // 0x38
	private GUIStyle m_Style; // 0x40
	internal static Rect kDummyRect; // 0x0
	protected static int indent; // 0x10

	// Properties
	public GUIStyle style { get; set; }
	public virtual int marginLeft { get; }
	public virtual int marginRight { get; }
	public virtual int marginTop { get; }
	public virtual int marginBottom { get; }
	public int marginHorizontal { get; }
	public int marginVertical { get; }

	// Methods

	// RVA: 0x1A5EE80 Offset: 0x1A5E280 VA: 0x181A5EE80
	public GUIStyle get_style() { }

	// RVA: 0x1A5EE90 Offset: 0x1A5E290 VA: 0x181A5EE90
	public void set_style(GUIStyle value) { }

	// RVA: 0x1A5EDB0 Offset: 0x1A5E1B0 VA: 0x181A5EDB0 Slot: 4
	public virtual int get_marginLeft() { }

	// RVA: 0x1A5EDE0 Offset: 0x1A5E1E0 VA: 0x181A5EDE0 Slot: 5
	public virtual int get_marginRight() { }

	// RVA: 0x1A5EE10 Offset: 0x1A5E210 VA: 0x181A5EE10 Slot: 6
	public virtual int get_marginTop() { }

	// RVA: 0x1A5ED40 Offset: 0x1A5E140 VA: 0x181A5ED40 Slot: 7
	public virtual int get_marginBottom() { }

	// RVA: 0x1A5ED70 Offset: 0x1A5E170 VA: 0x181A5ED70
	public int get_marginHorizontal() { }

	// RVA: 0x1A5EE40 Offset: 0x1A5E240 VA: 0x181A5EE40
	public int get_marginVertical() { }

	// RVA: 0x1A5EBE0 Offset: 0x1A5DFE0 VA: 0x181A5EBE0
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) { }

	// RVA: 0x1A5EA90 Offset: 0x1A5DE90 VA: 0x181A5EA90
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	public virtual void CalcWidth() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 9
	public virtual void CalcHeight() { }

	// RVA: 0x1A5E090 Offset: 0x1A5D490 VA: 0x181A5E090 Slot: 10
	public virtual void SetHorizontal(float x, float width) { }

	// RVA: 0x1A5E0D0 Offset: 0x1A5D4D0 VA: 0x181A5E0D0 Slot: 11
	public virtual void SetVertical(float y, float height) { }

	// RVA: 0x1A5DF80 Offset: 0x1A5D380 VA: 0x181A5DF80 Slot: 12
	protected virtual void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x1A5DBE0 Offset: 0x1A5CFE0 VA: 0x181A5DBE0 Slot: 13
	public virtual void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x1A5E110 Offset: 0x1A5D510 VA: 0x181A5E110 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A5EA10 Offset: 0x1A5DE10 VA: 0x181A5EA10
	private static void .cctor() { }

}


public struct ColorBlock : IEquatable<ColorBlock> // TypeDefIndex: 4911
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0xE6230 Offset: 0xE5630 VA: 0x1800E6230
	[SerializeField] // RVA: 0xE6230 Offset: 0xE5630 VA: 0x1800E6230
	private Color m_NormalColor; // 0x0
	[FormerlySerializedAsAttribute] // RVA: 0xE6330 Offset: 0xE5730 VA: 0x1800E6330
	[SerializeField] // RVA: 0xE6330 Offset: 0xE5730 VA: 0x1800E6330
	private Color m_HighlightedColor; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0xE64F0 Offset: 0xE58F0 VA: 0x1800E64F0
	[SerializeField] // RVA: 0xE64F0 Offset: 0xE58F0 VA: 0x1800E64F0
	private Color m_PressedColor; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xE6620 Offset: 0xE5A20 VA: 0x1800E6620
	[SerializeField] // RVA: 0xE6620 Offset: 0xE5A20 VA: 0x1800E6620
	private Color m_SelectedColor; // 0x30
	[FormerlySerializedAsAttribute] // RVA: 0xE6860 Offset: 0xE5C60 VA: 0x1800E6860
	[SerializeField] // RVA: 0xE6860 Offset: 0xE5C60 VA: 0x1800E6860
	private Color m_DisabledColor; // 0x40
	[RangeAttribute] // RVA: 0xE69A0 Offset: 0xE5DA0 VA: 0x1800E69A0
	[SerializeField] // RVA: 0xE69A0 Offset: 0xE5DA0 VA: 0x1800E69A0
	private float m_ColorMultiplier; // 0x50
	[FormerlySerializedAsAttribute] // RVA: 0xE6CE0 Offset: 0xE60E0 VA: 0x1800E6CE0
	[SerializeField] // RVA: 0xE6CE0 Offset: 0xE60E0 VA: 0x1800E6CE0
	private float m_FadeDuration; // 0x54

	// Properties
	public Color normalColor { get; set; }
	public Color highlightedColor { get; set; }
	public Color pressedColor { get; set; }
	public Color selectedColor { get; set; }
	public Color disabledColor { get; set; }
	public float colorMultiplier { get; set; }
	public float fadeDuration { get; set; }
	public static ColorBlock defaultColorBlock { get; }

	// Methods

	// RVA: 0x14B600 Offset: 0x14AA00 VA: 0x18014B600
	public Color get_normalColor() { }

	// RVA: 0x19E2A0 Offset: 0x19D6A0 VA: 0x18019E2A0
	public void set_normalColor(Color value) { }

	// RVA: 0x10A9C0 Offset: 0x109DC0 VA: 0x18010A9C0
	public Color get_highlightedColor() { }

	// RVA: 0x19E290 Offset: 0x19D690 VA: 0x18019E290
	public void set_highlightedColor(Color value) { }

	// RVA: 0x19E240 Offset: 0x19D640 VA: 0x18019E240
	public Color get_pressedColor() { }

	// RVA: 0x19E2B0 Offset: 0x19D6B0 VA: 0x18019E2B0
	public void set_pressedColor(Color value) { }

	// RVA: 0x19E250 Offset: 0x19D650 VA: 0x18019E250
	public Color get_selectedColor() { }

	// RVA: 0x19E2C0 Offset: 0x19D6C0 VA: 0x18019E2C0
	public void set_selectedColor(Color value) { }

	// RVA: 0x19E220 Offset: 0x19D620 VA: 0x18019E220
	public Color get_disabledColor() { }

	// RVA: 0x19E270 Offset: 0x19D670 VA: 0x18019E270
	public void set_disabledColor(Color value) { }

	// RVA: 0x19E210 Offset: 0x19D610 VA: 0x18019E210
	public float get_colorMultiplier() { }

	// RVA: 0x19E260 Offset: 0x19D660 VA: 0x18019E260
	public void set_colorMultiplier(float value) { }

	// RVA: 0x19E230 Offset: 0x19D630 VA: 0x18019E230
	public float get_fadeDuration() { }

	// RVA: 0x19E280 Offset: 0x19D680 VA: 0x18019E280
	public void set_fadeDuration(float value) { }

	// RVA: 0x10B4C90 Offset: 0x10B4090 VA: 0x1810B4C90
	public static ColorBlock get_defaultColorBlock() { }

	// RVA: 0x19E050 Offset: 0x19D450 VA: 0x18019E050 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x19E130 Offset: 0x19D530 VA: 0x18019E130 Slot: 4
	public bool Equals(ColorBlock other) { }

	// RVA: 0x10B4E00 Offset: 0x10B4200 VA: 0x1810B4E00
	public static bool op_Equality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x10B4E50 Offset: 0x10B4250 VA: 0x1810B4E50
	public static bool op_Inequality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x19E180 Offset: 0x19D580 VA: 0x18019E180 Slot: 2
	public override int GetHashCode() { }

}


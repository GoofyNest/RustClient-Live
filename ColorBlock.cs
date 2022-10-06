public struct ColorBlock : IEquatable<ColorBlock> // TypeDefIndex: 4915
{
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private Color m_NormalColor; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private Color m_HighlightedColor; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private Color m_PressedColor; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private Color m_SelectedColor; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private Color m_DisabledColor; 
	[RangeAttribute] 
	[SerializeField] 
	private float m_ColorMultiplier; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private float m_FadeDuration; 

	public Color normalColor { get; set; }
	public Color highlightedColor { get; set; }
	public Color pressedColor { get; set; }
	public Color selectedColor { get; set; }
	public Color disabledColor { get; set; }
	public float colorMultiplier { get; set; }
	public float fadeDuration { get; set; }
	public static ColorBlock defaultColorBlock { get; }


	public Color get_normalColor() { }

	public void set_normalColor(Color value) { }

	public Color get_highlightedColor() { }

	public void set_highlightedColor(Color value) { }

	public Color get_pressedColor() { }

	public void set_pressedColor(Color value) { }

	public Color get_selectedColor() { }

	public void set_selectedColor(Color value) { }

	public Color get_disabledColor() { }

	public void set_disabledColor(Color value) { }

	public float get_colorMultiplier() { }

	public void set_colorMultiplier(float value) { }

	public float get_fadeDuration() { }

	public void set_fadeDuration(float value) { }

	public static ColorBlock get_defaultColorBlock() { }

	public override bool Equals(object obj) { }

	public bool Equals(ColorBlock other) { }

	public static bool op_Equality(ColorBlock point1, ColorBlock point2) { }

	public static bool op_Inequality(ColorBlock point1, ColorBlock point2) { }

	public override int GetHashCode() { }

}


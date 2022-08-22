public struct StyleColor : IStyleValue<Color>, IEquatable<StyleColor> // TypeDefIndex: 4710
{	private StyleKeyword m_Keyword; // 0x0
	private Color m_Value; // 0x4
	private int m_Specificity; // 0x14

	public Color value { get; }
	public StyleKeyword keyword { get; }


	public Color get_value() { }

	public StyleKeyword get_keyword() { }

	public void .ctor(Color v) { }

	internal void .ctor(Color v, StyleKeyword keyword) { }

	public static bool op_Equality(StyleColor lhs, StyleColor rhs) { }

	public static StyleColor op_Implicit(Color v) { }

	public bool Equals(StyleColor other) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

}


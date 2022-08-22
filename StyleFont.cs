public struct StyleFont : IStyleValue<Font>, IEquatable<StyleFont> // TypeDefIndex: 4713
{	private StyleKeyword m_Keyword; // 0x0
	private Font m_Value; // 0x8
	private int m_Specificity; // 0x10

	public Font value { get; }
	public StyleKeyword keyword { get; }


	public Font get_value() { }

	public StyleKeyword get_keyword() { }

	public static bool op_Equality(StyleFont lhs, StyleFont rhs) { }

	public bool Equals(StyleFont other) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

}


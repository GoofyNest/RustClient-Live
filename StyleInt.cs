public struct StyleInt : IStyleValue<int>, IEquatable<StyleInt> // TypeDefIndex: 4717
{
	private StyleKeyword m_Keyword; 
	private int m_Value; 
	private int m_Specificity; 

	public int value { get; }
	internal int specificity { get; }
	public StyleKeyword keyword { get; }


	public int get_value() { }

	internal int get_specificity() { }

	public StyleKeyword get_keyword() { }

	public void .ctor(int v) { }

	internal void .ctor(int v, StyleKeyword keyword) { }

	public static bool op_Equality(StyleInt lhs, StyleInt rhs) { }

	public static StyleInt op_Implicit(int v) { }

	public bool Equals(StyleInt other) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

}


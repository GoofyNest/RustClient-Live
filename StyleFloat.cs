public struct StyleFloat : IStyleValue<float>, IEquatable<StyleFloat> // TypeDefIndex: 4712
{
	private StyleKeyword m_Keyword; 
	private float m_Value; 
	private int m_Specificity; 

public float value { get; }
public StyleKeyword keyword { get; }


public float get_value() { }

public StyleKeyword get_keyword() { }

public void .ctor(float v) { }

internal void .ctor(float v, StyleKeyword keyword) { }

public static bool op_Equality(StyleFloat lhs, StyleFloat rhs) { }

public static StyleFloat op_Implicit(float v) { }

public bool Equals(StyleFloat other) { }

public override bool Equals(object obj) { }

public override int GetHashCode() { }

public override string ToString() { }

}


public struct StyleLength : IStyleValue<Length>, IEquatable<StyleLength> // TypeDefIndex: 4715
{
	private StyleKeyword m_Keyword; 
	private Length m_Value; 
	private int m_Specificity; 

public Length value { get; }
public StyleKeyword keyword { get; }


public Length get_value() { }

public StyleKeyword get_keyword() { }

internal void .ctor(Length v, StyleKeyword keyword) { }

public static bool op_Equality(StyleLength lhs, StyleLength rhs) { }

public bool Equals(StyleLength other) { }

public override bool Equals(object obj) { }

public override int GetHashCode() { }

public override string ToString() { }

}


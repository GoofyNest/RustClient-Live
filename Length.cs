public struct Length : IEquatable<Length> // TypeDefIndex: 4709
{
	private float m_Value; 
	private LengthUnit m_Unit; 

public float value { get; }
public LengthUnit unit { get; }


public float get_value() { }

public LengthUnit get_unit() { }

public void .ctor(float value) { }

public void .ctor(float value, LengthUnit unit) { }

public static bool op_Equality(Length lhs, Length rhs) { }

public bool Equals(Length other) { }

public override bool Equals(object obj) { }

public override int GetHashCode() { }

public override string ToString() { }

}


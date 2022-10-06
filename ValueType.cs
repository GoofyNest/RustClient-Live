public abstract class ValueType // TypeDefIndex: 417
{

	protected void .ctor() { }

	private static bool InternalEquals(object o1, object o2, out object[] fields) { }

	internal static bool DefaultEquals(object o1, object o2) { }

	public override bool Equals(object obj) { }

	internal static int InternalGetHashCode(object o, out object[] fields) { }

	public override int GetHashCode() { }

	public override string ToString() { }

}

internal enum ValueType // TypeDefIndex: 4252
{
	public int value__; 
	public const ValueType Unknown = -1;
	public const ValueType Null = 0;
	public const ValueType Bool = 1;
	public const ValueType Numeric = 2;
	public const ValueType Str = 3;
	public const ValueType Float = 4;
	public const ValueType Decimal = 5;
	public const ValueType Object = 6;
	public const ValueType Date = 7;

}

public enum ValueType // TypeDefIndex: 8146
{
	public int value__; 
	public const ValueType String = 0;
	public const ValueType Number = 1;
	public const ValueType Object = 2;
	public const ValueType Array = 3;
	public const ValueType Boolean = 4;
	public const ValueType Null = 5;

}


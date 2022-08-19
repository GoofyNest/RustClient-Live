public abstract class ValueType // TypeDefIndex: 417
{	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x2142550 Offset: 0x2141950 VA: 0x182142550
	private static bool InternalEquals(object o1, object o2, out object[] fields) { }

	// RVA: 0x21422C0 Offset: 0x21416C0 VA: 0x1821422C0
	internal static bool DefaultEquals(object o1, object o2) { }

	// RVA: 0x10D0260 Offset: 0x10CF660 VA: 0x1810D0260 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2142560 Offset: 0x2141960 VA: 0x182142560
	internal static int InternalGetHashCode(object o, out object[] fields) { }

	// RVA: 0x21424C0 Offset: 0x21418C0 VA: 0x1821424C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2142570 Offset: 0x2141970 VA: 0x182142570 Slot: 3
	public override string ToString() { }

}

internal enum ValueType // TypeDefIndex: 4249
{	// Fields
	public int value__; // 0x0
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

public enum ValueType // TypeDefIndex: 8138
{	// Fields
	public int value__; // 0x0
	public const ValueType String = 0;
	public const ValueType Number = 1;
	public const ValueType Object = 2;
	public const ValueType Array = 3;
	public const ValueType Boolean = 4;
	public const ValueType Null = 5;

}


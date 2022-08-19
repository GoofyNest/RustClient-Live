internal static class BigIntegerCalculator // TypeDefIndex: 3965
{	// Fields
	private static int ReducerThreshold; // 0x0
	private static int SquareThreshold; // 0x4
	private static int AllocationThreshold; // 0x8
	private static int MultiplyThreshold; // 0xC

	// Methods

	// RVA: 0x2227DD0 Offset: 0x22271D0 VA: 0x182227DD0
	public static uint[] Add(uint[] left, uint right) { }

	// RVA: 0x2227C10 Offset: 0x2227010 VA: 0x182227C10
	public static uint[] Add(uint[] left, uint[] right) { }

	// RVA: 0x2227D20 Offset: 0x2227120 VA: 0x182227D20
	private static void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x2227BA0 Offset: 0x2226FA0 VA: 0x182227BA0
	private static void AddSelf(uint* left, int leftLength, uint* right, int rightLength) { }

	// RVA: 0x2228DF0 Offset: 0x22281F0 VA: 0x182228DF0
	public static uint[] Subtract(uint[] left, uint right) { }

	// RVA: 0x2228EE0 Offset: 0x22282E0 VA: 0x182228EE0
	public static uint[] Subtract(uint[] left, uint[] right) { }

	// RVA: 0x2228D40 Offset: 0x2228140 VA: 0x182228D40
	private static void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x2227EE0 Offset: 0x22272E0 VA: 0x182227EE0
	public static int Compare(uint[] left, uint[] right) { }

	// RVA: 0x2228B70 Offset: 0x2227F70 VA: 0x182228B70
	public static uint[] Square(uint[] value) { }

	// RVA: 0x22286F0 Offset: 0x2227AF0 VA: 0x1822286F0
	private static void Square(uint* value, int valueLength, uint* bits, int bitsLength) { }

	// RVA: 0x22284F0 Offset: 0x22278F0 VA: 0x1822284F0
	public static uint[] Multiply(uint[] left, uint right) { }

	// RVA: 0x22285E0 Offset: 0x22279E0 VA: 0x1822285E0
	public static uint[] Multiply(uint[] left, uint[] right) { }

	// RVA: 0x2227F70 Offset: 0x2227370 VA: 0x182227F70
	private static void Multiply(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x2228C40 Offset: 0x2228040 VA: 0x182228C40
	private static void SubtractCore(uint* left, int leftLength, uint* right, int rightLength, uint* core, int coreLength) { }

	// RVA: 0x2229040 Offset: 0x2228440 VA: 0x182229040
	private static void .cctor() { }

}


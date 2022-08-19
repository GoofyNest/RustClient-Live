public struct IntPtr : ISerializable // TypeDefIndex: 369
{	// Fields
	private void* m_value; // 0x0
	public static readonly IntPtr Zero; // 0x0

	// Properties
	public static int Size { get; }

	// Methods

	[ReliabilityContractAttribute] // RVA: 0x8D550 Offset: 0x8C950 VA: 0x18008D550
	// RVA: 0x1DFF50 Offset: 0x1DF350 VA: 0x1801DFF50
	public void .ctor(int value) { }

	[ReliabilityContractAttribute] // RVA: 0x8D550 Offset: 0x8C950 VA: 0x18008D550
	// RVA: 0x1D2D40 Offset: 0x1D2140 VA: 0x1801D2D40
	public void .ctor(long value) { }

	[CLSCompliantAttribute] // RVA: 0x8D7E0 Offset: 0x8CBE0 VA: 0x18008D7E0
	[ReliabilityContractAttribute] // RVA: 0x8D7E0 Offset: 0x8CBE0 VA: 0x18008D7E0
	// RVA: 0x1D2D40 Offset: 0x1D2140 VA: 0x1801D2D40
	public void .ctor(void* value) { }

	// RVA: 0x1FB9C0 Offset: 0x1FADC0 VA: 0x1801FB9C0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x8B0DD0 Offset: 0x8B01D0 VA: 0x1808B0DD0
	public static int get_Size() { }

	// RVA: 0x1FB8B0 Offset: 0x1FACB0 VA: 0x1801FB8B0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1FB820 Offset: 0x1FAC20 VA: 0x1801FB820 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850 Slot: 2
	public override int GetHashCode() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1FB940 Offset: 0x1FAD40 VA: 0x1801FB940
	public long ToInt64() { }

	[ReliabilityContractAttribute] // RVA: 0x7D700 Offset: 0x7CB00 VA: 0x18007D700
	[CLSCompliantAttribute] // RVA: 0x7D700 Offset: 0x7CB00 VA: 0x18007D700
	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	public void* ToPointer() { }

	// RVA: 0x1FB950 Offset: 0x1FAD50 VA: 0x1801FB950 Slot: 3
	public override string ToString() { }

	// RVA: 0x1FB980 Offset: 0x1FAD80 VA: 0x1801FB980
	public string ToString(string format) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0xAE1170 Offset: 0xAE0570 VA: 0x180AE1170
	public static bool op_Equality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x129EBD0 Offset: 0x129DFD0 VA: 0x18129EBD0
	public static bool op_Inequality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContractAttribute] // RVA: 0x8D550 Offset: 0x8C950 VA: 0x18008D550
	// RVA: 0x1455F30 Offset: 0x1455330 VA: 0x181455F30
	public static IntPtr op_Explicit(int value) { }

	[ReliabilityContractAttribute] // RVA: 0x8D550 Offset: 0x8C950 VA: 0x18008D550
	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80
	public static IntPtr op_Explicit(long value) { }

	[CLSCompliantAttribute] // RVA: 0x8D7E0 Offset: 0x8CBE0 VA: 0x18008D7E0
	[ReliabilityContractAttribute] // RVA: 0x8D7E0 Offset: 0x8CBE0 VA: 0x18008D7E0
	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80
	public static IntPtr op_Explicit(void* value) { }

	// RVA: 0x6BFDB0 Offset: 0x6BF1B0 VA: 0x1806BFDB0
	public static int op_Explicit(IntPtr value) { }

	// RVA: 0xED4D30 Offset: 0xED4130 VA: 0x180ED4D30
	public static long op_Explicit(IntPtr value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80
	public static void* op_Explicit(IntPtr value) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1186B0 Offset: 0x117AB0 VA: 0x1801186B0
	internal bool IsNull() { }

}


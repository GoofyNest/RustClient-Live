public struct IntPtr : ISerializable // TypeDefIndex: 369
{	private void* m_value; // 0x0
	public static readonly IntPtr Zero; // 0x0

	public static int Size { get; }


	[ReliabilityContractAttribute] // RVA: 0x8D550 Offset: 0x8C950 VA: 0x18008D550
	public void .ctor(int value) { }

	[ReliabilityContractAttribute] // RVA: 0x8D550 Offset: 0x8C950 VA: 0x18008D550
	public void .ctor(long value) { }

	[CLSCompliantAttribute] // RVA: 0x8D7E0 Offset: 0x8CBE0 VA: 0x18008D7E0
	[ReliabilityContractAttribute] // RVA: 0x8D7E0 Offset: 0x8CBE0 VA: 0x18008D7E0
	public void .ctor(void* value) { }

	private void .ctor(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public static int get_Size() { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public long ToInt64() { }

	[ReliabilityContractAttribute] // RVA: 0x7D700 Offset: 0x7CB00 VA: 0x18007D700
	[CLSCompliantAttribute] // RVA: 0x7D700 Offset: 0x7CB00 VA: 0x18007D700
	public void* ToPointer() { }

	public override string ToString() { }

	public string ToString(string format) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public static bool op_Equality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public static bool op_Inequality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContractAttribute] // RVA: 0x8D550 Offset: 0x8C950 VA: 0x18008D550
	public static IntPtr op_Explicit(int value) { }

	[ReliabilityContractAttribute] // RVA: 0x8D550 Offset: 0x8C950 VA: 0x18008D550
	public static IntPtr op_Explicit(long value) { }

	[CLSCompliantAttribute] // RVA: 0x8D7E0 Offset: 0x8CBE0 VA: 0x18008D7E0
	[ReliabilityContractAttribute] // RVA: 0x8D7E0 Offset: 0x8CBE0 VA: 0x18008D7E0
	public static IntPtr op_Explicit(void* value) { }

	public static int op_Explicit(IntPtr value) { }

	public static long op_Explicit(IntPtr value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static void* op_Explicit(IntPtr value) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	internal bool IsNull() { }

}


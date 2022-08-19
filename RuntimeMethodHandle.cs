public struct RuntimeMethodHandle : ISerializable // TypeDefIndex: 390
{	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x1D2D40 Offset: 0x1D2140 VA: 0x1801D2D40
	internal void .ctor(IntPtr v) { }

	// RVA: 0x1DED80 Offset: 0x1DE180 VA: 0x1801DED80
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	public IntPtr get_Value() { }

	// RVA: 0x1DED20 Offset: 0x1DE120 VA: 0x1801DED20 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1DEC10 Offset: 0x1DE010 VA: 0x1801DEC10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x14C360 Offset: 0x14B760 VA: 0x18014C360 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1293810 Offset: 0x1292C10 VA: 0x181293810
	internal static string ConstructInstantiation(RuntimeMethodInfo method, TypeNameFormatFlags format) { }

	// RVA: 0x1DED40 Offset: 0x1DE140 VA: 0x1801DED40
	internal bool IsNullHandle() { }

}


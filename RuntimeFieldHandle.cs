public struct RuntimeFieldHandle : ISerializable // TypeDefIndex: 389
{	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x1D2D40 Offset: 0x1D2140 VA: 0x1801D2D40
	internal void .ctor(IntPtr v) { }

	// RVA: 0x1DEA90 Offset: 0x1DDE90 VA: 0x1801DEA90
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	public IntPtr get_Value() { }

	// RVA: 0x1DEA70 Offset: 0x1DDE70 VA: 0x1801DEA70 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1DE960 Offset: 0x1DDD60 VA: 0x1801DE960 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x14C360 Offset: 0x14B760 VA: 0x18014C360 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1293800 Offset: 0x1292C00 VA: 0x181293800
	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

	// RVA: 0x1293800 Offset: 0x1292C00 VA: 0x181293800
	internal static void SetValue(RtFieldInfo field, object obj, object value, RuntimeType fieldType, FieldAttributes fieldAttr, RuntimeType declaringType, ref bool domainInitialized) { }

	// RVA: 0x12937F0 Offset: 0x1292BF0 VA: 0x1812937F0
	internal static void SetValueDirect(RtFieldInfo field, RuntimeType fieldType, void* pTypedRef, object value, RuntimeType contextType) { }

}


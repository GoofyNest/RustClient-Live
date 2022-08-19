internal struct ResourceLocator // TypeDefIndex: 494
{	// Fields
	internal object _value; // 0x0
	internal int _dataPos; // 0x8

	// Properties
	internal int DataPosition { get; }
	internal object Value { get; set; }

	// Methods

	// RVA: 0x14C720 Offset: 0x14BB20 VA: 0x18014C720
	internal void .ctor(int dataPos, object value) { }

	// RVA: 0x122CA0 Offset: 0x1220A0 VA: 0x180122CA0
	internal int get_DataPosition() { }

	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	internal object get_Value() { }

	// RVA: 0xF1380 Offset: 0xF0780 VA: 0x1800F1380
	internal void set_Value(object value) { }

	// RVA: 0xFE74C0 Offset: 0xFE68C0 VA: 0x180FE74C0
	internal static bool CanCache(ResourceTypeCode value) { }

}


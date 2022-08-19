internal struct Range // TypeDefIndex: 4283
{	// Fields
	private int _min; // 0x0
	private int _max; // 0x4
	private bool _isNotNull; // 0x8

	// Properties
	public int Count { get; }
	public bool IsNull { get; }
	public int Min { get; }

	// Methods

	// RVA: 0x137690 Offset: 0x136A90 VA: 0x180137690
	public void .ctor(int min, int max) { }

	// RVA: 0x137700 Offset: 0x136B00 VA: 0x180137700
	public int get_Count() { }

	// RVA: 0x137720 Offset: 0x136B20 VA: 0x180137720
	public bool get_IsNull() { }

	// RVA: 0x137730 Offset: 0x136B30 VA: 0x180137730
	public int get_Min() { }

	// RVA: 0x137640 Offset: 0x136A40 VA: 0x180137640
	internal void CheckNull() { }

}


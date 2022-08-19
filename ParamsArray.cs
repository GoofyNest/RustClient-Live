internal struct ParamsArray // TypeDefIndex: 286
{	// Fields
	private static readonly object[] oneArgArray; // 0x0
	private static readonly object[] twoArgArray; // 0x8
	private static readonly object[] threeArgArray; // 0x10
	private readonly object arg0; // 0x0
	private readonly object arg1; // 0x8
	private readonly object arg2; // 0x10
	private readonly object[] args; // 0x18

	// Properties
	public int Length { get; }
	public object Item { get; }

	// Methods

	// RVA: 0x2154D0 Offset: 0x2148D0 VA: 0x1802154D0
	public void .ctor(object arg0) { }

	// RVA: 0x215650 Offset: 0x214A50 VA: 0x180215650
	public void .ctor(object arg0, object arg1) { }

	// RVA: 0x215410 Offset: 0x214810 VA: 0x180215410
	public void .ctor(object arg0, object arg1, object arg2) { }

	// RVA: 0x215570 Offset: 0x214970 VA: 0x180215570
	public void .ctor(object[] args) { }

	// RVA: 0x215770 Offset: 0x214B70 VA: 0x180215770
	public int get_Length() { }

	// RVA: 0x215710 Offset: 0x214B10 VA: 0x180215710
	public object get_Item(int index) { }

	// RVA: 0x2153B0 Offset: 0x2147B0 VA: 0x1802153B0
	private object GetAtSlow(int index) { }

	// RVA: 0x18CD2A0 Offset: 0x18CC6A0 VA: 0x1818CD2A0
	private static void .cctor() { }

}


internal class KeySequence // TypeDefIndex: 2151
{	// Fields
	private TypedObject[] ks; // 0x10
	private int dim; // 0x18
	private int hashcode; // 0x1C
	private int posline; // 0x20
	private int poscol; // 0x24

	// Properties
	public int PosLine { get; }
	public int PosCol { get; }
	public object Item { get; set; }

	// Methods

	// RVA: 0xB0C680 Offset: 0xB0BA80 VA: 0x180B0C680
	internal void .ctor(int dim, int line, int col) { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public int get_PosLine() { }

	// RVA: 0x7E8DA0 Offset: 0x7E81A0 VA: 0x1807E8DA0
	public int get_PosCol() { }

	// RVA: 0xA4F9F0 Offset: 0xA4EDF0 VA: 0x180A4F9F0
	public object get_Item(int index) { }

	// RVA: 0xB0C710 Offset: 0xB0BB10 VA: 0x180B0C710
	public void set_Item(int index, object value) { }

	// RVA: 0xB0C4D0 Offset: 0xB0B8D0 VA: 0x180B0C4D0
	internal bool IsQualified() { }

	// RVA: 0xB0C000 Offset: 0xB0B400 VA: 0x180B0C000 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xB0BED0 Offset: 0xB0B2D0 VA: 0x180B0BED0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xB0C530 Offset: 0xB0B930 VA: 0x180B0C530 Slot: 3
	public override string ToString() { }

}


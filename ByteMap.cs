public class ByteMap // TypeDefIndex: 10277
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int size; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int bytes; // 0x14
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private byte[] values; // 0x18

	// Properties
	public int Size { get; }
	public uint Item { get; set; }

	// Methods

	// RVA: 0x70C220 Offset: 0x70B620 VA: 0x18070C220
	public void .ctor(int size, int bytes = 1) { }

	// RVA: 0x70C1D0 Offset: 0x70B5D0 VA: 0x18070C1D0
	public void .ctor(int size, byte[] values, int bytes = 1) { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public int get_Size() { }

	// RVA: 0x70C2A0 Offset: 0x70B6A0 VA: 0x18070C2A0
	public uint get_Item(int x, int y) { }

	// RVA: 0x70C4B0 Offset: 0x70B8B0 VA: 0x18070C4B0
	public void set_Item(int x, int y, uint value) { }

}


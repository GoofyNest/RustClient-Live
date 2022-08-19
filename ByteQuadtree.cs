public sealed class ByteQuadtree // TypeDefIndex: 10278
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int size; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int levels; // 0x14
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ByteMap[] values; // 0x18

	// Properties
	public int Size { get; }
	public ByteQuadtree.Element Root { get; }

	// Methods

	// RVA: 0x70C7B0 Offset: 0x70BBB0 VA: 0x18070C7B0
	public void UpdateValues(byte[] baseValues) { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public int get_Size() { }

	// RVA: 0x70CB90 Offset: 0x70BF90 VA: 0x18070CB90
	public ByteQuadtree.Element get_Root() { }

	// RVA: 0x70C6E0 Offset: 0x70BAE0 VA: 0x18070C6E0
	private ByteMap CreateLevel(int level) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public struct ByteQuadtree.Element // TypeDefIndex: 10279
{	// Fields
	private ByteQuadtree source; // 0x0
	private int x; // 0x8
	private int y; // 0xC
	private int level; // 0x10

	// Properties
	public bool IsLeaf { get; }
	public bool IsRoot { get; }
	public int ByteMap { get; }
	public uint Value { get; }
	public Vector2 Coords { get; }
	public int Depth { get; }
	public ByteQuadtree.Element Parent { get; }
	public ByteQuadtree.Element Child1 { get; }
	public ByteQuadtree.Element Child2 { get; }
	public ByteQuadtree.Element Child3 { get; }
	public ByteQuadtree.Element Child4 { get; }
	public ByteQuadtree.Element MaxChild { get; }
	public ByteQuadtree.Element RandChild { get; }

	// Methods

	// RVA: 0xF4960 Offset: 0xF3D60 VA: 0x1800F4960
	public void .ctor(ByteQuadtree source, int x, int y, int level) { }

	// RVA: 0xF4A90 Offset: 0xF3E90 VA: 0x1800F4A90
	public bool get_IsLeaf() { }

	// RVA: 0xF4AA0 Offset: 0xF3EA0 VA: 0x1800F4AA0
	public bool get_IsRoot() { }

	// RVA: 0xF3DA0 Offset: 0xF31A0 VA: 0x1800F3DA0
	public int get_ByteMap() { }

	// RVA: 0xF4BE0 Offset: 0xF3FE0 VA: 0x1800F4BE0
	public uint get_Value() { }

	// RVA: 0xF4A30 Offset: 0xF3E30 VA: 0x1800F4A30
	public Vector2 get_Coords() { }

	// RVA: 0xF4A70 Offset: 0xF3E70 VA: 0x1800F4A70
	public int get_Depth() { }

	// RVA: 0xF4AF0 Offset: 0xF3EF0 VA: 0x1800F4AF0
	public ByteQuadtree.Element get_Parent() { }

	// RVA: 0xF49B0 Offset: 0xF3DB0 VA: 0x1800F49B0
	public ByteQuadtree.Element get_Child1() { }

	// RVA: 0xF49D0 Offset: 0xF3DD0 VA: 0x1800F49D0
	public ByteQuadtree.Element get_Child2() { }

	// RVA: 0xF49F0 Offset: 0xF3DF0 VA: 0x1800F49F0
	public ByteQuadtree.Element get_Child3() { }

	// RVA: 0xF4A10 Offset: 0xF3E10 VA: 0x1800F4A10
	public ByteQuadtree.Element get_Child4() { }

	// RVA: 0xF4AD0 Offset: 0xF3ED0 VA: 0x1800F4AD0
	public ByteQuadtree.Element get_MaxChild() { }

	// RVA: 0xF4BC0 Offset: 0xF3FC0 VA: 0x1800F4BC0
	public ByteQuadtree.Element get_RandChild() { }

}


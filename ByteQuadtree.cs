public sealed class ByteQuadtree // TypeDefIndex: 10278
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int size; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int levels; // 0x14
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ByteMap[] values; // 0x18

	public int Size { get; }
	public ByteQuadtree.Element Root { get; }


	public void UpdateValues(byte[] baseValues) { }

	public int get_Size() { }

	public ByteQuadtree.Element get_Root() { }

	private ByteMap CreateLevel(int level) { }

	public void .ctor() { }

}

public struct ByteQuadtree.Element // TypeDefIndex: 10279
{	private ByteQuadtree source; // 0x0
	private int x; // 0x8
	private int y; // 0xC
	private int level; // 0x10

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


	public void .ctor(ByteQuadtree source, int x, int y, int level) { }

	public bool get_IsLeaf() { }

	public bool get_IsRoot() { }

	public int get_ByteMap() { }

	public uint get_Value() { }

	public Vector2 get_Coords() { }

	public int get_Depth() { }

	public ByteQuadtree.Element get_Parent() { }

	public ByteQuadtree.Element get_Child1() { }

	public ByteQuadtree.Element get_Child2() { }

	public ByteQuadtree.Element get_Child3() { }

	public ByteQuadtree.Element get_Child4() { }

	public ByteQuadtree.Element get_MaxChild() { }

	public ByteQuadtree.Element get_RandChild() { }

}


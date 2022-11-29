public sealed class ByteQuadtree // TypeDefIndex: 12029
{
	[SerializeField] 
	private int size; 
	[SerializeField] 
	private int levels; 
	[SerializeField] 
	private ByteMap[] values; 

	public int Size { get; }
	public ByteQuadtree.Element Root { get; }


	public void UpdateValues(byte[] baseValues) { }

	public int get_Size() { }

	public ByteQuadtree.Element get_Root() { }

	private ByteMap CreateLevel(int level) { }

	public void .ctor() { }

}

public struct ByteQuadtree.Element // TypeDefIndex: 12030
{
	private ByteQuadtree source; 
	private int x; 
	private int y; 
	private int level; 

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


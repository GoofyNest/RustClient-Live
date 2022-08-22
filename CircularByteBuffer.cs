internal class CircularByteBuffer // TypeDefIndex: 7386
{	private byte[] _DataArray; // 0x10
	private int _Index; // 0x18
	private int _Length; // 0x1C
	private int _NumValid; // 0x20

	internal byte Item { get; }
	internal int NumValid { get; }


	internal void .ctor(int size) { }

	internal byte get_Item(int index) { }

	internal int get_NumValid() { }

	internal byte Push(byte newValue) { }

	private byte InternalGet(int offset) { }

	public override string ToString() { }

}


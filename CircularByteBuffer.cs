internal class CircularByteBuffer // TypeDefIndex: 7386
{
	private byte[] _DataArray; 
	private int _Index; 
	private int _Length; 
	private int _NumValid; 

internal byte Item { get; }
internal int NumValid { get; }


internal void .ctor(int size) { }

internal byte get_Item(int index) { }

internal int get_NumValid() { }

internal byte Push(byte newValue) { }

private byte InternalGet(int offset) { }

public override string ToString() { }

}


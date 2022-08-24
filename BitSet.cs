internal sealed class BitSet // TypeDefIndex: 2141
{
	private int count; 
	private uint[] bits; 

public int Count { get; }
public bool Item { get; }
public bool IsEmpty { get; }


private void .ctor() { }

public void .ctor(int count) { }

public int get_Count() { }

public bool get_Item(int index) { }

public void Clear() { }

public void Set(int index) { }

public bool Get(int index) { }

public int NextSet(int startFrom) { }

public void And(BitSet other) { }

public void Or(BitSet other) { }

public override int GetHashCode() { }

public override bool Equals(object obj) { }

public BitSet Clone() { }

public bool get_IsEmpty() { }

public bool Intersects(BitSet other) { }

private int Subscript(int bitIndex) { }

private void EnsureLength(int nRequiredLength) { }

}


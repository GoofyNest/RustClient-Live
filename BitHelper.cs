internal sealed class BitHelper // TypeDefIndex: 3253
{	private readonly int _length; // 0x10
	private readonly int* _arrayPtr; // 0x18
	private readonly int[] _array; // 0x20
	private readonly bool _useStackAlloc; // 0x28


	internal void .ctor(int* bitArrayPtr, int length) { }

	internal void .ctor(int[] bitArray, int length) { }

	internal void MarkBit(int bitPosition) { }

	internal bool IsMarked(int bitPosition) { }

	internal static int ToIntArrayLength(int n) { }

}


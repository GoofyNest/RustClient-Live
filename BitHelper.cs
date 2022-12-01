internal sealed class BitHelper // TypeDefIndex: 3253
{
	private readonly int _length;
	private readonly int* _arrayPtr;
	private readonly int[] _array;
	private readonly bool _useStackAlloc;


	internal void .ctor(int* bitArrayPtr, int length) { }

	internal void .ctor(int[] bitArray, int length) { }

	internal void MarkBit(int bitPosition) { }

	internal bool IsMarked(int bitPosition) { }

	internal static int ToIntArrayLength(int n) { }

}


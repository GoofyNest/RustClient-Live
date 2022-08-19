internal sealed class BitHelper // TypeDefIndex: 3253
{	// Fields
	private readonly int _length; // 0x10
	private readonly int* _arrayPtr; // 0x18
	private readonly int[] _array; // 0x20
	private readonly bool _useStackAlloc; // 0x28

	// Methods

	// RVA: 0x2224000 Offset: 0x2223400 VA: 0x182224000
	internal void .ctor(int* bitArrayPtr, int length) { }

	// RVA: 0x2224040 Offset: 0x2223440 VA: 0x182224040
	internal void .ctor(int[] bitArray, int length) { }

	// RVA: 0x2223F60 Offset: 0x2223360 VA: 0x182223F60
	internal void MarkBit(int bitPosition) { }

	// RVA: 0x2223ED0 Offset: 0x22232D0 VA: 0x182223ED0
	internal bool IsMarked(int bitPosition) { }

	// RVA: 0x2223FE0 Offset: 0x22233E0 VA: 0x182223FE0
	internal static int ToIntArrayLength(int n) { }

}


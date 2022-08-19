public static class MemoryMarshal // TypeDefIndex: 6735
{	// Methods

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BF450 Offset: 0x14BE850 VA: 0x1814BF450
	|-MemoryMarshal.GetReference<byte>
	|-MemoryMarshal.GetReference<object>
	*/

	// RVA: -1 Offset: -1
	public static Span<TTo> Cast<TFrom, TTo>(Span<TFrom> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE81F30 Offset: 0xE81330 VA: 0x180E81F30
	|-MemoryMarshal.Cast<byte, short>
	*/

}


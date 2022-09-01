public static class MemoryMarshal // TypeDefIndex: 6736
{

	public static ref T GetReference<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-MemoryMarshal.GetReference<byte>
	|-MemoryMarshal.GetReference<object>
	*/

	public static Span<TTo> Cast<TFrom, TTo>(Span<TFrom> span) { }
	/* GenericInstMethod :
	|
	|-MemoryMarshal.Cast<byte, short>
	*/

}


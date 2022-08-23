internal static class Unsafe // TypeDefIndex: 1318
{
	public static ref T Add<T>(ref T source, int elementOffset) { }
	/* GenericInstMethod :
	|
	|-Unsafe.Add<byte>
	|
	|-Unsafe.Add<char>
	|
	|-Unsafe.Add<object>
	*/

	public static ref T AddByteOffset<T>(ref T source, IntPtr byteOffset) { }
	/* GenericInstMethod :
	|
	|-Unsafe.AddByteOffset<byte>
	|-Unsafe.AddByteOffset<char>
	|-Unsafe.AddByteOffset<object>
	*/

	public static T As<T>(object o) { }
	/* GenericInstMethod :
	|
	|-Unsafe.As<object>
	*/

	public static ref T AsRef<T>(void* source) { }
	/* GenericInstMethod :
	|
	|-Unsafe.AsRef<byte>
	|-Unsafe.AsRef<char>
	|-Unsafe.AsRef<object>
	*/

	public static IntPtr ByteOffset<T>(ref T origin, ref T target) { }
	/* GenericInstMethod :
	|
	|-Unsafe.ByteOffset<byte>
	|-Unsafe.ByteOffset<char>
	|-Unsafe.ByteOffset<object>
	*/

}

public static class Unsafe // TypeDefIndex: 6664
{
public static class Unsafe // TypeDefIndex: 6664

	[NonVersionableAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static int SizeOf<T>() { }
	/* GenericInstMethod :
	|
	|-Unsafe.SizeOf<byte>
	|
	|-Unsafe.SizeOf<short>
	|
	|-Unsafe.SizeOf<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void CopyBlock(ref byte destination, ref byte source, uint byteCount) { }

	[NonVersionableAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static T As<T>(object o) { }
	/* GenericInstMethod :
	|
	|-Unsafe.As<Pinnable<char>>
	|-Unsafe.As<IValueTaskSource>
	|-Unsafe.As<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static ref T AsRef<T>(void* source) { }
	/* GenericInstMethod :
	|
	|-Unsafe.AsRef<char>
	|-Unsafe.AsRef<byte>
	|-Unsafe.AsRef<short>
	|-Unsafe.AsRef<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static ref TTo As<TFrom, TTo>(ref TFrom source) { }
	/* GenericInstMethod :
	|
	|-Unsafe.As<byte, byte>
	|-Unsafe.As<byte, char>
	|-Unsafe.As<short, byte>
	|-Unsafe.As<short, char>
	|-Unsafe.As<object, byte>
	|-Unsafe.As<object, char>
	|-Unsafe.As<object, object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static ref T Add<T>(ref T source, int elementOffset) { }
	/* GenericInstMethod :
	|
	|-Unsafe.Add<byte>
	|
	|-Unsafe.Add<short>
	|
	|-Unsafe.Add<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static ref T Add<T>(ref T source, IntPtr elementOffset) { }
	/* GenericInstMethod :
	|
	|-Unsafe.Add<byte>
	|
	|-Unsafe.Add<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static ref T AddByteOffset<T>(ref T source, IntPtr byteOffset) { }
	/* GenericInstMethod :
	|
	|-Unsafe.AddByteOffset<byte>
	|-Unsafe.AddByteOffset<short>
	|-Unsafe.AddByteOffset<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static IntPtr ByteOffset<T>(ref T origin, ref T target) { }
	/* GenericInstMethod :
	|
	|-Unsafe.ByteOffset<byte>
	|-Unsafe.ByteOffset<char>
	|-Unsafe.ByteOffset<short>
	|-Unsafe.ByteOffset<object>
	*/

}


internal static class Unsafe // TypeDefIndex: 1318
{	// Methods

	// RVA: -1 Offset: -1
	public static ref T Add<T>(ref T source, int elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C1270 Offset: 0x14C0670 VA: 0x1814C1270
	|-Unsafe.Add<byte>
	|
	|-RVA: 0x14C1280 Offset: 0x14C0680 VA: 0x1814C1280
	|-Unsafe.Add<char>
	|
	|-RVA: 0x14C1290 Offset: 0x14C0690 VA: 0x1814C1290
	|-Unsafe.Add<object>
	*/

	// RVA: -1 Offset: -1
	public static ref T AddByteOffset<T>(ref T source, IntPtr byteOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C1260 Offset: 0x14C0660 VA: 0x1814C1260
	|-Unsafe.AddByteOffset<byte>
	|-Unsafe.AddByteOffset<char>
	|-Unsafe.AddByteOffset<object>
	*/

	// RVA: -1 Offset: -1
	public static T As<T>(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80
	|-Unsafe.As<object>
	*/

	// RVA: -1 Offset: -1
	public static ref T AsRef<T>(void* source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80
	|-Unsafe.AsRef<byte>
	|-Unsafe.AsRef<char>
	|-Unsafe.AsRef<object>
	*/

	// RVA: -1 Offset: -1
	public static IntPtr ByteOffset<T>(ref T origin, ref T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE84FC0 Offset: 0xE843C0 VA: 0x180E84FC0
	|-Unsafe.ByteOffset<byte>
	|-Unsafe.ByteOffset<char>
	|-Unsafe.ByteOffset<object>
	*/

}

public static class Unsafe // TypeDefIndex: 6664
{
// Namespace: System.Runtime.CompilerServices
public static class Unsafe // TypeDefIndex: 6664
	// Methods

	[NonVersionableAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static int SizeOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140
	|-Unsafe.SizeOf<byte>
	|
	|-RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0
	|-Unsafe.SizeOf<short>
	|
	|-RVA: 0x8B0DD0 Offset: 0x8B01D0 VA: 0x1808B0DD0
	|-Unsafe.SizeOf<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x231DED0 Offset: 0x231D2D0 VA: 0x18231DED0
	public static void CopyBlock(ref byte destination, ref byte source, uint byteCount) { }

	[NonVersionableAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static T As<T>(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80
	|-Unsafe.As<Pinnable<char>>
	|-Unsafe.As<IValueTaskSource>
	|-Unsafe.As<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static ref T AsRef<T>(void* source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80
	|-Unsafe.AsRef<char>
	|-Unsafe.AsRef<byte>
	|-Unsafe.AsRef<short>
	|-Unsafe.AsRef<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static ref TTo As<TFrom, TTo>(ref TFrom source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80
	|-Unsafe.As<byte, byte>
	|-Unsafe.As<byte, char>
	|-Unsafe.As<short, byte>
	|-Unsafe.As<short, char>
	|-Unsafe.As<object, byte>
	|-Unsafe.As<object, char>
	|-Unsafe.As<object, object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static ref T Add<T>(ref T source, int elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C1270 Offset: 0x14C0670 VA: 0x1814C1270
	|-Unsafe.Add<byte>
	|
	|-RVA: 0x14C1280 Offset: 0x14C0680 VA: 0x1814C1280
	|-Unsafe.Add<short>
	|
	|-RVA: 0x14C1290 Offset: 0x14C0690 VA: 0x1814C1290
	|-Unsafe.Add<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static ref T Add<T>(ref T source, IntPtr elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C1260 Offset: 0x14C0660 VA: 0x1814C1260
	|-Unsafe.Add<byte>
	|
	|-RVA: 0x14C12A0 Offset: 0x14C06A0 VA: 0x1814C12A0
	|-Unsafe.Add<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static ref T AddByteOffset<T>(ref T source, IntPtr byteOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C1260 Offset: 0x14C0660 VA: 0x1814C1260
	|-Unsafe.AddByteOffset<byte>
	|-Unsafe.AddByteOffset<short>
	|-Unsafe.AddByteOffset<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static IntPtr ByteOffset<T>(ref T origin, ref T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE84FC0 Offset: 0xE843C0 VA: 0x180E84FC0
	|-Unsafe.ByteOffset<byte>
	|-Unsafe.ByteOffset<char>
	|-Unsafe.ByteOffset<short>
	|-Unsafe.ByteOffset<object>
	*/

}


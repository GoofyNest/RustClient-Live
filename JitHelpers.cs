internal static class JitHelpers // TypeDefIndex: 1313
{
	internal static T UnsafeCast<T>(object o) { }
	/* GenericInstMethod :
	|
	|-JitHelpers.UnsafeCast<object>
	*/

	internal static int UnsafeEnumCast<T>(T val) { }
	/* GenericInstMethod :
	|
	|-JitHelpers.UnsafeEnumCast<ByteEnum>
	|-JitHelpers.UnsafeEnumCast<Int32Enum>
	*/

	internal static long UnsafeEnumCastLong<T>(T val) { }

}


public static class Marshal // TypeDefIndex: 1355
{	public static readonly int SystemMaxDBCSCharSize; // 0x0
	public static readonly int SystemDefaultCharSize; // 0x4


	public static IntPtr AllocCoTaskMem(int cb) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	public static IntPtr AllocHGlobal(IntPtr cb) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	public static IntPtr AllocHGlobal(int cb) { }

	internal static void copy_to_unmanaged(Array source, int startIndex, IntPtr destination, int length) { }

	internal static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length) { }

	public static void Copy(byte[] source, int startIndex, IntPtr destination, int length) { }

	public static void Copy(IntPtr[] source, int startIndex, IntPtr destination, int length) { }

	public static void Copy(IntPtr source, byte[] destination, int startIndex, int length) { }

	public static void Copy(IntPtr source, char[] destination, int startIndex, int length) { }

	public static void Copy(IntPtr source, float[] destination, int startIndex, int length) { }

	public static void Copy(IntPtr source, IntPtr[] destination, int startIndex, int length) { }

	public static void FreeBSTR(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public static void FreeHGlobal(IntPtr hglobal) { }

	private static void ClearUnicode(IntPtr ptr) { }

	public static void ZeroFreeGlobalAllocUnicode(IntPtr s) { }

	public static int GetHRForException(Exception e) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public static int GetLastWin32Error() { }

	public static string PtrToStringAnsi(IntPtr ptr) { }

	public static string PtrToStringUni(IntPtr ptr) { }

	public static string PtrToStringUni(IntPtr ptr, int len) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	public static object PtrToStructure(IntPtr ptr, Type structureType) { }

	public static T PtrToStructure<T>(IntPtr ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDB8C0 Offset: 0xBDACC0 VA: 0x180BDB8C0
	|-Marshal.PtrToStructure<UnityTls.unitytls_interface_struct>
	|-Marshal.PtrToStructure<object>
	|
	|-RVA: 0xBDB740 Offset: 0xBDAB40 VA: 0x180BDB740
	|-Marshal.PtrToStructure<NetMsg>
	|
	|-RVA: 0xBDB9A0 Offset: 0xBDADA0 VA: 0x180BDB9A0
	|-Marshal.PtrToStructure<Win32_FIXED_INFO>
	*/

	public static byte ReadByte(IntPtr ptr, int ofs) { }

	public static short ReadInt16(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public static int ReadInt32(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public static int ReadInt32(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public static long ReadInt64(IntPtr ptr) { }

	public static long ReadInt64(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public static IntPtr ReadIntPtr(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public static IntPtr ReadIntPtr(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	private static int ReleaseInternal(IntPtr pUnk) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public static int Release(IntPtr pUnk) { }

	public static int SizeOf(Type t) { }

	public static int SizeOf<T>(T structure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE81DB0 Offset: 0xE811B0 VA: 0x180E81DB0
	|-Marshal.SizeOf<Os.SECURITY_ATTRIBUTES>
	|
	|-RVA: 0xE81D40 Offset: 0xE81140 VA: 0x180E81D40
	|-Marshal.SizeOf<object>
	*/

	public static IntPtr StringToHGlobalAnsi(string s) { }

	public static IntPtr SecureStringToCoTaskMemUnicode(SecureString s) { }

	public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s) { }

	[ComVisibleAttribute] // RVA: 0xE0BC0 Offset: 0xDFFC0 VA: 0x1800E0BC0
	[ReliabilityContractAttribute] // RVA: 0xE0BC0 Offset: 0xDFFC0 VA: 0x1800E0BC0
	public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld) { }

	public static void StructureToPtr<T>(T structure, IntPtr ptr, bool fDeleteOld) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF037A0 Offset: 0xF02BA0 VA: 0x180F037A0
	|-Marshal.StructureToPtr<object>
	*/

	public static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index) { }

	public static IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE81E70 Offset: 0xE81270 VA: 0x180E81E70
	|-Marshal.UnsafeAddrOfPinnedArrayElement<byte>
	|
	|-RVA: 0xE81ED0 Offset: 0xE812D0 VA: 0x180E81ED0
	|-Marshal.UnsafeAddrOfPinnedArrayElement<object>
	*/

	public static void WriteInt16(IntPtr ptr, int ofs, short val) { }

	private static IntPtr GetFunctionPointerForDelegateInternal(Delegate d) { }

	public static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE81C80 Offset: 0xE81080 VA: 0x180E81C80
	|-Marshal.GetFunctionPointerForDelegate<BufferManager.FreeFn>
	|-Marshal.GetFunctionPointerForDelegate<object>
	|-Marshal.GetFunctionPointerForDelegate<OSSpecificSynchronizationContext.InvocationEntryDelegate>
	*/

	internal static void SetLastWin32Error(int error) { }

	private static void .cctor() { }

}


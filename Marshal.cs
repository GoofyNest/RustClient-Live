public static class Marshal // TypeDefIndex: 1355
{	// Fields
	public static readonly int SystemMaxDBCSCharSize; // 0x0
	public static readonly int SystemDefaultCharSize; // 0x4

	// Methods

	// RVA: 0xFE4E40 Offset: 0xFE4240 VA: 0x180FE4E40
	public static IntPtr AllocCoTaskMem(int cb) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	// RVA: 0xFE4E50 Offset: 0xFE4250 VA: 0x180FE4E50
	public static IntPtr AllocHGlobal(IntPtr cb) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	// RVA: 0xFE4E60 Offset: 0xFE4260 VA: 0x180FE4E60
	public static IntPtr AllocHGlobal(int cb) { }

	// RVA: 0xFE5D50 Offset: 0xFE5150 VA: 0x180FE5D50
	internal static void copy_to_unmanaged(Array source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0xFE5D40 Offset: 0xFE5140 VA: 0x180FE5D40
	internal static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length) { }

	// RVA: 0xFE4FD0 Offset: 0xFE43D0 VA: 0x180FE4FD0
	public static void Copy(byte[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0xFE5250 Offset: 0xFE4650 VA: 0x180FE5250
	public static void Copy(IntPtr[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0xFE51D0 Offset: 0xFE45D0 VA: 0x180FE51D0
	public static void Copy(IntPtr source, byte[] destination, int startIndex, int length) { }

	// RVA: 0xFE5150 Offset: 0xFE4550 VA: 0x180FE5150
	public static void Copy(IntPtr source, char[] destination, int startIndex, int length) { }

	// RVA: 0xFE50D0 Offset: 0xFE44D0 VA: 0x180FE50D0
	public static void Copy(IntPtr source, float[] destination, int startIndex, int length) { }

	// RVA: 0xFE5050 Offset: 0xFE4450 VA: 0x180FE5050
	public static void Copy(IntPtr source, IntPtr[] destination, int startIndex, int length) { }

	// RVA: 0xFE52D0 Offset: 0xFE46D0 VA: 0x180FE52D0
	public static void FreeBSTR(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0xFE52E0 Offset: 0xFE46E0 VA: 0x180FE52E0
	public static void FreeHGlobal(IntPtr hglobal) { }

	// RVA: 0xFE4EC0 Offset: 0xFE42C0 VA: 0x180FE4EC0
	private static void ClearUnicode(IntPtr ptr) { }

	// RVA: 0xFE5B80 Offset: 0xFE4F80 VA: 0x180FE5B80
	public static void ZeroFreeGlobalAllocUnicode(IntPtr s) { }

	// RVA: 0xFE5300 Offset: 0xFE4700 VA: 0x180FE5300
	public static int GetHRForException(Exception e) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0xFE5310 Offset: 0xFE4710 VA: 0x180FE5310
	public static int GetLastWin32Error() { }

	// RVA: 0xFE5320 Offset: 0xFE4720 VA: 0x180FE5320
	public static string PtrToStringAnsi(IntPtr ptr) { }

	// RVA: 0xFE5340 Offset: 0xFE4740 VA: 0x180FE5340
	public static string PtrToStringUni(IntPtr ptr) { }

	// RVA: 0xFE5330 Offset: 0xFE4730 VA: 0x180FE5330
	public static string PtrToStringUni(IntPtr ptr, int len) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0xFE5350 Offset: 0xFE4750 VA: 0x180FE5350
	public static object PtrToStructure(IntPtr ptr, Type structureType) { }

	// RVA: -1 Offset: -1
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

	// RVA: 0xFE5360 Offset: 0xFE4760 VA: 0x180FE5360
	public static byte ReadByte(IntPtr ptr, int ofs) { }

	// RVA: 0xFE5380 Offset: 0xFE4780 VA: 0x180FE5380
	public static short ReadInt16(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0xFE53D0 Offset: 0xFE47D0 VA: 0x180FE53D0
	public static int ReadInt32(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0xFE5410 Offset: 0xFE4810 VA: 0x180FE5410
	public static int ReadInt32(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0xFE54B0 Offset: 0xFE48B0 VA: 0x180FE54B0
	public static long ReadInt64(IntPtr ptr) { }

	// RVA: 0xFE5460 Offset: 0xFE4860 VA: 0x180FE5460
	public static long ReadInt64(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0xFE5620 Offset: 0xFE4A20 VA: 0x180FE5620
	public static IntPtr ReadIntPtr(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0xFE5500 Offset: 0xFE4900 VA: 0x180FE5500
	public static IntPtr ReadIntPtr(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0xFE5730 Offset: 0xFE4B30 VA: 0x180FE5730
	private static int ReleaseInternal(IntPtr pUnk) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0xFE5740 Offset: 0xFE4B40 VA: 0x180FE5740
	public static int Release(IntPtr pUnk) { }

	// RVA: 0xFE5AF0 Offset: 0xFE4EF0 VA: 0x180FE5AF0
	public static int SizeOf(Type t) { }

	// RVA: -1 Offset: -1
	public static int SizeOf<T>(T structure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE81DB0 Offset: 0xE811B0 VA: 0x180E81DB0
	|-Marshal.SizeOf<Os.SECURITY_ATTRIBUTES>
	|
	|-RVA: 0xE81D40 Offset: 0xE81140 VA: 0x180E81D40
	|-Marshal.SizeOf<object>
	*/

	// RVA: 0xFE5B00 Offset: 0xFE4F00 VA: 0x180FE5B00
	public static IntPtr StringToHGlobalAnsi(string s) { }

	// RVA: 0xFE57E0 Offset: 0xFE4BE0 VA: 0x180FE57E0
	public static IntPtr SecureStringToCoTaskMemUnicode(SecureString s) { }

	// RVA: 0xFE5A60 Offset: 0xFE4E60 VA: 0x180FE5A60
	public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s) { }

	[ComVisibleAttribute] // RVA: 0xE0BC0 Offset: 0xDFFC0 VA: 0x1800E0BC0
	[ReliabilityContractAttribute] // RVA: 0xE0BC0 Offset: 0xDFFC0 VA: 0x1800E0BC0
	// RVA: 0xFE5B10 Offset: 0xFE4F10 VA: 0x180FE5B10
	public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld) { }

	// RVA: -1 Offset: -1
	public static void StructureToPtr<T>(T structure, IntPtr ptr, bool fDeleteOld) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF037A0 Offset: 0xF02BA0 VA: 0x180F037A0
	|-Marshal.StructureToPtr<object>
	*/

	// RVA: 0xFE5B20 Offset: 0xFE4F20 VA: 0x180FE5B20
	public static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index) { }

	// RVA: -1 Offset: -1
	public static IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE81E70 Offset: 0xE81270 VA: 0x180E81E70
	|-Marshal.UnsafeAddrOfPinnedArrayElement<byte>
	|
	|-RVA: 0xE81ED0 Offset: 0xE812D0 VA: 0x180E81ED0
	|-Marshal.UnsafeAddrOfPinnedArrayElement<object>
	*/

	// RVA: 0xFE5B30 Offset: 0xFE4F30 VA: 0x180FE5B30
	public static void WriteInt16(IntPtr ptr, int ofs, short val) { }

	// RVA: 0xFE52F0 Offset: 0xFE46F0 VA: 0x180FE52F0
	private static IntPtr GetFunctionPointerForDelegateInternal(Delegate d) { }

	// RVA: -1 Offset: -1
	public static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE81C80 Offset: 0xE81080 VA: 0x180E81C80
	|-Marshal.GetFunctionPointerForDelegate<BufferManager.FreeFn>
	|-Marshal.GetFunctionPointerForDelegate<object>
	|-Marshal.GetFunctionPointerForDelegate<OSSpecificSynchronizationContext.InvocationEntryDelegate>
	*/

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal static void SetLastWin32Error(int error) { }

	// RVA: 0xFE5CE0 Offset: 0xFE50E0 VA: 0x180FE5CE0
	private static void .cctor() { }

}


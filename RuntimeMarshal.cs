internal static class RuntimeMarshal // TypeDefIndex: 11
{	// Methods

	// RVA: 0x16451A0 Offset: 0x16445A0 VA: 0x1816451A0
	internal static string PtrToUtf8String(IntPtr ptr) { }

	// RVA: 0x1645140 Offset: 0x1644540 VA: 0x181645140
	internal static SafeStringMarshal MarshalString(string str) { }

	// RVA: 0x16450B0 Offset: 0x16444B0 VA: 0x1816450B0
	private static int DecodeBlobSize(IntPtr in_ptr, out IntPtr out_ptr) { }

	// RVA: 0x1644FC0 Offset: 0x16443C0 VA: 0x181644FC0
	internal static byte[] DecodeBlobArray(IntPtr ptr) { }

	// RVA: 0x1644FA0 Offset: 0x16443A0 VA: 0x181644FA0
	internal static int AsciHexDigitValue(int c) { }

	// RVA: 0x1645130 Offset: 0x1644530 VA: 0x181645130
	internal static void FreeAssemblyName(ref MonoAssemblyName name, bool freeStruct) { }

}


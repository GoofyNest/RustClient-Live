internal static class RuntimeMarshal // TypeDefIndex: 11
{

	internal static string PtrToUtf8String(IntPtr ptr) { }

	internal static SafeStringMarshal MarshalString(string str) { }

	private static int DecodeBlobSize(IntPtr in_ptr, out IntPtr out_ptr) { }

	internal static byte[] DecodeBlobArray(IntPtr ptr) { }

	internal static int AsciHexDigitValue(int c) { }

	internal static void FreeAssemblyName(ref MonoAssemblyName name, bool freeStruct) { }

}


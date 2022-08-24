internal static class ManagedStreamHelpers // TypeDefIndex: 3517
{

	internal static void ValidateLoadFromStream(Stream stream) { }

	[RequiredByNativeCodeAttribute] 
	internal static void ManagedStreamRead(byte[] buffer, int offset, int count, Stream stream, IntPtr returnValueAddress) { }

	[RequiredByNativeCodeAttribute] 
	internal static void ManagedStreamSeek(long offset, uint origin, Stream stream, IntPtr returnValueAddress) { }

	[RequiredByNativeCodeAttribute] 
	internal static void ManagedStreamLength(Stream stream, IntPtr returnValueAddress) { }

}


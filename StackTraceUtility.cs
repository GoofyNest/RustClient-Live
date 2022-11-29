public static class StackTraceUtility // TypeDefIndex: 3530
{
	private static string projectFolder; 


	[RequiredByNativeCodeAttribute] 
	internal static void SetProjectFolder(string folder) { }

	[RequiredByNativeCodeAttribute] 
	public static string ExtractStackTrace() { }

	[RequiredByNativeCodeAttribute] 
	internal static void ExtractStringFromExceptionInternal(object exceptiono, out string message, out string stackTrace) { }

	internal static string ExtractFormattedStackTrace(StackTrace stackTrace) { }

	private static void .cctor() { }

}


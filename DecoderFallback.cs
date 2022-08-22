public abstract class DecoderFallback // TypeDefIndex: 439
{	internal bool bIsMicrosoftBestFitFallback; // 0x10
	private static DecoderFallback replacementFallback; // 0x0
	private static DecoderFallback exceptionFallback; // 0x8
	private static object s_InternalSyncObject; // 0x10

	private static object InternalSyncObject { get; }
	public static DecoderFallback ReplacementFallback { get; }
	public static DecoderFallback ExceptionFallback { get; }
	public abstract int MaxCharCount { get; }


	private static object get_InternalSyncObject() { }

	public static DecoderFallback get_ReplacementFallback() { }

	public static DecoderFallback get_ExceptionFallback() { }

	public abstract DecoderFallbackBuffer CreateFallbackBuffer();

	public abstract int get_MaxCharCount();

	protected void .ctor() { }

}


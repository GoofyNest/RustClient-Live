public abstract class DecoderFallback // TypeDefIndex: 439
{
	internal bool bIsMicrosoftBestFitFallback; 
	private static DecoderFallback replacementFallback; 
	private static DecoderFallback exceptionFallback; 
	private static object s_InternalSyncObject; 

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


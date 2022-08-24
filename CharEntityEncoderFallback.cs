internal class CharEntityEncoderFallback : EncoderFallback // TypeDefIndex: 1834
{
	private CharEntityEncoderFallbackBuffer fallbackBuffer; 
	private int[] textContentMarks; 
	private int endMarkPos; 
	private int curMarkPos; 
	private int startOffset; 

	public override int MaxCharCount { get; }
	internal int StartOffset { set; }


	internal void .ctor() { }

	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	public override int get_MaxCharCount() { }

	internal void set_StartOffset(int value) { }

	internal void Reset(int[] textContentMarks, int endMarkPos) { }

	internal bool CanReplaceAt(int index) { }

}


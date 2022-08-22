internal class CharEntityEncoderFallback : EncoderFallback // TypeDefIndex: 1834
{	private CharEntityEncoderFallbackBuffer fallbackBuffer; // 0x18
	private int[] textContentMarks; // 0x20
	private int endMarkPos; // 0x28
	private int curMarkPos; // 0x2C
	private int startOffset; // 0x30

	public override int MaxCharCount { get; }
	internal int StartOffset { set; }


	internal void .ctor() { }

	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	public override int get_MaxCharCount() { }

	internal void set_StartOffset(int value) { }

	internal void Reset(int[] textContentMarks, int endMarkPos) { }

	internal bool CanReplaceAt(int index) { }

}


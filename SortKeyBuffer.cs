internal class SortKeyBuffer // TypeDefIndex: 44
{
	private byte[] l1b; 
	private byte[] l2b; 
	private byte[] l3b; 
	private byte[] l4sb; 
	private byte[] l4tb; 
	private byte[] l4kb; 
	private byte[] l4wb; 
	private byte[] l5b; 
	private string source; 
	private int l1; 
	private int l2; 
	private int l3; 
	private int l4s; 
	private int l4t; 
	private int l4k; 
	private int l4w; 
	private int l5; 
	private int lcid; 
	private CompareOptions options; 
	private bool processLevel2; 
	private bool frenchSort; 
	private bool frenchSorted; 


	public void .ctor(int lcid) { }

	public void Reset() { }

	internal void Initialize(CompareOptions options, int lcid, string s, bool frenchSort) { }

	internal void AppendCJKExtension(byte lv1msb, byte lv1lsb) { }

	internal void AppendKana(byte category, byte lv1, byte lv2, byte lv3, bool isSmallKana, byte markType, bool isKatakana, bool isHalfWidth) { }

	internal void AppendNormal(byte category, byte lv1, byte lv2, byte lv3) { }

	private void AppendLevel5(byte category, byte lv1) { }

	private void AppendBufferPrimitive(byte value, ref byte[] buf, ref int bidx) { }

	public SortKey GetResultAndReset() { }

	private int GetOptimizedLength(byte[] data, int len, byte defaultValue) { }

	public SortKey GetResult() { }

}


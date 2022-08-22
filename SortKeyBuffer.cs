internal class SortKeyBuffer // TypeDefIndex: 44
{	private byte[] l1b; // 0x10
	private byte[] l2b; // 0x18
	private byte[] l3b; // 0x20
	private byte[] l4sb; // 0x28
	private byte[] l4tb; // 0x30
	private byte[] l4kb; // 0x38
	private byte[] l4wb; // 0x40
	private byte[] l5b; // 0x48
	private string source; // 0x50
	private int l1; // 0x58
	private int l2; // 0x5C
	private int l3; // 0x60
	private int l4s; // 0x64
	private int l4t; // 0x68
	private int l4k; // 0x6C
	private int l4w; // 0x70
	private int l5; // 0x74
	private int lcid; // 0x78
	private CompareOptions options; // 0x7C
	private bool processLevel2; // 0x80
	private bool frenchSort; // 0x81
	private bool frenchSorted; // 0x82


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


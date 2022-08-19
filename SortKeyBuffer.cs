internal class SortKeyBuffer // TypeDefIndex: 44
{	// Fields
	private byte[] l1b; // 0x10
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

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor(int lcid) { }

	// RVA: 0x164C620 Offset: 0x164BA20 VA: 0x18164C620
	public void Reset() { }

	// RVA: 0x164C420 Offset: 0x164B820 VA: 0x18164C420
	internal void Initialize(CompareOptions options, int lcid, string s, bool frenchSort) { }

	// RVA: 0x164B7A0 Offset: 0x164ABA0 VA: 0x18164B7A0
	internal void AppendCJKExtension(byte lv1msb, byte lv1lsb) { }

	// RVA: 0x164B880 Offset: 0x164AC80 VA: 0x18164B880
	internal void AppendKana(byte category, byte lv1, byte lv2, byte lv3, bool isSmallKana, byte markType, bool isKatakana, bool isHalfWidth) { }

	// RVA: 0x164BA30 Offset: 0x164AE30 VA: 0x18164BA30
	internal void AppendNormal(byte category, byte lv1, byte lv2, byte lv3) { }

	// RVA: 0x164B950 Offset: 0x164AD50 VA: 0x18164B950
	private void AppendLevel5(byte category, byte lv1) { }

	// RVA: 0x164B6E0 Offset: 0x164AAE0 VA: 0x18164B6E0
	private void AppendBufferPrimitive(byte value, ref byte[] buf, ref int bidx) { }

	// RVA: 0x164BCB0 Offset: 0x164B0B0 VA: 0x18164BCB0
	public SortKey GetResultAndReset() { }

	// RVA: 0x164BC50 Offset: 0x164B050 VA: 0x18164BC50
	private int GetOptimizedLength(byte[] data, int len, byte defaultValue) { }

	// RVA: 0x164BCE0 Offset: 0x164B0E0 VA: 0x18164BCE0
	public SortKey GetResult() { }

}


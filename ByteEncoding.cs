public abstract class ByteEncoding : MonoEncoding // TypeDefIndex: 7370
{	// Fields
	protected char[] toChars; // 0x40
	protected string encodingName; // 0x48
	protected string bodyName; // 0x50
	protected string headerName; // 0x58
	protected string webName; // 0x60
	protected bool isBrowserDisplay; // 0x68
	protected bool isBrowserSave; // 0x69
	protected bool isMailNewsDisplay; // 0x6A
	protected bool isMailNewsSave; // 0x6B
	protected int windowsCodePage; // 0x6C
	private static byte[] isNormalized; // 0x0
	private static byte[] isNormalizedComputed; // 0x8
	private static byte[] normalization_bytes; // 0x10

	// Properties
	public override bool IsSingleByte { get; }
	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override bool IsBrowserDisplay { get; }
	public override bool IsBrowserSave { get; }
	public override bool IsMailNewsDisplay { get; }
	public override bool IsMailNewsSave { get; }
	public override string WebName { get; }
	public override int WindowsCodePage { get; }

	// Methods

	// RVA: 0x22A04B0 Offset: 0x229F8B0 VA: 0x1822A04B0
	protected void .ctor(int codePage, char[] toChars, string encodingName, string bodyName, string headerName, string webName, bool isBrowserDisplay, bool isBrowserSave, bool isMailNewsDisplay, bool isMailNewsSave, int windowsCodePage) { }

	// RVA: 0x229FF70 Offset: 0x229F370 VA: 0x18229FF70 Slot: 37
	public override bool IsAlwaysNormalized(NormalizationForm form) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 16
	public override bool get_IsSingleByte() { }

	// RVA: 0x229F780 Offset: 0x229EB80 VA: 0x18229F780 Slot: 18
	public override int GetByteCount(string s) { }

	// RVA: 0x1917BD0 Offset: 0x1916FD0 VA: 0x181917BD0 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: -1 Offset: -1 Slot: 48
	protected abstract void ToBytes(char* chars, int charCount, byte* bytes, int byteCount);

	// RVA: 0x22A0400 Offset: 0x229F800 VA: 0x1822A0400 Slot: 49
	protected virtual void ToBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x229F7F0 Offset: 0x229EBF0 VA: 0x18229F7F0 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x229F820 Offset: 0x229EC20 VA: 0x18229F820 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x229F950 Offset: 0x229ED50 VA: 0x18229F950 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x229FC10 Offset: 0x229F010 VA: 0x18229FC10 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x229FC90 Offset: 0x229F090 VA: 0x18229FC90 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x229FDA0 Offset: 0x229F1A0 VA: 0x18229FDA0 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x229FD10 Offset: 0x229F110 VA: 0x18229FD10 Slot: 42
	public override string GetString(byte[] bytes) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x82A660 Offset: 0x829A60 VA: 0x18082A660 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x22A05E0 Offset: 0x229F9E0 VA: 0x1822A05E0 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0xB9D240 Offset: 0xB9C640 VA: 0x180B9D240 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0xE661C0 Offset: 0xE655C0 VA: 0x180E661C0 Slot: 15
	public override bool get_IsMailNewsSave() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60 Slot: 10
	public override string get_WebName() { }

	// RVA: 0x7E3960 Offset: 0x7E2D60 VA: 0x1807E3960 Slot: 11
	public override int get_WindowsCodePage() { }

}


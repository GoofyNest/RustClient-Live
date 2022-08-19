public abstract class ISCIIEncoding : MonoEncoding // TypeDefIndex: 7872
{	// Fields
	private int shift; // 0x40
	private string encodingName; // 0x48
	private string webName; // 0x50

	// Properties
	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override string WebName { get; }

	// Methods

	// RVA: 0x22F0460 Offset: 0x22EF860 VA: 0x1822F0460
	protected void .ctor(int codePage, int shift, string encodingName, string webName) { }

	// RVA: 0x22EFBE0 Offset: 0x22EEFE0 VA: 0x1822EFBE0 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x22EFD10 Offset: 0x22EF110 VA: 0x1822EFD10 Slot: 18
	public override int GetByteCount(string s) { }

	// RVA: 0x22EFBB0 Offset: 0x22EEFB0 VA: 0x1822EFBB0 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x22EFD80 Offset: 0x22EF180 VA: 0x1822EFD80 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x22EFF80 Offset: 0x22EF380 VA: 0x1822EFF80 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x22F00B0 Offset: 0x22EF4B0 VA: 0x1822F00B0 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x22F0360 Offset: 0x22EF760 VA: 0x1822F0360 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x22F03E0 Offset: 0x22EF7E0 VA: 0x1822F03E0 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350 Slot: 10
	public override string get_WebName() { }

}


internal class ISO2022JPEncoder : MonoEncoder // TypeDefIndex: 7805
{	// Fields
	private static JISConvert convert; // 0x0
	private readonly bool allow_1byte_kana; // 0x28
	private readonly bool allow_shift_io; // 0x29
	private ISO2022JPMode m; // 0x2C
	private bool shifted_in_count; // 0x30
	private bool shifted_in_conv; // 0x31
	private static readonly char[] full_width_map; // 0x8

	// Methods

	// RVA: 0x224D240 Offset: 0x224C640 VA: 0x18224D240
	public void .ctor(MonoEncoding owner, bool allow1ByteKana, bool allowShiftIO) { }

	// RVA: 0x224D190 Offset: 0x224C590 VA: 0x18224D190
	private static void .cctor() { }

	// RVA: 0x224C610 Offset: 0x224BA10 VA: 0x18224C610 Slot: 11
	public override int GetByteCountImpl(char* chars, int charCount, bool flush) { }

	// RVA: 0x224D0B0 Offset: 0x224C4B0 VA: 0x18224D0B0
	private void SwitchMode(byte* bytes, ref int byteIndex, ref int byteCount, ref ISO2022JPMode cur, ISO2022JPMode next) { }

	// RVA: 0x224C9A0 Offset: 0x224BDA0 VA: 0x18224C9A0 Slot: 12
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x224D0A0 Offset: 0x224C4A0 VA: 0x18224D0A0 Slot: 4
	public override void Reset() { }

}


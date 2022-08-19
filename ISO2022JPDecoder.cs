internal class ISO2022JPDecoder : Decoder // TypeDefIndex: 7806
{	// Fields
	private static JISConvert convert; // 0x0
	private readonly bool allow_shift_io; // 0x20
	private ISO2022JPMode m; // 0x24
	private bool shifted_in_conv; // 0x28
	private bool shifted_in_count; // 0x29

	// Methods

	// RVA: 0x224C5E0 Offset: 0x224B9E0 VA: 0x18224C5E0
	public void .ctor(bool allow1ByteKana, bool allowShiftIO) { }

	// RVA: 0x224C570 Offset: 0x224B970 VA: 0x18224C570
	private static void .cctor() { }

	// RVA: 0x224BE70 Offset: 0x224B270 VA: 0x18224BE70 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224C460 Offset: 0x224B860 VA: 0x18224C460
	private int ToChar(int value) { }

	// RVA: 0x224BFF0 Offset: 0x224B3F0 VA: 0x18224BFF0 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224C450 Offset: 0x224B850 VA: 0x18224C450 Slot: 4
	public override void Reset() { }

}


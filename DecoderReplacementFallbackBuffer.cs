public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 443
{	// Fields
	private string strDefault; // 0x20
	private int fallbackCount; // 0x28
	private int fallbackIndex; // 0x2C

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x18A7E80 Offset: 0x18A7280 VA: 0x1818A7E80
	public void .ctor(DecoderReplacementFallback fallback) { }

	// RVA: 0x18A7DC0 Offset: 0x18A71C0 VA: 0x1818A7DC0 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x18A7E10 Offset: 0x18A7210 VA: 0x1818A7E10 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x18A7ED0 Offset: 0x18A72D0 VA: 0x1818A7ED0 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x18A7E60 Offset: 0x18A7260 VA: 0x1818A7E60 Slot: 7
	public override void Reset() { }

	// RVA: 0xD47ED0 Offset: 0xD472D0 VA: 0x180D47ED0 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

}


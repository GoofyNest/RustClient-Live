public sealed class DecoderReplacementFallback : DecoderFallback // TypeDefIndex: 442
{	// Fields
	private string strDefault; // 0x18

	// Properties
	public string DefaultString { get; }
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x18A7FF0 Offset: 0x18A73F0 VA: 0x1818A7FF0
	public void .ctor() { }

	// RVA: 0x18A8030 Offset: 0x18A7430 VA: 0x1818A8030
	public void .ctor(string replacement) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_DefaultString() { }

	// RVA: 0x18A7EE0 Offset: 0x18A72E0 VA: 0x1818A7EE0 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x18A81E0 Offset: 0x18A75E0 VA: 0x1818A81E0 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x18A7F60 Offset: 0x18A7360 VA: 0x1818A7F60 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0xAE1200 Offset: 0xAE0600 VA: 0x180AE1200 Slot: 2
	public override int GetHashCode() { }

}


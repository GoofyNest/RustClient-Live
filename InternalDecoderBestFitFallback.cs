internal sealed class InternalDecoderBestFitFallback : DecoderFallback // TypeDefIndex: 434
{	// Fields
	internal Encoding encoding; // 0x18
	internal char[] arrayBestFit; // 0x20
	internal char cReplacement; // 0x28

	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x1916BC0 Offset: 0x1915FC0 VA: 0x181916BC0
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x1916A80 Offset: 0x1915E80 VA: 0x181916A80 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x1916AE0 Offset: 0x1915EE0 VA: 0x181916AE0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1916B90 Offset: 0x1915F90 VA: 0x181916B90 Slot: 2
	public override int GetHashCode() { }

}


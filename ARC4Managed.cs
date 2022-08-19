internal class ARC4Managed : RC4, ICryptoTransform, IDisposable // TypeDefIndex: 63
{	// Fields
	private byte[] key; // 0x48
	private byte[] state; // 0x50
	private byte x; // 0x58
	private byte y; // 0x59
	private bool m_disposed; // 0x5A

	// Properties
	public override byte[] Key { get; set; }
	public bool CanTransformMultipleBlocks { get; }
	public int InputBlockSize { get; }
	public int OutputBlockSize { get; }

	// Methods

	// RVA: 0x173EB20 Offset: 0x173DF20 VA: 0x18173EB20
	public void .ctor() { }

	// RVA: 0x173E440 Offset: 0x173D840 VA: 0x18173E440 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x173E370 Offset: 0x173D770 VA: 0x18173E370 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x173EC30 Offset: 0x173E030 VA: 0x18173EC30 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x173ECD0 Offset: 0x173E0D0 VA: 0x18173ECD0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x173E340 Offset: 0x173D740 VA: 0x18173E340 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgvIV) { }

	// RVA: 0x173E300 Offset: 0x173D700 VA: 0x18173E300 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgvIV) { }

	// RVA: 0x173E4E0 Offset: 0x173D8E0 VA: 0x18173E4E0 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x173E530 Offset: 0x173D930 VA: 0x18173E530 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 28
	public bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 26
	public int get_InputBlockSize() { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 27
	public int get_OutputBlockSize() { }

	// RVA: 0x173E7B0 Offset: 0x173DBB0 VA: 0x18173E7B0
	private void KeySetup(byte[] key) { }

	// RVA: 0x173E1B0 Offset: 0x173D5B0 VA: 0x18173E1B0
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x173E900 Offset: 0x173DD00 VA: 0x18173E900 Slot: 29
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x173E5C0 Offset: 0x173D9C0 VA: 0x18173E5C0
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x173EA60 Offset: 0x173DE60 VA: 0x18173EA60 Slot: 30
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

}


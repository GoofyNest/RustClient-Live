public sealed class MD5CryptoServiceProvider : MD5 // TypeDefIndex: 1006
{	// Fields
	private uint[] _H; // 0x28
	private uint[] buff; // 0x30
	private ulong count; // 0x38
	private byte[] _ProcessingBuffer; // 0x40
	private int _ProcessingBufferCount; // 0x48
	private static readonly uint[] K; // 0x0

	// Methods

	// RVA: 0x16FF9E0 Offset: 0x16FEDE0 VA: 0x1816FF9E0
	public void .ctor() { }

	// RVA: 0x16FE080 Offset: 0x16FD480 VA: 0x1816FE080 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x16FDFE0 Offset: 0x16FD3E0 VA: 0x1816FDFE0 Slot: 15
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16FE120 Offset: 0x16FD520 VA: 0x1816FE120 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x16FE240 Offset: 0x16FD640 VA: 0x1816FE240 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x16FE340 Offset: 0x16FD740 VA: 0x1816FE340 Slot: 16
	public override void Initialize() { }

	// RVA: 0x16FE3F0 Offset: 0x16FD7F0 VA: 0x1816FE3F0
	private void ProcessBlock(byte[] inputBuffer, int inputOffset) { }

	// RVA: 0x16FF7D0 Offset: 0x16FEBD0 VA: 0x1816FF7D0
	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x16FDE70 Offset: 0x16FD270 VA: 0x1816FDE70
	internal void AddLength(ulong length, byte[] buffer, int position) { }

	// RVA: 0x16FF970 Offset: 0x16FED70 VA: 0x1816FF970
	private static void .cctor() { }

}


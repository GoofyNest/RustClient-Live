internal class GZipOutputStream : DeflaterOutputStream // TypeDefIndex: 5655
{	// Fields
	protected Crc32 crc; // 0x50

	// Methods

	// RVA: 0x22FDFC0 Offset: 0x22FD3C0 VA: 0x1822FDFC0
	public void .ctor(Stream baseOutputStream) { }

	// RVA: 0x22FDD90 Offset: 0x22FD190 VA: 0x1822FDD90
	public void .ctor(Stream baseOutputStream, int size) { }

	// RVA: 0x22FDAC0 Offset: 0x22FCEC0 VA: 0x1822FDAC0
	private void WriteHeader() { }

	// RVA: 0x22FDD10 Offset: 0x22FD110 VA: 0x1822FDD10 Slot: 29
	public override void Write(byte[] buf, int off, int len) { }

	// RVA: 0x22FD8A0 Offset: 0x22FCCA0 VA: 0x1822FD8A0 Slot: 16
	public override void Close() { }

	// RVA: 0x22FD8F0 Offset: 0x22FCCF0 VA: 0x1822FD8F0 Slot: 31
	public override void Finish() { }

}


public sealed class SecureString : IDisposable // TypeDefIndex: 903
{	// Fields
	private int length; // 0x10
	private bool disposed; // 0x14
	private byte[] data; // 0x18

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x17BD4F0 Offset: 0x17BC8F0 VA: 0x1817BD4F0
	public void .ctor() { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x17BD550 Offset: 0x17BC950 VA: 0x1817BD550
	public void .ctor(char* value, int length) { }

	// RVA: 0x17BD700 Offset: 0x17BCB00 VA: 0x1817BD700
	public int get_Length() { }

	// RVA: 0x17BD3C0 Offset: 0x17BC7C0 VA: 0x1817BD3C0 Slot: 4
	public void Dispose() { }

	// RVA: 0x488BC0 Offset: 0x487FC0 VA: 0x180488BC0
	private void Encrypt() { }

	// RVA: 0x488BC0 Offset: 0x487FC0 VA: 0x180488BC0
	private void Decrypt() { }

	// RVA: 0x17BD260 Offset: 0x17BC660 VA: 0x1817BD260
	private void Alloc(int length, bool realloc) { }

	// RVA: 0x17BD410 Offset: 0x17BC810 VA: 0x1817BD410
	internal byte[] GetBuffer() { }

}


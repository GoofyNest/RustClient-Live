public sealed class SecureString : IDisposable // TypeDefIndex: 903
{	private int length; // 0x10
	private bool disposed; // 0x14
	private byte[] data; // 0x18

	public int Length { get; }


	public void .ctor() { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public void .ctor(char* value, int length) { }

	public int get_Length() { }

	public void Dispose() { }

	private void Encrypt() { }

	private void Decrypt() { }

	private void Alloc(int length, bool realloc) { }

	internal byte[] GetBuffer() { }

}


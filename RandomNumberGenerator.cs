public abstract class RandomNumberGenerator : IDisposable // TypeDefIndex: 972
{	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x17B2030 Offset: 0x17B1430 VA: 0x1817B2030
	public static RandomNumberGenerator Create() { }

	// RVA: 0x17B2080 Offset: 0x17B1480 VA: 0x1817B2080 Slot: 4
	public void Dispose() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void GetBytes(byte[] data);

}


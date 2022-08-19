public sealed class RNGCryptoServiceProvider : RandomNumberGenerator // TypeDefIndex: 1008
{	// Fields
	private static object _lock; // 0x0
	private IntPtr _handle; // 0x10

	// Methods

	// RVA: 0x1704320 Offset: 0x1703720 VA: 0x181704320
	private static void .cctor() { }

	// RVA: 0x17043A0 Offset: 0x17037A0 VA: 0x1817043A0
	public void .ctor() { }

	// RVA: 0x1703FB0 Offset: 0x17033B0 VA: 0x181703FB0
	private void Check() { }

	// RVA: 0x144DB10 Offset: 0x144CF10 VA: 0x18144DB10
	private static bool RngOpen() { }

	// RVA: 0x1704310 Offset: 0x1703710 VA: 0x181704310
	private static IntPtr RngInitialize(byte[] seed) { }

	// RVA: 0x1704300 Offset: 0x1703700 VA: 0x181704300
	private static IntPtr RngGetBytes(IntPtr handle, byte[] data) { }

	// RVA: 0x17042F0 Offset: 0x17036F0 VA: 0x1817042F0
	private static void RngClose(IntPtr handle) { }

	// RVA: 0x1704120 Offset: 0x1703520 VA: 0x181704120 Slot: 6
	public override void GetBytes(byte[] data) { }

	// RVA: 0x1704040 Offset: 0x1703440 VA: 0x181704040 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x84E180 Offset: 0x84D580 VA: 0x18084E180 Slot: 5
	protected override void Dispose(bool disposing) { }

}


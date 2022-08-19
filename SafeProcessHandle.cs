public sealed class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 2563
{	// Fields
	internal static SafeProcessHandle InvalidHandle; // 0x13640

	// Methods

	// RVA: 0x12165C0 Offset: 0x12159C0 VA: 0x1812165C0
	internal void .ctor(IntPtr handle) { }

	// RVA: 0x1216590 Offset: 0x1215990 VA: 0x181216590
	public void .ctor(IntPtr existingHandle, bool ownsHandle) { }

	// RVA: 0x1216510 Offset: 0x1215910 VA: 0x181216510 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x1216520 Offset: 0x1215920 VA: 0x181216520
	private static void .cctor() { }

}


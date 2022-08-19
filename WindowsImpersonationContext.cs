public class WindowsImpersonationContext : IDisposable // TypeDefIndex: 933
{	// Fields
	private IntPtr _token; // 0x10
	private bool undo; // 0x18

	// Methods

	// RVA: 0x17C55D0 Offset: 0x17C49D0 VA: 0x1817C55D0
	internal void .ctor(IntPtr token) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x17C5430 Offset: 0x17C4830 VA: 0x1817C5430 Slot: 4
	public void Dispose() { }

	// RVA: 0x17C5520 Offset: 0x17C4920 VA: 0x1817C5520
	public void Undo() { }

	// RVA: 0x17C5420 Offset: 0x17C4820 VA: 0x1817C5420
	private static bool CloseToken(IntPtr token) { }

	// RVA: 0x17C54F0 Offset: 0x17C48F0 VA: 0x1817C54F0
	private static IntPtr DuplicateToken(IntPtr token) { }

	// RVA: 0x17C5510 Offset: 0x17C4910 VA: 0x1817C5510
	private static bool SetCurrentToken(IntPtr token) { }

	// RVA: 0x17C5500 Offset: 0x17C4900 VA: 0x1817C5500
	private static bool RevertToSelf() { }

}


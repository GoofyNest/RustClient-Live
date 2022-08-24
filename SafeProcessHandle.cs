public sealed class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 2563
{
	internal static SafeProcessHandle InvalidHandle; 


	internal void .ctor(IntPtr handle) { }

	public void .ctor(IntPtr existingHandle, bool ownsHandle) { }

	protected override bool ReleaseHandle() { }

	private static void .cctor() { }

}


public class WindowsImpersonationContext : IDisposable // TypeDefIndex: 933
{
	private IntPtr _token;
	private bool undo;


	internal void .ctor(IntPtr token) { }

	[ComVisibleAttribute]
	public void Dispose() { }

	public void Undo() { }

	private static bool CloseToken(IntPtr token) { }

	private static IntPtr DuplicateToken(IntPtr token) { }

	private static bool SetCurrentToken(IntPtr token) { }

	private static bool RevertToSelf() { }

}


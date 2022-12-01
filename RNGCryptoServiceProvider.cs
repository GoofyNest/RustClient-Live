public sealed class RNGCryptoServiceProvider : RandomNumberGenerator // TypeDefIndex: 1008
{
	private static object _lock;
	private IntPtr _handle;


	private static void .cctor() { }

	public void .ctor() { }

	private void Check() { }

	private static bool RngOpen() { }

	private static IntPtr RngInitialize(byte[] seed) { }

	private static IntPtr RngGetBytes(IntPtr handle, byte[] data) { }

	private static void RngClose(IntPtr handle) { }

	public override void GetBytes(byte[] data) { }

	protected override void Finalize() { }

	protected override void Dispose(bool disposing) { }

}


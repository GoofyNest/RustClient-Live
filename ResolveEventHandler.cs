public sealed class ResolveEventHandler : MulticastDelegate // TypeDefIndex: 387
{

	public void .ctor(object object, IntPtr method) { }

	public virtual Assembly Invoke(object sender, ResolveEventArgs args) { }

	public virtual IAsyncResult BeginInvoke(object sender, ResolveEventArgs args, AsyncCallback callback, object object) { }

	public virtual Assembly EndInvoke(IAsyncResult result) { }

}


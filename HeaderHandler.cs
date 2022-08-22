public sealed class HeaderHandler : MulticastDelegate // TypeDefIndex: 1238
{
	public void .ctor(object object, IntPtr method) { }

	public virtual object Invoke(Header[] headers) { }

	public virtual IAsyncResult BeginInvoke(Header[] headers, AsyncCallback callback, object object) { }

	public virtual object EndInvoke(IAsyncResult result) { }

}


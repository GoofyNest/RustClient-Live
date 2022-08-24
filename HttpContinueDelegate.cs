public sealed class HttpContinueDelegate : MulticastDelegate // TypeDefIndex: 2891
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(int StatusCode, WebHeaderCollection httpHeaders) { }

	public virtual IAsyncResult BeginInvoke(int StatusCode, WebHeaderCollection httpHeaders, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}


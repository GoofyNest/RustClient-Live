public sealed class BindIPEndPoint : MulticastDelegate // TypeDefIndex: 2989
{

	public void .ctor(object object, IntPtr method) { }

	public virtual IPEndPoint Invoke(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount) { }

	public virtual IAsyncResult BeginInvoke(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount, AsyncCallback callback, object object) { }

	public virtual IPEndPoint EndInvoke(IAsyncResult result) { }

}


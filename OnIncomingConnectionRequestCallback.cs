public sealed class OnIncomingConnectionRequestCallback : MulticastDelegate // TypeDefIndex: 8968
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref OnIncomingConnectionRequestInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref OnIncomingConnectionRequestInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref OnIncomingConnectionRequestInfo data, IAsyncResult result) { }

}


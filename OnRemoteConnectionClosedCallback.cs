public sealed class OnRemoteConnectionClosedCallback : MulticastDelegate // TypeDefIndex: 8986
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref OnRemoteConnectionClosedInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref OnRemoteConnectionClosedInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref OnRemoteConnectionClosedInfo data, IAsyncResult result) { }

}


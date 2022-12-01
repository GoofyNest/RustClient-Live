public sealed class OnMessageToServerCallback : MulticastDelegate // TypeDefIndex: 9836
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref OnMessageToServerCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref OnMessageToServerCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref OnMessageToServerCallbackInfo data, IAsyncResult result) { }

}


public sealed class OnMessageToServerCallback : MulticastDelegate // TypeDefIndex: 9824
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref OnMessageToServerCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref OnMessageToServerCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref OnMessageToServerCallbackInfo data, IAsyncResult result) { }

}


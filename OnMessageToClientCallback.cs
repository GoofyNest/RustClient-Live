public sealed class OnMessageToClientCallback : MulticastDelegate // TypeDefIndex: 9739
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref OnMessageToClientCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref OnMessageToClientCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref OnMessageToClientCallbackInfo data, IAsyncResult result) { }

}


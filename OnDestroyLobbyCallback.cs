public sealed class OnDestroyLobbyCallback : MulticastDelegate // TypeDefIndex: 9201
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref DestroyLobbyCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref DestroyLobbyCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref DestroyLobbyCallbackInfo data, IAsyncResult result) { }

}


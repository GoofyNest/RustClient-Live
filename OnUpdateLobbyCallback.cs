public sealed class OnUpdateLobbyCallback : MulticastDelegate // TypeDefIndex: 9238
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref UpdateLobbyCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref UpdateLobbyCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref UpdateLobbyCallbackInfo data, IAsyncResult result) { }

}


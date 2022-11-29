public sealed class OnCreateLobbyCallback : MulticastDelegate // TypeDefIndex: 9208
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref CreateLobbyCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref CreateLobbyCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref CreateLobbyCallbackInfo data, IAsyncResult result) { }

}


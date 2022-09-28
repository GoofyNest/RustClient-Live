public sealed class OnLobbyUpdateReceivedCallback : MulticastDelegate // TypeDefIndex: 9190
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref LobbyUpdateReceivedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref LobbyUpdateReceivedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref LobbyUpdateReceivedCallbackInfo data, IAsyncResult result) { }

}


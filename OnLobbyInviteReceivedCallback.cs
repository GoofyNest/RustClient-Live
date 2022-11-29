public sealed class OnLobbyInviteReceivedCallback : MulticastDelegate // TypeDefIndex: 9226
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref LobbyInviteReceivedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref LobbyInviteReceivedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref LobbyInviteReceivedCallbackInfo data, IAsyncResult result) { }

}


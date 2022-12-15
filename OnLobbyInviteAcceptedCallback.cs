public sealed class OnLobbyInviteAcceptedCallback : MulticastDelegate // TypeDefIndex: 9228
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref LobbyInviteAcceptedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref LobbyInviteAcceptedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref LobbyInviteAcceptedCallbackInfo data, IAsyncResult result) { }

}


public sealed class OnLobbyInviteRejectedCallback : MulticastDelegate // TypeDefIndex: 9230
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref LobbyInviteRejectedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref LobbyInviteRejectedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref LobbyInviteRejectedCallbackInfo data, IAsyncResult result) { }

}


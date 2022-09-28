public sealed class OnLobbyMemberStatusReceivedCallback : MulticastDelegate // TypeDefIndex: 9186
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref LobbyMemberStatusReceivedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref LobbyMemberStatusReceivedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref LobbyMemberStatusReceivedCallbackInfo data, IAsyncResult result) { }

}


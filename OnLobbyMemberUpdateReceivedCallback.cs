public sealed class OnLobbyMemberUpdateReceivedCallback : MulticastDelegate // TypeDefIndex: 9236
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref LobbyMemberUpdateReceivedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref LobbyMemberUpdateReceivedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref LobbyMemberUpdateReceivedCallbackInfo data, IAsyncResult result) { }

}


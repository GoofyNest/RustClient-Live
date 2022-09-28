public sealed class OnJoinLobbyAcceptedCallback : MulticastDelegate // TypeDefIndex: 9170
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref JoinLobbyAcceptedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref JoinLobbyAcceptedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref JoinLobbyAcceptedCallbackInfo data, IAsyncResult result) { }

}


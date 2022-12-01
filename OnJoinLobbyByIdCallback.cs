public sealed class OnJoinLobbyByIdCallback : MulticastDelegate // TypeDefIndex: 9218
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref JoinLobbyByIdCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref JoinLobbyByIdCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref JoinLobbyByIdCallbackInfo data, IAsyncResult result) { }

}


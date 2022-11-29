public sealed class LobbySearchOnFindCallback : MulticastDelegate // TypeDefIndex: 9192
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref LobbySearchFindCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref LobbySearchFindCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref LobbySearchFindCallbackInfo data, IAsyncResult result) { }

}


public sealed class OnLeaveLobbyCallback : MulticastDelegate // TypeDefIndex: 9212
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref LeaveLobbyCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref LeaveLobbyCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref LeaveLobbyCallbackInfo data, IAsyncResult result) { }

}


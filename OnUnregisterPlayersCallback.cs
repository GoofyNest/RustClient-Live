public sealed class OnUnregisterPlayersCallback : MulticastDelegate // TypeDefIndex: 8514
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref UnregisterPlayersCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref UnregisterPlayersCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref UnregisterPlayersCallbackInfo data, IAsyncResult result) { }

}


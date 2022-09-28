public sealed class OnRegisterPlayersCallback : MulticastDelegate // TypeDefIndex: 8468
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref RegisterPlayersCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref RegisterPlayersCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref RegisterPlayersCallbackInfo data, IAsyncResult result) { }

}


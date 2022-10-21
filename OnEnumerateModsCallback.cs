public sealed class OnEnumerateModsCallback : MulticastDelegate // TypeDefIndex: 9016
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref EnumerateModsCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref EnumerateModsCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref EnumerateModsCallbackInfo data, IAsyncResult result) { }

}


public sealed class OnUnlinkAccountCallback : MulticastDelegate // TypeDefIndex: 9623
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref UnlinkAccountCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref UnlinkAccountCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref UnlinkAccountCallbackInfo data, IAsyncResult result) { }

}


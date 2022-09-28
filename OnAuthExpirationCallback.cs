public sealed class OnAuthExpirationCallback : MulticastDelegate // TypeDefIndex: 9555
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref AuthExpirationCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref AuthExpirationCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref AuthExpirationCallbackInfo data, IAsyncResult result) { }

}


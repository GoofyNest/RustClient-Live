public sealed class OnKickCompleteCallback : MulticastDelegate // TypeDefIndex: 8746
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref KickCompleteCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref KickCompleteCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref KickCompleteCallbackInfo data, IAsyncResult result) { }

}


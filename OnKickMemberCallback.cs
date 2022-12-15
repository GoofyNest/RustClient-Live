public sealed class OnKickMemberCallback : MulticastDelegate // TypeDefIndex: 9224
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref KickMemberCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref KickMemberCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref KickMemberCallbackInfo data, IAsyncResult result) { }

}


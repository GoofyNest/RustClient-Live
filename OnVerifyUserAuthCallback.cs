public sealed class OnVerifyUserAuthCallback : MulticastDelegate // TypeDefIndex: 9650
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref VerifyUserAuthCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref VerifyUserAuthCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref VerifyUserAuthCallbackInfo data, IAsyncResult result) { }

}


public sealed class OnCustomInviteRejectedCallback : MulticastDelegate // TypeDefIndex: 9529
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref CustomInviteRejectedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref CustomInviteRejectedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref CustomInviteRejectedCallbackInfo data, IAsyncResult result) { }

}


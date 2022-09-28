public sealed class OnPromoteMemberCallback : MulticastDelegate // TypeDefIndex: 9192
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref PromoteMemberCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref PromoteMemberCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref PromoteMemberCallbackInfo data, IAsyncResult result) { }

}


public sealed class OnJoinSessionCallback : MulticastDelegate // TypeDefIndex: 8510
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref JoinSessionCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref JoinSessionCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref JoinSessionCallbackInfo data, IAsyncResult result) { }

}


public sealed class OnJoinSessionAcceptedCallback : MulticastDelegate // TypeDefIndex: 8506
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref JoinSessionAcceptedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref JoinSessionAcceptedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref JoinSessionAcceptedCallbackInfo data, IAsyncResult result) { }

}


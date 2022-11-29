public sealed class OnUpdateSessionCallback : MulticastDelegate // TypeDefIndex: 8526
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref UpdateSessionCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref UpdateSessionCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref UpdateSessionCallbackInfo data, IAsyncResult result) { }

}


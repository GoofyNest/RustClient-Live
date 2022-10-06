public sealed class OnUpdateModCallback : MulticastDelegate // TypeDefIndex: 9021
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref UpdateModCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref UpdateModCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref UpdateModCallbackInfo data, IAsyncResult result) { }

}


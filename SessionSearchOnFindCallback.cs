public sealed class SessionSearchOnFindCallback : MulticastDelegate // TypeDefIndex: 8592
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref SessionSearchFindCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref SessionSearchFindCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref SessionSearchFindCallbackInfo data, IAsyncResult result) { }

}


public sealed class OnShowReportPlayerCallback : MulticastDelegate // TypeDefIndex: 8360
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref OnShowReportPlayerCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref OnShowReportPlayerCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref OnShowReportPlayerCallbackInfo data, IAsyncResult result) { }

}


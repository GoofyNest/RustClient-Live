public sealed class OnSendPlayerBehaviorReportCompleteCallback : MulticastDelegate // TypeDefIndex: 8636
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref SendPlayerBehaviorReportCompleteCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref SendPlayerBehaviorReportCompleteCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref SendPlayerBehaviorReportCompleteCallbackInfo data, IAsyncResult result) { }

}


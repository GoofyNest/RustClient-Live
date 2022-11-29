public sealed class OnQueryStatsCompleteCallback : MulticastDelegate // TypeDefIndex: 8440
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref OnQueryStatsCompleteCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref OnQueryStatsCompleteCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref OnQueryStatsCompleteCallbackInfo data, IAsyncResult result) { }

}


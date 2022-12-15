public sealed class OnAudioBeforeSendCallback : MulticastDelegate // TypeDefIndex: 8682
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref AudioBeforeSendCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref AudioBeforeSendCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref AudioBeforeSendCallbackInfo data, IAsyncResult result) { }

}


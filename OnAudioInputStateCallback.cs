public sealed class OnAudioInputStateCallback : MulticastDelegate // TypeDefIndex: 8638
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref AudioInputStateCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref AudioInputStateCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref AudioInputStateCallbackInfo data, IAsyncResult result) { }

}


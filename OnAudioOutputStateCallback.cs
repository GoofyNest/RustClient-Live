public sealed class OnAudioOutputStateCallback : MulticastDelegate // TypeDefIndex: 8686
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref AudioOutputStateCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref AudioOutputStateCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref AudioOutputStateCallbackInfo data, IAsyncResult result) { }

}


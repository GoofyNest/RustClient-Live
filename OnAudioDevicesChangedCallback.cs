public sealed class OnAudioDevicesChangedCallback : MulticastDelegate // TypeDefIndex: 8671
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref AudioDevicesChangedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref AudioDevicesChangedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref AudioDevicesChangedCallbackInfo data, IAsyncResult result) { }

}


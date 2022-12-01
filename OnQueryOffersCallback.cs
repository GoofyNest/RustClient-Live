public sealed class OnQueryOffersCallback : MulticastDelegate // TypeDefIndex: 9487
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref QueryOffersCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref QueryOffersCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref QueryOffersCallbackInfo data, IAsyncResult result) { }

}


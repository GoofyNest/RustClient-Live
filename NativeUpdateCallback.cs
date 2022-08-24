internal sealed class NativeUpdateCallback : MulticastDelegate // TypeDefIndex: 4520
{

internal sealed class NativeUpdateCallback : MulticastDelegate 

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer) { }

public virtual IAsyncResult BeginInvoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}


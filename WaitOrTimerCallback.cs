public sealed class WaitOrTimerCallback : MulticastDelegate // TypeDefIndex: 807
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(object state, bool timedOut) { }

public virtual IAsyncResult BeginInvoke(object state, bool timedOut, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}


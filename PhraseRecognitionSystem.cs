public static class PhraseRecognitionSystem // TypeDefIndex: 3591
{
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private static PhraseRecognitionSystem.ErrorDelegate OnError; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private static PhraseRecognitionSystem.StatusDelegate OnStatusChanged; 


	[RequiredByNativeCodeAttribute] 
	private static void PhraseRecognitionSystem_InvokeErrorEvent(SpeechError errorCode) { }

	[RequiredByNativeCodeAttribute] 
	private static void PhraseRecognitionSystem_InvokeStatusChangedEvent(SpeechSystemStatus status) { }

}

public sealed class PhraseRecognitionSystem.ErrorDelegate : MulticastDelegate // TypeDefIndex: 3592
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(SpeechError errorCode) { }

	public virtual IAsyncResult BeginInvoke(SpeechError errorCode, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhraseRecognitionSystem.StatusDelegate : MulticastDelegate // TypeDefIndex: 3593
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(SpeechSystemStatus status) { }

	public virtual IAsyncResult BeginInvoke(SpeechSystemStatus status, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}


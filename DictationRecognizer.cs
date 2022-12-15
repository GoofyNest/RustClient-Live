public sealed class DictationRecognizer // TypeDefIndex: 3599
{
	private IntPtr m_Recognizer;
	[CompilerGeneratedAttribute]
	[DebuggerBrowsableAttribute]
	private DictationRecognizer.DictationHypothesisDelegate DictationHypothesis;
	[CompilerGeneratedAttribute]
	[DebuggerBrowsableAttribute]
	private DictationRecognizer.DictationResultDelegate DictationResult;
	[CompilerGeneratedAttribute]
	[DebuggerBrowsableAttribute]
	private DictationRecognizer.DictationCompletedDelegate DictationComplete;
	[DebuggerBrowsableAttribute]
	[CompilerGeneratedAttribute]
	private DictationRecognizer.DictationErrorHandler DictationError;


	[RequiredByNativeCodeAttribute]
	private void DictationRecognizer_InvokeHypothesisGeneratedEvent(string keyword) { }

	[RequiredByNativeCodeAttribute]
	private void DictationRecognizer_InvokeResultGeneratedEvent(string keyword, ConfidenceLevel minimumConfidence) { }

	[RequiredByNativeCodeAttribute]
	private void DictationRecognizer_InvokeCompletedEvent(DictationCompletionCause cause) { }

	[RequiredByNativeCodeAttribute]
	private void DictationRecognizer_InvokeErrorEvent(string error, int hresult) { }

}

public sealed class DictationRecognizer.DictationHypothesisDelegate : MulticastDelegate // TypeDefIndex: 3600
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(string text) { }

	public virtual IAsyncResult BeginInvoke(string text, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class DictationRecognizer.DictationResultDelegate : MulticastDelegate // TypeDefIndex: 3601
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(string text, ConfidenceLevel confidence) { }

	public virtual IAsyncResult BeginInvoke(string text, ConfidenceLevel confidence, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class DictationRecognizer.DictationCompletedDelegate : MulticastDelegate // TypeDefIndex: 3602
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(DictationCompletionCause cause) { }

	public virtual IAsyncResult BeginInvoke(DictationCompletionCause cause, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class DictationRecognizer.DictationErrorHandler : MulticastDelegate // TypeDefIndex: 3603
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(string error, int hresult) { }

	public virtual IAsyncResult BeginInvoke(string error, int hresult, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}


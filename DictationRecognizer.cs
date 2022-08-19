public sealed class DictationRecognizer // TypeDefIndex: 3596
{	// Fields
	private IntPtr m_Recognizer; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private DictationRecognizer.DictationHypothesisDelegate DictationHypothesis; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private DictationRecognizer.DictationResultDelegate DictationResult; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private DictationRecognizer.DictationCompletedDelegate DictationComplete; // 0x28
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private DictationRecognizer.DictationErrorHandler DictationError; // 0x30

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2172B00 Offset: 0x2171F00 VA: 0x182172B00
	private void DictationRecognizer_InvokeHypothesisGeneratedEvent(string keyword) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2172B20 Offset: 0x2171F20 VA: 0x182172B20
	private void DictationRecognizer_InvokeResultGeneratedEvent(string keyword, ConfidenceLevel minimumConfidence) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2172AC0 Offset: 0x2171EC0 VA: 0x182172AC0
	private void DictationRecognizer_InvokeCompletedEvent(DictationCompletionCause cause) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2172AE0 Offset: 0x2171EE0 VA: 0x182172AE0
	private void DictationRecognizer_InvokeErrorEvent(string error, int hresult) { }

}

public sealed class DictationRecognizer.DictationHypothesisDelegate : MulticastDelegate // TypeDefIndex: 3597
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x497240 Offset: 0x496640 VA: 0x180497240 Slot: 12
	public virtual void Invoke(string text) { }

	// RVA: 0x497210 Offset: 0x496610 VA: 0x180497210 Slot: 13
	public virtual IAsyncResult BeginInvoke(string text, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class DictationRecognizer.DictationResultDelegate : MulticastDelegate // TypeDefIndex: 3598
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A393F0 Offset: 0x1A387F0 VA: 0x181A393F0 Slot: 12
	public virtual void Invoke(string text, ConfidenceLevel confidence) { }

	// RVA: 0x2172B40 Offset: 0x2171F40 VA: 0x182172B40 Slot: 13
	public virtual IAsyncResult BeginInvoke(string text, ConfidenceLevel confidence, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class DictationRecognizer.DictationCompletedDelegate : MulticastDelegate // TypeDefIndex: 3599
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19C2F70 Offset: 0x19C2370 VA: 0x1819C2F70 Slot: 12
	public virtual void Invoke(DictationCompletionCause cause) { }

	// RVA: 0x21729B0 Offset: 0x2171DB0 VA: 0x1821729B0 Slot: 13
	public virtual IAsyncResult BeginInvoke(DictationCompletionCause cause, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class DictationRecognizer.DictationErrorHandler : MulticastDelegate // TypeDefIndex: 3600
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A393F0 Offset: 0x1A387F0 VA: 0x181A393F0 Slot: 12
	public virtual void Invoke(string error, int hresult) { }

	// RVA: 0x2172A30 Offset: 0x2171E30 VA: 0x182172A30 Slot: 13
	public virtual IAsyncResult BeginInvoke(string error, int hresult, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}


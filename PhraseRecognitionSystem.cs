public static class PhraseRecognitionSystem // TypeDefIndex: 3591
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static PhraseRecognitionSystem.ErrorDelegate OnError; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static PhraseRecognitionSystem.StatusDelegate OnStatusChanged; // 0x8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2174070 Offset: 0x2173470 VA: 0x182174070
	private static void PhraseRecognitionSystem_InvokeErrorEvent(SpeechError errorCode) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21740C0 Offset: 0x21734C0 VA: 0x1821740C0
	private static void PhraseRecognitionSystem_InvokeStatusChangedEvent(SpeechSystemStatus status) { }

}

public sealed class PhraseRecognitionSystem.ErrorDelegate : MulticastDelegate // TypeDefIndex: 3592
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19C2F70 Offset: 0x19C2370 VA: 0x1819C2F70 Slot: 12
	public virtual void Invoke(SpeechError errorCode) { }

	// RVA: 0x2172C80 Offset: 0x2172080 VA: 0x182172C80 Slot: 13
	public virtual IAsyncResult BeginInvoke(SpeechError errorCode, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhraseRecognitionSystem.StatusDelegate : MulticastDelegate // TypeDefIndex: 3593
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19C2F70 Offset: 0x19C2370 VA: 0x1819C2F70 Slot: 12
	public virtual void Invoke(SpeechSystemStatus status) { }

	// RVA: 0x2174980 Offset: 0x2173D80 VA: 0x182174980 Slot: 13
	public virtual IAsyncResult BeginInvoke(SpeechSystemStatus status, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}


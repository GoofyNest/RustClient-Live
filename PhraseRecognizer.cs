public abstract class PhraseRecognizer // TypeDefIndex: 3594
{	// Fields
	protected IntPtr m_Recognizer; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private PhraseRecognizer.PhraseRecognizedDelegate OnPhraseRecognized; // 0x18

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2174190 Offset: 0x2173590 VA: 0x182174190
	private void InvokePhraseRecognizedEvent(string text, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, long phraseStartFileTime, long phraseDurationTicks) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21742F0 Offset: 0x21736F0 VA: 0x1821742F0
	private static SemanticMeaning[] MarshalSemanticMeaning(IntPtr keys, IntPtr values, IntPtr valueSizes, int valueCount) { }

}

public sealed class PhraseRecognizer.PhraseRecognizedDelegate : MulticastDelegate // TypeDefIndex: 3595
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A365A0 Offset: 0x1A359A0 VA: 0x181A365A0 Slot: 12
	public virtual void Invoke(PhraseRecognizedEventArgs args) { }

	// RVA: 0x2174110 Offset: 0x2173510 VA: 0x182174110 Slot: 13
	public virtual IAsyncResult BeginInvoke(PhraseRecognizedEventArgs args, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}


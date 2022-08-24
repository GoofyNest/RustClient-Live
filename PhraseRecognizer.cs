public abstract class PhraseRecognizer // TypeDefIndex: 3594
{
	protected IntPtr m_Recognizer; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private PhraseRecognizer.PhraseRecognizedDelegate OnPhraseRecognized; 


	[RequiredByNativeCodeAttribute] 
private void InvokePhraseRecognizedEvent(string text, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, long phraseStartFileTime, long phraseDurationTicks) { }

	[RequiredByNativeCodeAttribute] 
private static SemanticMeaning[] MarshalSemanticMeaning(IntPtr keys, IntPtr values, IntPtr valueSizes, int valueCount) { }

}

public sealed class PhraseRecognizer.PhraseRecognizedDelegate : MulticastDelegate // TypeDefIndex: 3595
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(PhraseRecognizedEventArgs args) { }

public virtual IAsyncResult BeginInvoke(PhraseRecognizedEventArgs args, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}


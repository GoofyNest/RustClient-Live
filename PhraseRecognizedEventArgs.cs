public struct PhraseRecognizedEventArgs // TypeDefIndex: 3606
{	// Fields
	public readonly ConfidenceLevel confidence; // 0x0
	public readonly SemanticMeaning[] semanticMeanings; // 0x8
	public readonly string text; // 0x10
	public readonly DateTime phraseStartTime; // 0x18
	public readonly TimeSpan phraseDuration; // 0x20

	// Methods

	// RVA: 0x235500 Offset: 0x234900 VA: 0x180235500
	internal void .ctor(string text, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, DateTime phraseStartTime, TimeSpan phraseDuration) { }

}


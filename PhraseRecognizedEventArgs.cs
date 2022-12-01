public struct PhraseRecognizedEventArgs // TypeDefIndex: 3609
{
	public readonly ConfidenceLevel confidence;
	public readonly SemanticMeaning[] semanticMeanings;
	public readonly string text;
	public readonly DateTime phraseStartTime;
	public readonly TimeSpan phraseDuration;


	internal void .ctor(string text, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, DateTime phraseStartTime, TimeSpan phraseDuration) { }

}


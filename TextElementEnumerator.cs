public class TextElementEnumerator : IEnumerator // TypeDefIndex: 718
{
	private string str;
	private int index;
	private int startIndex;
	private int strLen;
	private int currTextElementLen;
	[OptionalFieldAttribute]
	private UnicodeCategory uc;
	[OptionalFieldAttribute]
	private int charLen;
	private int endIndex;
	private int nextTextElementLen;

	public object Current { get; }


	internal void .ctor(string str, int startIndex, int strLen) { }

	[OnDeserializingAttribute]
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute]
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute]
	private void OnSerializing(StreamingContext ctx) { }

	public bool MoveNext() { }

	public object get_Current() { }

	public string GetTextElement() { }

	public void Reset() { }

	internal void .ctor() { }

}


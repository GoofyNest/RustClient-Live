public class StringInfo // TypeDefIndex: 716
{
	[OptionalFieldAttribute] 
	private string m_str; 
	private int[] m_indexes; 

	public string String { set; }


	public void .ctor() { }

	public void .ctor(string value) { }

	[OnDeserializingAttribute] 
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] 
	private void OnDeserialized(StreamingContext ctx) { }

	[ComVisibleAttribute] 
	public override bool Equals(object value) { }

	[ComVisibleAttribute] 
	public override int GetHashCode() { }

	public void set_String(string value) { }

	internal static int GetCurrentTextElementLen(string str, int index, int len, ref UnicodeCategory ucCurrent, ref int currentCharCount) { }

	public static TextElementEnumerator GetTextElementEnumerator(string str) { }

	public static TextElementEnumerator GetTextElementEnumerator(string str, int index) { }

}


public class TextBuffer // TypeDefIndex: 6595
{	private Queue<string> buffer; // 0x10
	private StringBuilder builder; // 0x18
	private string text; // 0x20
	private bool dirty; // 0x28
	private int curlines; // 0x2C
	private int maxlines; // 0x30
	private int curchars; // 0x34
	private int maxchars; // 0x38

	public int Count { get; }


	public int get_Count() { }

	public void .ctor(int maxlines, int maxchars = 2147483647) { }

	public void Add(string text) { }

	public void Remove() { }

	public void Clear() { }

	public string Get(int index) { }

	public override string ToString() { }

}


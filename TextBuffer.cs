public class TextBuffer // TypeDefIndex: 6595
{	// Fields
	private Queue<string> buffer; // 0x10
	private StringBuilder builder; // 0x18
	private string text; // 0x20
	private bool dirty; // 0x28
	private int curlines; // 0x2C
	private int maxlines; // 0x30
	private int curchars; // 0x34
	private int maxchars; // 0x38

	// Properties
	public int Count { get; }

	// Methods

	// RVA: 0x5F7BF0 Offset: 0x5F6FF0 VA: 0x1805F7BF0
	public int get_Count() { }

	// RVA: 0x1BA7E40 Offset: 0x1BA7240 VA: 0x181BA7E40
	public void .ctor(int maxlines, int maxchars = 2147483647) { }

	// RVA: 0x1BA7860 Offset: 0x1BA6C60 VA: 0x181BA7860
	public void Add(string text) { }

	// RVA: 0x1BA7C60 Offset: 0x1BA7060 VA: 0x181BA7C60
	public void Remove() { }

	// RVA: 0x1BA7B70 Offset: 0x1BA6F70 VA: 0x181BA7B70
	public void Clear() { }

	// RVA: 0x1BA7BE0 Offset: 0x1BA6FE0 VA: 0x181BA7BE0
	public string Get(int index) { }

	// RVA: 0x1BA7CC0 Offset: 0x1BA70C0 VA: 0x181BA7CC0 Slot: 3
	public override string ToString() { }

}


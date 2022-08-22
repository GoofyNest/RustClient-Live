public class TextTable // TypeDefIndex: 6596
{	private List<TextTable.Row> rows; // 0x10
	private List<TextTable.Column> columns; // 0x18
	private StringBuilder builder; // 0x20
	private string text; // 0x28
	private string jsonText; // 0x30
	private static Encoding utf8NoBom; // 0x0


	public void Clear() { }

	public void AddColumns(string[] values) { }

	public void AddColumn(string title) { }

	public void AddRow(string[] values) { }

	public string ToJson() { }

	public override string ToString() { }

	private void MarkDirty() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private class TextTable.Row // TypeDefIndex: 6597
{	public string[] values; // 0x10


	public void .ctor(string[] values) { }

}

private class TextTable.Column // TypeDefIndex: 6598
{	public string title; // 0x10
	public int width; // 0x18


	public void .ctor(string title) { }

}


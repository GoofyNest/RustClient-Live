public class TextTable // TypeDefIndex: 6596
{	// Fields
	private List<TextTable.Row> rows; // 0x10
	private List<TextTable.Column> columns; // 0x18
	private StringBuilder builder; // 0x20
	private string text; // 0x28
	private string jsonText; // 0x30
	private static Encoding utf8NoBom; // 0x0

	// Methods

	// RVA: 0x1BA8300 Offset: 0x1BA7700 VA: 0x181BA8300
	public void Clear() { }

	// RVA: 0x1BA7FE0 Offset: 0x1BA73E0 VA: 0x181BA7FE0
	public void AddColumns(string[] values) { }

	// RVA: 0x1BA7F20 Offset: 0x1BA7320 VA: 0x181BA7F20
	public void AddColumn(string title) { }

	// RVA: 0x1BA80F0 Offset: 0x1BA74F0 VA: 0x181BA80F0
	public void AddRow(string[] values) { }

	// RVA: 0x1BA83C0 Offset: 0x1BA77C0 VA: 0x181BA83C0
	public string ToJson() { }

	// RVA: 0x1BA8930 Offset: 0x1BA7D30 VA: 0x181BA8930 Slot: 3
	public override string ToString() { }

	// RVA: 0x1BA8380 Offset: 0x1BA7780 VA: 0x181BA8380
	private void MarkDirty() { }

	// RVA: 0x1BA8CA0 Offset: 0x1BA80A0 VA: 0x181BA8CA0
	public void .ctor() { }

	// RVA: 0x1BA8C40 Offset: 0x1BA8040 VA: 0x181BA8C40
	private static void .cctor() { }

}

private class TextTable.Row // TypeDefIndex: 6597
{	// Fields
	public string[] values; // 0x10

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	public void .ctor(string[] values) { }

}

private class TextTable.Column // TypeDefIndex: 6598
{	// Fields
	public string title; // 0x10
	public int width; // 0x18

	// Methods

	// RVA: 0x1B9CE30 Offset: 0x1B9C230 VA: 0x181B9CE30
	public void .ctor(string title) { }

}


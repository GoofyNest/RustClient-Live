internal class TabbedPanel // TypeDefIndex: 12018
{	// Fields
	private int selectedTabID; // 0x10
	private List<TabbedPanel.Tab> tabs; // 0x18

	// Properties
	public TabbedPanel.Tab selectedTab { get; }

	// Methods

	// RVA: 0x797350 Offset: 0x796750 VA: 0x180797350
	public TabbedPanel.Tab get_selectedTab() { }

	// RVA: 0x796D50 Offset: 0x796150 VA: 0x180796D50
	public void Add(TabbedPanel.Tab tab) { }

	// RVA: 0x796FA0 Offset: 0x7963A0 VA: 0x180796FA0
	internal void DrawVertical(float width) { }

	// RVA: 0x796DB0 Offset: 0x7961B0 VA: 0x180796DB0
	internal void DrawContents() { }

	// RVA: 0x7972E0 Offset: 0x7966E0 VA: 0x1807972E0
	public void .ctor() { }

}

public struct TabbedPanel.Tab // TypeDefIndex: 12019
{	// Fields
	public string name; // 0x0
	public Action drawFunc; // 0x8

}


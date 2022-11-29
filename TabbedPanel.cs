internal class TabbedPanel // TypeDefIndex: 13820
{
	private int selectedTabID; 
	private List<TabbedPanel.Tab> tabs; 

	public TabbedPanel.Tab selectedTab { get; }


	public TabbedPanel.Tab get_selectedTab() { }

	public void Add(TabbedPanel.Tab tab) { }

	internal void DrawVertical(float width) { }

	internal void DrawContents() { }

	public void .ctor() { }

}

public struct TabbedPanel.Tab // TypeDefIndex: 13821
{
	public string name; 
	public Action drawFunc; 

}


public class Authorization // TypeDefIndex: 2870
{	// Fields
	private string m_Message; // 0x10
	private bool m_Complete; // 0x18
	internal string ModuleAuthenticationType; // 0x20

	// Properties
	public string Message { get; }
	public bool Complete { get; }

	// Methods

	// RVA: 0x154C250 Offset: 0x154B650 VA: 0x18154C250
	public void .ctor(string token) { }

	// RVA: 0x154C2D0 Offset: 0x154B6D0 VA: 0x18154C2D0
	public void .ctor(string token, bool finished) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Message() { }

	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	public bool get_Complete() { }

}


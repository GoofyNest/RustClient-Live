public sealed class GUISettings // TypeDefIndex: 4043
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_DoubleClickSelectsWord; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_TripleClickSelectsLine; // 0x11
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color m_CursorColor; // 0x14
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_CursorFlashSpeed; // 0x24
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color m_SelectionColor; // 0x28

	// Properties
	public bool doubleClickSelectsWord { get; }
	public bool tripleClickSelectsLine { get; }
	public Color cursorColor { get; }
	public float cursorFlashSpeed { get; }
	public Color selectionColor { get; }

	// Methods

	// RVA: 0x1A67D60 Offset: 0x1A67160 VA: 0x181A67D60
	private static float Internal_GetCursorFlashSpeed() { }

	// RVA: 0x1A67E50 Offset: 0x1A67250 VA: 0x181A67E50
	public bool get_doubleClickSelectsWord() { }

	// RVA: 0x1A67E70 Offset: 0x1A67270 VA: 0x181A67E70
	public bool get_tripleClickSelectsLine() { }

	// RVA: 0x1A67E00 Offset: 0x1A67200 VA: 0x181A67E00
	public Color get_cursorColor() { }

	// RVA: 0x1A67E10 Offset: 0x1A67210 VA: 0x181A67E10
	public float get_cursorFlashSpeed() { }

	// RVA: 0x1A67E60 Offset: 0x1A67260 VA: 0x181A67E60
	public Color get_selectionColor() { }

	// RVA: 0x1A67D90 Offset: 0x1A67190 VA: 0x181A67D90
	public void .ctor() { }

}


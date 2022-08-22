public sealed class GUISettings // TypeDefIndex: 4043
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_DoubleClickSelectsWord; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_TripleClickSelectsLine; // 0x11
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color m_CursorColor; // 0x14
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_CursorFlashSpeed; // 0x24
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color m_SelectionColor; // 0x28

	public bool doubleClickSelectsWord { get; }
	public bool tripleClickSelectsLine { get; }
	public Color cursorColor { get; }
	public float cursorFlashSpeed { get; }
	public Color selectionColor { get; }


	private static float Internal_GetCursorFlashSpeed() { }

	public bool get_doubleClickSelectsWord() { }

	public bool get_tripleClickSelectsLine() { }

	public Color get_cursorColor() { }

	public float get_cursorFlashSpeed() { }

	public Color get_selectionColor() { }

	public void .ctor() { }

}


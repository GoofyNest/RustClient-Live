public sealed class GUISettings // TypeDefIndex: 4048
{
	[SerializeField]
	private bool m_DoubleClickSelectsWord;
	[SerializeField]
	private bool m_TripleClickSelectsLine;
	[SerializeField]
	private Color m_CursorColor;
	[SerializeField]
	private float m_CursorFlashSpeed;
	[SerializeField]
	private Color m_SelectionColor;

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


public class TextEditor // TypeDefIndex: 4061
{	public TouchScreenKeyboard keyboardOnScreen; // 0x10
	public int controlID; // 0x18
	public GUIStyle style; // 0x20
	public bool multiline; // 0x28
	public bool hasHorizontalCursorPos; // 0x29
	public bool isPasswordField; // 0x2A
	[VisibleToOtherModulesAttribute] // RVA: 0xDC1B0 Offset: 0xDB5B0 VA: 0x1800DC1B0
	internal bool m_HasFocus; // 0x2B
	public Vector2 scrollOffset; // 0x2C
	private GUIContent m_Content; // 0x38
	private Rect m_Position; // 0x40
	private int m_CursorIndex; // 0x50
	private int m_SelectIndex; // 0x54
	private bool m_RevealCursor; // 0x58
	public Vector2 graphicalCursorPos; // 0x5C
	public Vector2 graphicalSelectCursorPos; // 0x64
	private bool m_MouseDragSelectsWholeWords; // 0x6C
	private int m_DblClickInitPos; // 0x70
	private TextEditor.DblClickSnapping m_DblClickSnap; // 0x74
	private bool m_bJustSelected; // 0x75
	private int m_iAltCursorPos; // 0x78
	private string oldText; // 0x80
	private int oldPos; // 0x88
	private int oldSelectPos; // 0x8C
	private static Dictionary<Event, TextEditor.TextEditOp> s_Keyactions; // 0x0

	public string text { get; set; }
	public Rect position { get; set; }
	internal virtual Rect localPosition { get; }
	public int cursorIndex { get; set; }
	public int selectIndex { get; set; }
	public bool hasSelection { get; }


	public string get_text() { }

	public void set_text(string value) { }

	public Rect get_position() { }

	public void set_position(Rect value) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDD650 Offset: 0xDCA50 VA: 0x1800DD650
	internal virtual Rect get_localPosition() { }

	public int get_cursorIndex() { }

	public void set_cursorIndex(int value) { }

	public int get_selectIndex() { }

	public void set_selectIndex(int value) { }

	private void ClearCursorPos() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor() { }

	public void OnFocus() { }

	public void OnLostFocus() { }

	private void GrabGraphicalCursorPos() { }

	public bool HandleKeyEvent(Event e) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal bool HandleKeyEvent(Event e, bool textIsReadOnly) { }

	public bool DeleteLineBack() { }

	public bool DeleteWordBack() { }

	public bool DeleteWordForward() { }

	public bool Delete() { }

	public bool Backspace() { }

	public void SelectAll() { }

	public void SelectNone() { }

	public bool get_hasSelection() { }

	public bool DeleteSelection() { }

	public void ReplaceSelection(string replace) { }

	public void Insert(char c) { }

	public void MoveRight() { }

	public void MoveLeft() { }

	public void MoveUp() { }

	public void MoveDown() { }

	public void MoveLineStart() { }

	public void MoveLineEnd() { }

	public void MoveGraphicalLineStart() { }

	public void MoveGraphicalLineEnd() { }

	public void MoveTextStart() { }

	public void MoveTextEnd() { }

	private int IndexOfEndOfLine(int startIndex) { }

	public void MoveParagraphForward() { }

	public void MoveParagraphBackward() { }

	public void MoveCursorToPosition(Vector2 cursorPosition) { }

	protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	public void SelectToPosition(Vector2 cursorPosition) { }

	public void SelectLeft() { }

	public void SelectRight() { }

	public void SelectUp() { }

	public void SelectDown() { }

	public void SelectTextEnd() { }

	public void SelectTextStart() { }

	public void MouseDragSelectsWholeWords(bool on) { }

	public void DblClickSnap(TextEditor.DblClickSnapping snapping) { }

	private int GetGraphicalLineStart(int p) { }

	private int GetGraphicalLineEnd(int p) { }

	private int FindNextSeperator(int startPos) { }

	private int FindPrevSeperator(int startPos) { }

	public void MoveWordRight() { }

	public void MoveToStartOfNextWord() { }

	public void MoveToEndOfPreviousWord() { }

	public void SelectToStartOfNextWord() { }

	public void SelectToEndOfPreviousWord() { }

	private TextEditor.CharacterType ClassifyChar(int index) { }

	public int FindStartOfNextWord(int p) { }

	private int FindEndOfPreviousWord(int p) { }

	public void MoveWordLeft() { }

	public void SelectWordRight() { }

	public void SelectWordLeft() { }

	public void ExpandSelectGraphicalLineStart() { }

	public void ExpandSelectGraphicalLineEnd() { }

	public void SelectGraphicalLineStart() { }

	public void SelectGraphicalLineEnd() { }

	public void SelectParagraphForward() { }

	public void SelectParagraphBackward() { }

	public void SelectCurrentWord() { }

	private int FindEndOfClassification(int p, TextEditor.Direction dir) { }

	public void SelectCurrentParagraph() { }

	public void UpdateScrollOffsetIfNeeded(Event evt) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void UpdateScrollOffset() { }

	public void DrawCursor(string newText) { }

	private bool PerformOperation(TextEditor.TextEditOp operation, bool textIsReadOnly) { }

	public void SaveBackup() { }

	public bool Cut() { }

	public void Copy() { }

	private static string ReplaceNewlinesWithSpaces(string value) { }

	public bool Paste() { }

	private static void MapKey(string key, TextEditor.TextEditOp action) { }

	private void InitKeyActions() { }

	public void DetectFocusChange() { }

	internal virtual void OnDetectFocusChange() { }

	internal virtual void OnCursorIndexChange() { }

	internal virtual void OnSelectIndexChange() { }

	private void ClampTextIndex(ref int index) { }

	private void EnsureValidCodePointIndex(ref int index) { }

	private bool IsValidCodePointIndex(int index) { }

	private int PreviousCodePointIndex(int index) { }

	private int NextCodePointIndex(int index) { }

}

public enum TextEditor.DblClickSnapping // TypeDefIndex: 4062
{	public byte value__; // 0x0
	public const TextEditor.DblClickSnapping WORDS = 0;
	public const TextEditor.DblClickSnapping PARAGRAPHS = 1;

}

private enum TextEditor.CharacterType // TypeDefIndex: 4063
{	public int value__; // 0x0
	public const TextEditor.CharacterType LetterLike = 0;
	public const TextEditor.CharacterType Symbol = 1;
	public const TextEditor.CharacterType Symbol2 = 2;
	public const TextEditor.CharacterType WhiteSpace = 3;

}

private enum TextEditor.Direction // TypeDefIndex: 4064
{	public int value__; // 0x0
	public const TextEditor.Direction Forward = 0;
	public const TextEditor.Direction Backward = 1;

}

private enum TextEditor.TextEditOp // TypeDefIndex: 4065
{	public int value__; // 0x0
	public const TextEditor.TextEditOp MoveLeft = 0;
	public const TextEditor.TextEditOp MoveRight = 1;
	public const TextEditor.TextEditOp MoveUp = 2;
	public const TextEditor.TextEditOp MoveDown = 3;
	public const TextEditor.TextEditOp MoveLineStart = 4;
	public const TextEditor.TextEditOp MoveLineEnd = 5;
	public const TextEditor.TextEditOp MoveTextStart = 6;
	public const TextEditor.TextEditOp MoveTextEnd = 7;
	public const TextEditor.TextEditOp MovePageUp = 8;
	public const TextEditor.TextEditOp MovePageDown = 9;
	public const TextEditor.TextEditOp MoveGraphicalLineStart = 10;
	public const TextEditor.TextEditOp MoveGraphicalLineEnd = 11;
	public const TextEditor.TextEditOp MoveWordLeft = 12;
	public const TextEditor.TextEditOp MoveWordRight = 13;
	public const TextEditor.TextEditOp MoveParagraphForward = 14;
	public const TextEditor.TextEditOp MoveParagraphBackward = 15;
	public const TextEditor.TextEditOp MoveToStartOfNextWord = 16;
	public const TextEditor.TextEditOp MoveToEndOfPreviousWord = 17;
	public const TextEditor.TextEditOp SelectLeft = 18;
	public const TextEditor.TextEditOp SelectRight = 19;
	public const TextEditor.TextEditOp SelectUp = 20;
	public const TextEditor.TextEditOp SelectDown = 21;
	public const TextEditor.TextEditOp SelectTextStart = 22;
	public const TextEditor.TextEditOp SelectTextEnd = 23;
	public const TextEditor.TextEditOp SelectPageUp = 24;
	public const TextEditor.TextEditOp SelectPageDown = 25;
	public const TextEditor.TextEditOp ExpandSelectGraphicalLineStart = 26;
	public const TextEditor.TextEditOp ExpandSelectGraphicalLineEnd = 27;
	public const TextEditor.TextEditOp SelectGraphicalLineStart = 28;
	public const TextEditor.TextEditOp SelectGraphicalLineEnd = 29;
	public const TextEditor.TextEditOp SelectWordLeft = 30;
	public const TextEditor.TextEditOp SelectWordRight = 31;
	public const TextEditor.TextEditOp SelectToEndOfPreviousWord = 32;
	public const TextEditor.TextEditOp SelectToStartOfNextWord = 33;
	public const TextEditor.TextEditOp SelectParagraphBackward = 34;
	public const TextEditor.TextEditOp SelectParagraphForward = 35;
	public const TextEditor.TextEditOp Delete = 36;
	public const TextEditor.TextEditOp Backspace = 37;
	public const TextEditor.TextEditOp DeleteWordBack = 38;
	public const TextEditor.TextEditOp DeleteWordForward = 39;
	public const TextEditor.TextEditOp DeleteLineBack = 40;
	public const TextEditor.TextEditOp Cut = 41;
	public const TextEditor.TextEditOp Copy = 42;
	public const TextEditor.TextEditOp Paste = 43;
	public const TextEditor.TextEditOp SelectAll = 44;
	public const TextEditor.TextEditOp SelectNone = 45;
	public const TextEditor.TextEditOp ScrollStart = 46;
	public const TextEditor.TextEditOp ScrollEnd = 47;
	public const TextEditor.TextEditOp ScrollPageUp = 48;
	public const TextEditor.TextEditOp ScrollPageDown = 49;

}


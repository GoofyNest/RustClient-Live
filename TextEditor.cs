public class TextEditor // TypeDefIndex: 4061
{	// Fields
	public TouchScreenKeyboard keyboardOnScreen; // 0x10
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

	// Properties
	public string text { get; set; }
	public Rect position { get; set; }
	internal virtual Rect localPosition { get; }
	public int cursorIndex { get; set; }
	public int selectIndex { get; set; }
	public bool hasSelection { get; }

	// Methods

	// RVA: 0x22DEEF0 Offset: 0x22DE2F0 VA: 0x1822DEEF0
	public string get_text() { }

	// RVA: 0x22DF080 Offset: 0x22DE480 VA: 0x1822DF080
	public void set_text(string value) { }

	// RVA: 0x22DEED0 Offset: 0x22DE2D0 VA: 0x1822DEED0
	public Rect get_position() { }

	// RVA: 0x22DEF60 Offset: 0x22DE360 VA: 0x1822DEF60
	public void set_position(Rect value) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDD650 Offset: 0xDCA50 VA: 0x1800DD650
	// RVA: 0x22DEEC0 Offset: 0x22DE2C0 VA: 0x1822DEEC0 Slot: 4
	internal virtual Rect get_localPosition() { }

	// RVA: 0x22DEEA0 Offset: 0x22DE2A0 VA: 0x1822DEEA0
	public int get_cursorIndex() { }

	// RVA: 0x22DEF10 Offset: 0x22DE310 VA: 0x1822DEF10
	public void set_cursorIndex(int value) { }

	// RVA: 0x22DEEE0 Offset: 0x22DE2E0 VA: 0x1822DEEE0
	public int get_selectIndex() { }

	// RVA: 0x22DF030 Offset: 0x22DE430 VA: 0x1822DF030
	public void set_selectIndex(int value) { }

	// RVA: 0x22D8340 Offset: 0x22D7740 VA: 0x1822D8340
	private void ClearCursorPos() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22DED80 Offset: 0x22DE180 VA: 0x1822DED80
	public void .ctor() { }

	// RVA: 0x22DBC10 Offset: 0x22DB010 VA: 0x1822DBC10
	public void OnFocus() { }

	// RVA: 0x22DBCC0 Offset: 0x22DB0C0 VA: 0x1822DBCC0
	public void OnLostFocus() { }

	// RVA: 0x22D99F0 Offset: 0x22D8DF0 VA: 0x1822D99F0
	private void GrabGraphicalCursorPos() { }

	// RVA: 0x22D9AF0 Offset: 0x22D8EF0 VA: 0x1822D9AF0
	public bool HandleKeyEvent(Event e) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22D9BF0 Offset: 0x22D8FF0 VA: 0x1822D9BF0
	internal bool HandleKeyEvent(Event e, bool textIsReadOnly) { }

	// RVA: 0x22D8480 Offset: 0x22D7880 VA: 0x1822D8480
	public bool DeleteLineBack() { }

	// RVA: 0x22D87A0 Offset: 0x22D7BA0 VA: 0x1822D87A0
	public bool DeleteWordBack() { }

	// RVA: 0x22D88B0 Offset: 0x22D7CB0 VA: 0x1822D88B0
	public bool DeleteWordForward() { }

	// RVA: 0x22D8980 Offset: 0x22D7D80 VA: 0x1822D8980
	public bool Delete() { }

	// RVA: 0x22D8060 Offset: 0x22D7460 VA: 0x1822D8060
	public bool Backspace() { }

	// RVA: 0x22DCF60 Offset: 0x22DC360 VA: 0x1822DCF60
	public void SelectAll() { }

	// RVA: 0x22DD840 Offset: 0x22DCC40 VA: 0x1822DD840
	public void SelectNone() { }

	// RVA: 0x22DEEB0 Offset: 0x22DE2B0 VA: 0x1822DEEB0
	public bool get_hasSelection() { }

	// RVA: 0x22D8570 Offset: 0x22D7970 VA: 0x1822D8570
	public bool DeleteSelection() { }

	// RVA: 0x22DCE10 Offset: 0x22DC210 VA: 0x1822DCE10
	public void ReplaceSelection(string replace) { }

	// RVA: 0x22DA380 Offset: 0x22D9780 VA: 0x1822DA380
	public void Insert(char c) { }

	// RVA: 0x22DB190 Offset: 0x22DA590 VA: 0x1822DB190
	public void MoveRight() { }

	// RVA: 0x22DAB90 Offset: 0x22D9F90 VA: 0x1822DAB90
	public void MoveLeft() { }

	// RVA: 0x22DB5A0 Offset: 0x22DA9A0 VA: 0x1822DB5A0
	public void MoveUp() { }

	// RVA: 0x22DA870 Offset: 0x22D9C70 VA: 0x1822DA870
	public void MoveDown() { }

	// RVA: 0x22DADD0 Offset: 0x22DA1D0 VA: 0x1822DADD0
	public void MoveLineStart() { }

	// RVA: 0x22DACA0 Offset: 0x22DA0A0 VA: 0x1822DACA0
	public void MoveLineEnd() { }

	// RVA: 0x22DAAE0 Offset: 0x22D9EE0 VA: 0x1822DAAE0
	public void MoveGraphicalLineStart() { }

	// RVA: 0x22DAA30 Offset: 0x22D9E30 VA: 0x1822DAA30
	public void MoveGraphicalLineEnd() { }

	// RVA: 0x22DB370 Offset: 0x22DA770 VA: 0x1822DB370
	public void MoveTextStart() { }

	// RVA: 0x22DB2B0 Offset: 0x22DA6B0 VA: 0x1822DB2B0
	public void MoveTextEnd() { }

	// RVA: 0x22D9D00 Offset: 0x22D9100 VA: 0x1822D9D00
	private int IndexOfEndOfLine(int startIndex) { }

	// RVA: 0x22DB030 Offset: 0x22DA430 VA: 0x1822DB030
	public void MoveParagraphForward() { }

	// RVA: 0x22DAEE0 Offset: 0x22DA2E0 VA: 0x1822DAEE0
	public void MoveParagraphBackward() { }

	// RVA: 0x22DA6D0 Offset: 0x22D9AD0 VA: 0x1822DA6D0
	public void MoveCursorToPosition(Vector2 cursorPosition) { }

	// RVA: 0x22DA540 Offset: 0x22D9940 VA: 0x1822DA540
	protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	// RVA: 0x22DDD80 Offset: 0x22DD180 VA: 0x1822DDD80
	public void SelectToPosition(Vector2 cursorPosition) { }

	// RVA: 0x22DD760 Offset: 0x22DCB60 VA: 0x1822DD760
	public void SelectLeft() { }

	// RVA: 0x22DDB50 Offset: 0x22DCF50 VA: 0x1822DDB50
	public void SelectRight() { }

	// RVA: 0x22DE550 Offset: 0x22DD950 VA: 0x1822DE550
	public void SelectUp() { }

	// RVA: 0x22DD580 Offset: 0x22DC980 VA: 0x1822DD580
	public void SelectDown() { }

	// RVA: 0x22DDC30 Offset: 0x22DD030 VA: 0x1822DDC30
	public void SelectTextEnd() { }

	// RVA: 0x22DDCB0 Offset: 0x22DD0B0 VA: 0x1822DDCB0
	public void SelectTextStart() { }

	// RVA: 0x22DA530 Offset: 0x22D9930 VA: 0x1822DA530
	public void MouseDragSelectsWholeWords(bool on) { }

	// RVA: 0xC86170 Offset: 0xC85570 VA: 0x180C86170
	public void DblClickSnap(TextEditor.DblClickSnapping snapping) { }

	// RVA: 0x22D98B0 Offset: 0x22D8CB0 VA: 0x1822D98B0
	private int GetGraphicalLineStart(int p) { }

	// RVA: 0x22D97A0 Offset: 0x22D8BA0 VA: 0x1822D97A0
	private int GetGraphicalLineEnd(int p) { }

	// RVA: 0x22D9490 Offset: 0x22D8890 VA: 0x1822D9490
	private int FindNextSeperator(int startPos) { }

	// RVA: 0x22D9530 Offset: 0x22D8930 VA: 0x1822D9530
	private int FindPrevSeperator(int startPos) { }

	// RVA: 0x22DB870 Offset: 0x22DAC70 VA: 0x1822DB870
	public void MoveWordRight() { }

	// RVA: 0x22DB4D0 Offset: 0x22DA8D0 VA: 0x1822DB4D0
	public void MoveToStartOfNextWord() { }

	// RVA: 0x22DB400 Offset: 0x22DA800 VA: 0x1822DB400
	public void MoveToEndOfPreviousWord() { }

	// RVA: 0x22DE4E0 Offset: 0x22DD8E0 VA: 0x1822DE4E0
	public void SelectToStartOfNextWord() { }

	// RVA: 0x22DDD10 Offset: 0x22DD110 VA: 0x1822DDD10
	public void SelectToEndOfPreviousWord() { }

	// RVA: 0x22D8210 Offset: 0x22D7610 VA: 0x1822D8210
	private TextEditor.CharacterType ClassifyChar(int index) { }

	// RVA: 0x22D95D0 Offset: 0x22D89D0 VA: 0x1822D95D0
	public int FindStartOfNextWord(int p) { }

	// RVA: 0x22D93C0 Offset: 0x22D87C0 VA: 0x1822D93C0
	private int FindEndOfPreviousWord(int p) { }

	// RVA: 0x22DB720 Offset: 0x22DAB20 VA: 0x1822DB720
	public void MoveWordLeft() { }

	// RVA: 0x22DE770 Offset: 0x22DDB70 VA: 0x1822DE770
	public void SelectWordRight() { }

	// RVA: 0x22DE620 Offset: 0x22DDA20 VA: 0x1822DE620
	public void SelectWordLeft() { }

	// RVA: 0x22D9170 Offset: 0x22D8570 VA: 0x1822D9170
	public void ExpandSelectGraphicalLineStart() { }

	// RVA: 0x22D9080 Offset: 0x22D8480 VA: 0x1822D9080
	public void ExpandSelectGraphicalLineEnd() { }

	// RVA: 0x22DD6F0 Offset: 0x22DCAF0 VA: 0x1822DD6F0
	public void SelectGraphicalLineStart() { }

	// RVA: 0x22DD680 Offset: 0x22DCA80 VA: 0x1822DD680
	public void SelectGraphicalLineEnd() { }

	// RVA: 0x22DDA10 Offset: 0x22DCE10 VA: 0x1822DDA10
	public void SelectParagraphForward() { }

	// RVA: 0x22DD8A0 Offset: 0x22DCCA0 VA: 0x1822DD8A0
	public void SelectParagraphBackward() { }

	// RVA: 0x22DD160 Offset: 0x22DC560 VA: 0x1822DD160
	public void SelectCurrentWord() { }

	// RVA: 0x22D9260 Offset: 0x22D8660 VA: 0x1822D9260
	private int FindEndOfClassification(int p, TextEditor.Direction dir) { }

	// RVA: 0x22DD010 Offset: 0x22DC410 VA: 0x1822DD010
	public void SelectCurrentParagraph() { }

	// RVA: 0x22DE8C0 Offset: 0x22DDCC0 VA: 0x1822DE8C0
	public void UpdateScrollOffsetIfNeeded(Event evt) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22DE910 Offset: 0x22DDD10 VA: 0x1822DE910
	internal void UpdateScrollOffset() { }

	// RVA: 0x22D8A40 Offset: 0x22D7E40 VA: 0x1822D8A40
	public void DrawCursor(string newText) { }

	// RVA: 0x22DBE20 Offset: 0x22DB220 VA: 0x1822DBE20
	private bool PerformOperation(TextEditor.TextEditOp operation, bool textIsReadOnly) { }

	// RVA: 0x22DCF10 Offset: 0x22DC310 VA: 0x1822DCF10
	public void SaveBackup() { }

	// RVA: 0x22D83E0 Offset: 0x22D77E0 VA: 0x1822D83E0
	public bool Cut() { }

	// RVA: 0x22D8350 Offset: 0x22D7750 VA: 0x1822D8350
	public void Copy() { }

	// RVA: 0x22DCD90 Offset: 0x22DC190 VA: 0x1822DCD90
	private static string ReplaceNewlinesWithSpaces(string value) { }

	// RVA: 0x22DBD30 Offset: 0x22DB130 VA: 0x1822DBD30
	public bool Paste() { }

	// RVA: 0x22DA4B0 Offset: 0x22D98B0 VA: 0x1822DA4B0
	private static void MapKey(string key, TextEditor.TextEditOp action) { }

	// RVA: 0x22D9D70 Offset: 0x22D9170 VA: 0x1822D9D70
	private void InitKeyActions() { }

	// RVA: 0x95B120 Offset: 0x95A520 VA: 0x18095B120
	public void DetectFocusChange() { }

	// RVA: 0x22DBAD0 Offset: 0x22DAED0 VA: 0x1822DBAD0 Slot: 5
	internal virtual void OnDetectFocusChange() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 6
	internal virtual void OnCursorIndexChange() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 7
	internal virtual void OnSelectIndexChange() { }

	// RVA: 0x22D8180 Offset: 0x22D7580 VA: 0x1822D8180
	private void ClampTextIndex(ref int index) { }

	// RVA: 0x22D8F00 Offset: 0x22D8300 VA: 0x1822D8F00
	private void EnsureValidCodePointIndex(ref int index) { }

	// RVA: 0x22DA3B0 Offset: 0x22D97B0 VA: 0x1822DA3B0
	private bool IsValidCodePointIndex(int index) { }

	// RVA: 0x22DCCE0 Offset: 0x22DC0E0 VA: 0x1822DCCE0
	private int PreviousCodePointIndex(int index) { }

	// RVA: 0x22DB9D0 Offset: 0x22DADD0 VA: 0x1822DB9D0
	private int NextCodePointIndex(int index) { }

}

public enum TextEditor.DblClickSnapping // TypeDefIndex: 4062
{	// Fields
	public byte value__; // 0x0
	public const TextEditor.DblClickSnapping WORDS = 0;
	public const TextEditor.DblClickSnapping PARAGRAPHS = 1;

}

private enum TextEditor.CharacterType // TypeDefIndex: 4063
{	// Fields
	public int value__; // 0x0
	public const TextEditor.CharacterType LetterLike = 0;
	public const TextEditor.CharacterType Symbol = 1;
	public const TextEditor.CharacterType Symbol2 = 2;
	public const TextEditor.CharacterType WhiteSpace = 3;

}

private enum TextEditor.Direction // TypeDefIndex: 4064
{	// Fields
	public int value__; // 0x0
	public const TextEditor.Direction Forward = 0;
	public const TextEditor.Direction Backward = 1;

}

private enum TextEditor.TextEditOp // TypeDefIndex: 4065
{	// Fields
	public int value__; // 0x0
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


public class InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement // TypeDefIndex: 4946
{	// Fields
	protected TouchScreenKeyboard m_Keyboard; // 0xE8
	private static readonly char[] kSeparators; // 0x0
	[SerializeField] // RVA: 0xECB30 Offset: 0xEBF30 VA: 0x1800ECB30
	[FormerlySerializedAsAttribute] // RVA: 0xECB30 Offset: 0xEBF30 VA: 0x1800ECB30
	protected Text m_TextComponent; // 0xF0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected Graphic m_Placeholder; // 0xF8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private InputField.ContentType m_ContentType; // 0x100
	[FormerlySerializedAsAttribute] // RVA: 0xECD50 Offset: 0xEC150 VA: 0x1800ECD50
	[SerializeField] // RVA: 0xECD50 Offset: 0xEC150 VA: 0x1800ECD50
	private InputField.InputType m_InputType; // 0x104
	[FormerlySerializedAsAttribute] // RVA: 0xED010 Offset: 0xEC410 VA: 0x1800ED010
	[SerializeField] // RVA: 0xED010 Offset: 0xEC410 VA: 0x1800ED010
	private char m_AsteriskChar; // 0x108
	[FormerlySerializedAsAttribute] // RVA: 0xED110 Offset: 0xEC510 VA: 0x1800ED110
	[SerializeField] // RVA: 0xED110 Offset: 0xEC510 VA: 0x1800ED110
	private TouchScreenKeyboardType m_KeyboardType; // 0x10C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private InputField.LineType m_LineType; // 0x110
	[FormerlySerializedAsAttribute] // RVA: 0xED350 Offset: 0xEC750 VA: 0x1800ED350
	[SerializeField] // RVA: 0xED350 Offset: 0xEC750 VA: 0x1800ED350
	private bool m_HideMobileInput; // 0x114
	[FormerlySerializedAsAttribute] // RVA: 0xED4D0 Offset: 0xEC8D0 VA: 0x1800ED4D0
	[SerializeField] // RVA: 0xED4D0 Offset: 0xEC8D0 VA: 0x1800ED4D0
	private InputField.CharacterValidation m_CharacterValidation; // 0x118
	[FormerlySerializedAsAttribute] // RVA: 0xED6B0 Offset: 0xECAB0 VA: 0x1800ED6B0
	[SerializeField] // RVA: 0xED6B0 Offset: 0xECAB0 VA: 0x1800ED6B0
	private int m_CharacterLimit; // 0x11C
	[FormerlySerializedAsAttribute] // RVA: 0xED7F0 Offset: 0xECBF0 VA: 0x1800ED7F0
	[FormerlySerializedAsAttribute] // RVA: 0xED7F0 Offset: 0xECBF0 VA: 0x1800ED7F0
	[FormerlySerializedAsAttribute] // RVA: 0xED7F0 Offset: 0xECBF0 VA: 0x1800ED7F0
	[SerializeField] // RVA: 0xED7F0 Offset: 0xECBF0 VA: 0x1800ED7F0
	private InputField.SubmitEvent m_OnEndEdit; // 0x120
	[FormerlySerializedAsAttribute] // RVA: 0xEDA10 Offset: 0xECE10 VA: 0x1800EDA10
	[FormerlySerializedAsAttribute] // RVA: 0xEDA10 Offset: 0xECE10 VA: 0x1800EDA10
	[SerializeField] // RVA: 0xEDA10 Offset: 0xECE10 VA: 0x1800EDA10
	private InputField.OnChangeEvent m_OnValueChanged; // 0x128
	[FormerlySerializedAsAttribute] // RVA: 0xEDBA0 Offset: 0xECFA0 VA: 0x1800EDBA0
	[SerializeField] // RVA: 0xEDBA0 Offset: 0xECFA0 VA: 0x1800EDBA0
	private InputField.OnValidateInput m_OnValidateInput; // 0x130
	[FormerlySerializedAsAttribute] // RVA: 0xEDD00 Offset: 0xED100 VA: 0x1800EDD00
	[SerializeField] // RVA: 0xEDD00 Offset: 0xED100 VA: 0x1800EDD00
	private Color m_CaretColor; // 0x138
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_CustomCaretColor; // 0x148
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color m_SelectionColor; // 0x14C
	[SerializeField] // RVA: 0xEE250 Offset: 0xED650 VA: 0x1800EE250
	[FormerlySerializedAsAttribute] // RVA: 0xEE250 Offset: 0xED650 VA: 0x1800EE250
	protected string m_Text; // 0x160
	[SerializeField] // RVA: 0xD0710 Offset: 0xCFB10 VA: 0x1800D0710
	[RangeAttribute] // RVA: 0xD0710 Offset: 0xCFB10 VA: 0x1800D0710
	private float m_CaretBlinkRate; // 0x168
	[SerializeField] // RVA: 0xD0830 Offset: 0xCFC30 VA: 0x1800D0830
	[RangeAttribute] // RVA: 0xD0830 Offset: 0xCFC30 VA: 0x1800D0830
	private int m_CaretWidth; // 0x16C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_ReadOnly; // 0x170
	protected int m_CaretPosition; // 0x174
	protected int m_CaretSelectPosition; // 0x178
	private RectTransform caretRectTrans; // 0x180
	protected UIVertex[] m_CursorVerts; // 0x188
	private TextGenerator m_InputTextCache; // 0x190
	private CanvasRenderer m_CachedInputRenderer; // 0x198
	private bool m_PreventFontCallback; // 0x1A0
	protected Mesh m_Mesh; // 0x1A8
	private bool m_AllowInput; // 0x1B0
	private bool m_ShouldActivateNextUpdate; // 0x1B1
	private bool m_UpdateDrag; // 0x1B2
	private bool m_DragPositionOutOfBounds; // 0x1B3
	private const float kHScrollSpeed = 0,05;
	private const float kVScrollSpeed = 0,1;
	protected bool m_CaretVisible; // 0x1B4
	private Coroutine m_BlinkCoroutine; // 0x1B8
	private float m_BlinkStartTime; // 0x1C0
	protected int m_DrawStart; // 0x1C4
	protected int m_DrawEnd; // 0x1C8
	private Coroutine m_DragCoroutine; // 0x1D0
	private string m_OriginalText; // 0x1D8
	private bool m_WasCanceled; // 0x1E0
	private bool m_HasDoneFocusTransition; // 0x1E1
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x1E8
	private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x1F0
	private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~";
	private Event m_ProcessingEvent; // 0x1F8
	private const int k_MaxTextLength = 16382;

	// Properties
	private BaseInput input { get; }
	private string compositionString { get; }
	protected Mesh mesh { get; }
	protected TextGenerator cachedInputTextGenerator { get; }
	public bool shouldHideMobileInput { get; set; }
	private bool shouldActivateOnSelect { get; }
	public string text { get; set; }
	public bool isFocused { get; }
	public float caretBlinkRate { get; set; }
	public int caretWidth { get; set; }
	public Text textComponent { get; set; }
	public Graphic placeholder { get; set; }
	public Color caretColor { get; set; }
	public bool customCaretColor { get; set; }
	public Color selectionColor { get; set; }
	public InputField.SubmitEvent onEndEdit { get; set; }
	[ObsoleteAttribute] // RVA: 0xEEED0 Offset: 0xEE2D0 VA: 0x1800EEED0
	public InputField.OnChangeEvent onValueChange { get; set; }
	public InputField.OnChangeEvent onValueChanged { get; set; }
	public InputField.OnValidateInput onValidateInput { get; set; }
	public int characterLimit { get; set; }
	public InputField.ContentType contentType { get; set; }
	public InputField.LineType lineType { get; set; }
	public InputField.InputType inputType { get; set; }
	public TouchScreenKeyboard touchScreenKeyboard { get; }
	public TouchScreenKeyboardType keyboardType { get; set; }
	public InputField.CharacterValidation characterValidation { get; set; }
	public bool readOnly { get; set; }
	public bool multiLine { get; }
	public char asteriskChar { get; set; }
	public bool wasCanceled { get; }
	protected int caretPositionInternal { get; set; }
	protected int caretSelectPositionInternal { get; set; }
	private bool hasSelection { get; }
	public int caretPosition { get; set; }
	public int selectionAnchorPosition { get; set; }
	public int selectionFocusPosition { get; set; }
	private static string clipboard { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x15FE4A0 Offset: 0x15FD8A0 VA: 0x1815FE4A0
	private BaseInput get_input() { }

	// RVA: 0x15FE380 Offset: 0x15FD780 VA: 0x1815FE380
	private string get_compositionString() { }

	// RVA: 0x15FE050 Offset: 0x15FD450 VA: 0x1815FE050
	protected void .ctor() { }

	// RVA: 0x15FE5C0 Offset: 0x15FD9C0 VA: 0x1815FE5C0
	protected Mesh get_mesh() { }

	// RVA: 0x15FE230 Offset: 0x15FD630 VA: 0x1815FE230
	protected TextGenerator get_cachedInputTextGenerator() { }

	// RVA: 0x15FF650 Offset: 0x15FEA50 VA: 0x1815FF650
	public void set_shouldHideMobileInput(bool value) { }

	// RVA: 0x15FEB10 Offset: 0x15FDF10 VA: 0x1815FEB10
	public bool get_shouldHideMobileInput() { }

	// RVA: 0x15FEAF0 Offset: 0x15FDEF0 VA: 0x1815FEAF0
	private bool get_shouldActivateOnSelect() { }

	// RVA: 0x7FEF40 Offset: 0x7FE340 VA: 0x1807FEF40
	public string get_text() { }

	// RVA: 0x15FF900 Offset: 0x15FED00 VA: 0x1815FF900
	public void set_text(string value) { }

	// RVA: 0x15FCA10 Offset: 0x15FBE10 VA: 0x1815FCA10
	public void SetTextWithoutNotify(string input) { }

	// RVA: 0x15FCA20 Offset: 0x15FBE20 VA: 0x1815FCA20
	private void SetText(string value, bool sendCallback = True) { }

	// RVA: 0xC62530 Offset: 0xC61930 VA: 0x180C62530
	public bool get_isFocused() { }

	// RVA: 0x15FE2B0 Offset: 0x15FD6B0 VA: 0x1815FE2B0
	public float get_caretBlinkRate() { }

	// RVA: 0x15FEBB0 Offset: 0x15FDFB0 VA: 0x1815FEBB0
	public void set_caretBlinkRate(float value) { }

	// RVA: 0x54AF70 Offset: 0x54A370 VA: 0x18054AF70
	public int get_caretWidth() { }

	// RVA: 0x15FEE00 Offset: 0x15FE200 VA: 0x1815FEE00
	public void set_caretWidth(int value) { }

	// RVA: 0xC53210 Offset: 0xC52610 VA: 0x180C53210
	public Text get_textComponent() { }

	// RVA: 0x15FF6A0 Offset: 0x15FEAA0 VA: 0x1815FF6A0
	public void set_textComponent(Text value) { }

	// RVA: 0xB0A550 Offset: 0xB09950 VA: 0x180B0A550
	public Graphic get_placeholder() { }

	// RVA: 0x15FF490 Offset: 0x15FE890 VA: 0x1815FF490
	public void set_placeholder(Graphic value) { }

	// RVA: 0x15FE2C0 Offset: 0x15FD6C0 VA: 0x1815FE2C0
	public Color get_caretColor() { }

	// RVA: 0x15FEC20 Offset: 0x15FE020 VA: 0x1815FEC20
	public void set_caretColor(Color value) { }

	// RVA: 0x1122930 Offset: 0x1121D30 VA: 0x181122930
	public bool get_customCaretColor() { }

	// RVA: 0x15FF170 Offset: 0x15FE570 VA: 0x1815FF170
	public void set_customCaretColor(bool value) { }

	// RVA: 0x15FEAE0 Offset: 0x15FDEE0 VA: 0x1815FEAE0
	public Color get_selectionColor() { }

	// RVA: 0x15FF560 Offset: 0x15FE960 VA: 0x1815FF560
	public void set_selectionColor(Color value) { }

	// RVA: 0x7F5E00 Offset: 0x7F5200 VA: 0x1807F5E00
	public InputField.SubmitEvent get_onEndEdit() { }

	// RVA: 0x15FF3A0 Offset: 0x15FE7A0 VA: 0x1815FF3A0
	public void set_onEndEdit(InputField.SubmitEvent value) { }

	// RVA: 0x4BE070 Offset: 0x4BD470 VA: 0x1804BE070
	public InputField.OnChangeEvent get_onValueChange() { }

	// RVA: 0x15FF440 Offset: 0x15FE840 VA: 0x1815FF440
	public void set_onValueChange(InputField.OnChangeEvent value) { }

	// RVA: 0x4BE070 Offset: 0x4BD470 VA: 0x1804BE070
	public InputField.OnChangeEvent get_onValueChanged() { }

	// RVA: 0x15FF440 Offset: 0x15FE840 VA: 0x1815FF440
	public void set_onValueChanged(InputField.OnChangeEvent value) { }

	// RVA: 0x71AF80 Offset: 0x71A380 VA: 0x18071AF80
	public InputField.OnValidateInput get_onValidateInput() { }

	// RVA: 0x15FF3F0 Offset: 0x15FE7F0 VA: 0x1815FF3F0
	public void set_onValidateInput(InputField.OnValidateInput value) { }

	// RVA: 0x1074D70 Offset: 0x1074170 VA: 0x181074D70
	public int get_characterLimit() { }

	// RVA: 0x15FEEA0 Offset: 0x15FE2A0 VA: 0x1815FEEA0
	public void set_characterLimit(int value) { }

	// RVA: 0xC53140 Offset: 0xC52540 VA: 0x180C53140
	public InputField.ContentType get_contentType() { }

	// RVA: 0x15FEFC0 Offset: 0x15FE3C0 VA: 0x1815FEFC0
	public void set_contentType(InputField.ContentType value) { }

	// RVA: 0xED4C60 Offset: 0xED4060 VA: 0x180ED4C60
	public InputField.LineType get_lineType() { }

	// RVA: 0x15FF2C0 Offset: 0x15FE6C0 VA: 0x1815FF2C0
	public void set_lineType(InputField.LineType value) { }

	// RVA: 0xC53050 Offset: 0xC52450 VA: 0x180C53050
	public InputField.InputType get_inputType() { }

	// RVA: 0x15FF1E0 Offset: 0x15FE5E0 VA: 0x1815FF1E0
	public void set_inputType(InputField.InputType value) { }

	// RVA: 0x94E830 Offset: 0x94DC30 VA: 0x18094E830
	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	// RVA: 0xC53060 Offset: 0xC52460 VA: 0x180C53060
	public TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x15FF250 Offset: 0x15FE650 VA: 0x1815FF250
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x90CEB0 Offset: 0x90C2B0 VA: 0x18090CEB0
	public InputField.CharacterValidation get_characterValidation() { }

	// RVA: 0x15FEF50 Offset: 0x15FE350 VA: 0x1815FEF50
	public void set_characterValidation(InputField.CharacterValidation value) { }

	// RVA: 0x15FEAD0 Offset: 0x15FDED0 VA: 0x1815FEAD0
	public bool get_readOnly() { }

	// RVA: 0x15FF4E0 Offset: 0x15FE8E0 VA: 0x1815FF4E0
	public void set_readOnly(bool value) { }

	// RVA: 0x15FE660 Offset: 0x15FDA60 VA: 0x1815FE660
	public bool get_multiLine() { }

	// RVA: 0x15FE220 Offset: 0x15FD620 VA: 0x1815FE220
	public char get_asteriskChar() { }

	// RVA: 0x15FEB50 Offset: 0x15FDF50 VA: 0x1815FEB50
	public void set_asteriskChar(char value) { }

	// RVA: 0x15FEB40 Offset: 0x15FDF40 VA: 0x1815FEB40
	public bool get_wasCanceled() { }

	// RVA: 0x15F6050 Offset: 0x15F5450 VA: 0x1815F6050
	protected void ClampPos(ref int pos) { }

	// RVA: 0x15FE320 Offset: 0x15FD720 VA: 0x1815FE320
	protected int get_caretPositionInternal() { }

	// RVA: 0x15FECA0 Offset: 0x15FE0A0 VA: 0x1815FECA0
	protected void set_caretPositionInternal(int value) { }

	// RVA: 0x15FE350 Offset: 0x15FD750 VA: 0x1815FE350
	protected int get_caretSelectPositionInternal() { }

	// RVA: 0x15FEDB0 Offset: 0x15FE1B0 VA: 0x1815FEDB0
	protected void set_caretSelectPositionInternal(int value) { }

	// RVA: 0x15FE430 Offset: 0x15FD830 VA: 0x1815FE430
	private bool get_hasSelection() { }

	// RVA: 0x15FE350 Offset: 0x15FD750 VA: 0x1815FE350
	public int get_caretPosition() { }

	// RVA: 0x15FECF0 Offset: 0x15FE0F0 VA: 0x1815FECF0
	public void set_caretPosition(int value) { }

	// RVA: 0x15FE320 Offset: 0x15FD720 VA: 0x1815FE320
	public int get_selectionAnchorPosition() { }

	// RVA: 0x15FF4F0 Offset: 0x15FE8F0 VA: 0x1815FF4F0
	public void set_selectionAnchorPosition(int value) { }

	// RVA: 0x15FE350 Offset: 0x15FD750 VA: 0x1815FE350
	public int get_selectionFocusPosition() { }

	// RVA: 0x15FF5E0 Offset: 0x15FE9E0 VA: 0x1815FF5E0
	public void set_selectionFocusPosition(int value) { }

	// RVA: 0x15FB030 Offset: 0x15FA430 VA: 0x1815FB030 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x15FAAB0 Offset: 0x15F9EB0 VA: 0x1815FAAB0 Slot: 7
	protected override void OnDisable() { }

	[IteratorStateMachineAttribute] // RVA: 0xEE7B0 Offset: 0xEDBB0 VA: 0x1800EE7B0
	// RVA: 0x15F5FE0 Offset: 0x15F53E0 VA: 0x1815F5FE0
	private IEnumerator CaretBlink() { }

	// RVA: 0x15FC040 Offset: 0x15FB440 VA: 0x1815FC040
	private void SetCaretVisible() { }

	// RVA: 0x15FBF70 Offset: 0x15FB370 VA: 0x1815FBF70
	private void SetCaretActive() { }

	// RVA: 0x15FCF10 Offset: 0x15FC310 VA: 0x1815FCF10
	private void UpdateCaretMaterial() { }

	// RVA: 0x15FB5E0 Offset: 0x15FA9E0 VA: 0x1815FB5E0
	protected void OnFocus() { }

	// RVA: 0x15FB5E0 Offset: 0x15FA9E0 VA: 0x1815FB5E0
	protected void SelectAll() { }

	// RVA: 0x15FA690 Offset: 0x15F9A90 VA: 0x1815FA690
	public void MoveTextEnd(bool shift) { }

	// RVA: 0x15FA760 Offset: 0x15F9B60 VA: 0x1815FA760
	public void MoveTextStart(bool shift) { }

	// RVA: 0xC62460 Offset: 0xC61860 VA: 0x180C62460
	private static string get_clipboard() { }

	// RVA: 0xC63040 Offset: 0xC62440 VA: 0x180C63040
	private static void set_clipboard(string value) { }

	// RVA: 0x15F89C0 Offset: 0x15F7DC0 VA: 0x1815F89C0
	private bool InPlaceEditing() { }

	// RVA: 0x15FCDE0 Offset: 0x15FC1E0 VA: 0x1815FCDE0
	private void UpdateCaretFromKeyboard() { }

	// RVA: 0x15F92D0 Offset: 0x15F86D0 VA: 0x1815F92D0 Slot: 59
	protected virtual void LateUpdate() { }

	[ObsoleteAttribute] // RVA: 0xEE960 Offset: 0xEDD60 VA: 0x1800EE960
	// RVA: 0x15FBAC0 Offset: 0x15FAEC0 VA: 0x1815FBAC0
	public Vector2 ScreenToLocal(Vector2 screen) { }

	// RVA: 0x15F8760 Offset: 0x15F7B60 VA: 0x1815F8760
	private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator) { }

	// RVA: 0x15F8180 Offset: 0x15F7580 VA: 0x1815F8180
	protected int GetCharacterIndexFromPosition(Vector2 pos) { }

	// RVA: 0x15F9D00 Offset: 0x15F9100 VA: 0x1815F9D00
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x15FAA50 Offset: 0x15F9E50 VA: 0x1815FAA50 Slot: 60
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x15FAD10 Offset: 0x15FA110 VA: 0x1815FAD10 Slot: 61
	public virtual void OnDrag(PointerEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0xEEB00 Offset: 0xEDF00 VA: 0x1800EEB00
	// RVA: 0x15F9DF0 Offset: 0x15F91F0 VA: 0x1815F9DF0
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0x15FB280 Offset: 0x15FA680 VA: 0x1815FB280 Slot: 62
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x15FB670 Offset: 0x15FAA70 VA: 0x1815FB670 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x15F8CE0 Offset: 0x15F80E0 VA: 0x1815F8CE0
	protected InputField.EditState KeyPressed(Event evt) { }

	// RVA: 0x15F8C80 Offset: 0x15F8080 VA: 0x1815F8C80
	private bool IsValidChar(char c) { }

	// RVA: 0x15FBAA0 Offset: 0x15FAEA0 VA: 0x1815FBAA0
	public void ProcessEvent(Event e) { }

	// RVA: 0x15FB940 Offset: 0x15FAD40 VA: 0x1815FB940 Slot: 63
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x15F8660 Offset: 0x15F7A60 VA: 0x1815F8660
	private string GetSelectedString() { }

	// RVA: 0x15F6AF0 Offset: 0x15F5EF0 VA: 0x1815F6AF0
	private int FindtNextWordBegin() { }

	// RVA: 0x15FA3B0 Offset: 0x15F97B0 VA: 0x1815FA3B0
	private void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0x15F6C00 Offset: 0x15F6000 VA: 0x1815F6C00
	private int FindtPrevWordBegin() { }

	// RVA: 0x15FA0F0 Offset: 0x15F94F0 VA: 0x1815FA0F0
	private void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0x15F6760 Offset: 0x15F5B60 VA: 0x1815F6760
	private int DetermineCharacterLine(int charPos, TextGenerator generator) { }

	// RVA: 0x15F9A20 Offset: 0x15F8E20 VA: 0x1815F9A20
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x15F97A0 Offset: 0x15F8BA0 VA: 0x1815F97A0
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x15F9E80 Offset: 0x15F9280 VA: 0x1815F9E80
	private void MoveDown(bool shift) { }

	// RVA: 0x15F9E90 Offset: 0x15F9290 VA: 0x1815F9E90
	private void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0x15FA820 Offset: 0x15F9C20 VA: 0x1815FA820
	private void MoveUp(bool shift) { }

	// RVA: 0x15FA830 Offset: 0x15F9C30 VA: 0x1815FA830
	private void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x15F6450 Offset: 0x15F5850 VA: 0x1815F6450
	private void Delete() { }

	// RVA: 0x15F6D00 Offset: 0x15F6100 VA: 0x1815F6D00
	private void ForwardSpace() { }

	// RVA: 0x15F5E40 Offset: 0x15F5240 VA: 0x1815F5E40
	private void Backspace() { }

	// RVA: 0x15F89F0 Offset: 0x15F7DF0 VA: 0x1815F89F0
	private void Insert(char c) { }

	// RVA: 0x15FD8F0 Offset: 0x15FCCF0 VA: 0x1815FD8F0
	private void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0x15FBEA0 Offset: 0x15FB2A0 VA: 0x1815FBEA0
	private void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0x15FBF10 Offset: 0x15FB310 VA: 0x1815FBF10
	private void SendOnValueChanged() { }

	// RVA: 0x15FBE40 Offset: 0x15FB240 VA: 0x1815FBE40
	protected void SendOnSubmit() { }

	// RVA: 0x15F5460 Offset: 0x15F4860 VA: 0x1815F5460 Slot: 64
	protected virtual void Append(string input) { }

	// RVA: 0x15F5510 Offset: 0x15F4910 VA: 0x1815F5510 Slot: 65
	protected virtual void Append(char input) { }

	// RVA: 0x15FD480 Offset: 0x15FC880 VA: 0x1815FD480
	protected void UpdateLabel() { }

	// RVA: 0x15F8BB0 Offset: 0x15F7FB0 VA: 0x1815F8BB0
	private bool IsSelectionVisible() { }

	// RVA: 0x15F8530 Offset: 0x15F7930 VA: 0x1815F8530
	private static int GetLineStartPosition(TextGenerator gen, int line) { }

	// RVA: 0x15F8400 Offset: 0x15F7800 VA: 0x1815F8400
	private static int GetLineEndPosition(TextGenerator gen, int line) { }

	// RVA: 0x15FC080 Offset: 0x15FB480 VA: 0x1815FC080
	private void SetDrawRangeToContainCaretPosition(int caretPos) { }

	// RVA: 0x15F6CF0 Offset: 0x15F60F0 VA: 0x1815F6CF0
	public void ForceLabelUpdate() { }

	// RVA: 0x15F9CA0 Offset: 0x15F90A0 VA: 0x1815F9CA0
	private void MarkGeometryAsDirty() { }

	// RVA: 0x15FBAB0 Offset: 0x15FAEB0 VA: 0x1815FBAB0 Slot: 66
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 67
	public virtual void LayoutComplete() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 68
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x15FD030 Offset: 0x15FC430 VA: 0x1815FD030
	private void UpdateGeometry() { }

	// RVA: 0x15F56A0 Offset: 0x15F4AA0 VA: 0x1815F56A0
	private void AssignPositioningIfNeeded() { }

	// RVA: 0x15FB2B0 Offset: 0x15FA6B0 VA: 0x1815FB2B0
	private void OnFillVBO(Mesh vbo) { }

	// RVA: 0x15F6E30 Offset: 0x15F6230 VA: 0x1815F6E30
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x15F6090 Offset: 0x15F5490 VA: 0x1815F6090
	private void CreateCursorVerts() { }

	// RVA: 0x15F7780 Offset: 0x15F6B80 VA: 0x1815F7780
	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x15FD950 Offset: 0x15FCD50 VA: 0x1815FD950
	protected char Validate(string text, int pos, char ch) { }

	// RVA: 0x15F5310 Offset: 0x15F4710 VA: 0x1815F5310
	public void ActivateInputField() { }

	// RVA: 0x15F4FC0 Offset: 0x15F43C0 VA: 0x1815F4FC0
	private void ActivateInputFieldInternal() { }

	// RVA: 0x15FB8B0 Offset: 0x15FACB0 VA: 0x1815FB8B0 Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x15FB640 Offset: 0x15FAA40 VA: 0x1815FB640 Slot: 69
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x15F6230 Offset: 0x15F5630 VA: 0x1815F6230
	public void DeactivateInputField() { }

	// RVA: 0x15FAA80 Offset: 0x15F9E80 VA: 0x1815FAA80 Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x15FB8F0 Offset: 0x15FACF0 VA: 0x1815FB8F0 Slot: 70
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x15F68C0 Offset: 0x15F5CC0 VA: 0x1815F68C0
	private void EnforceContentType() { }

	// RVA: 0x15F6A30 Offset: 0x15F5E30 VA: 0x1815F6A30
	private void EnforceTextHOverflow() { }

	// RVA: 0x15FCD50 Offset: 0x15FC150 VA: 0x1815FCD50
	private void SetToCustomIfContentTypeIsNot(InputField.ContentType[] allowedContentTypes) { }

	// RVA: 0x15FCDC0 Offset: 0x15FC1C0 VA: 0x1815FCDC0
	private void SetToCustom() { }

	// RVA: 0x15F6890 Offset: 0x15F5C90 VA: 0x1815F6890 Slot: 26
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 71
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 72
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 73
	public virtual float get_minWidth() { }

	// RVA: 0x15FE8F0 Offset: 0x15FDCF0 VA: 0x1815FE8F0 Slot: 74
	public virtual float get_preferredWidth() { }

	// RVA: 0xC62540 Offset: 0xC61940 VA: 0x180C62540 Slot: 75
	public virtual float get_flexibleWidth() { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 76
	public virtual float get_minHeight() { }

	// RVA: 0x15FE680 Offset: 0x15FDA80 VA: 0x1815FE680 Slot: 77
	public virtual float get_preferredHeight() { }

	// RVA: 0xC62540 Offset: 0xC61940 VA: 0x180C62540 Slot: 78
	public virtual float get_flexibleHeight() { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 79
	public virtual int get_layoutPriority() { }

	// RVA: 0x15FDFE0 Offset: 0x15FD3E0 VA: 0x1815FDFE0
	private static void .cctor() { }

	// RVA: 0xAB8650 Offset: 0xAB7A50 VA: 0x180AB8650 Slot: 46
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

public enum InputField.ContentType // TypeDefIndex: 4947
{	// Fields
	public int value__; // 0x0
	public const InputField.ContentType Standard = 0;
	public const InputField.ContentType Autocorrected = 1;
	public const InputField.ContentType IntegerNumber = 2;
	public const InputField.ContentType DecimalNumber = 3;
	public const InputField.ContentType Alphanumeric = 4;
	public const InputField.ContentType Name = 5;
	public const InputField.ContentType EmailAddress = 6;
	public const InputField.ContentType Password = 7;
	public const InputField.ContentType Pin = 8;
	public const InputField.ContentType Custom = 9;

}

public enum InputField.InputType // TypeDefIndex: 4948
{	// Fields
	public int value__; // 0x0
	public const InputField.InputType Standard = 0;
	public const InputField.InputType AutoCorrect = 1;
	public const InputField.InputType Password = 2;

}

public enum InputField.CharacterValidation // TypeDefIndex: 4949
{	// Fields
	public int value__; // 0x0
	public const InputField.CharacterValidation None = 0;
	public const InputField.CharacterValidation Integer = 1;
	public const InputField.CharacterValidation Decimal = 2;
	public const InputField.CharacterValidation Alphanumeric = 3;
	public const InputField.CharacterValidation Name = 4;
	public const InputField.CharacterValidation EmailAddress = 5;

}

public enum InputField.LineType // TypeDefIndex: 4950
{	// Fields
	public int value__; // 0x0
	public const InputField.LineType SingleLine = 0;
	public const InputField.LineType MultiLineSubmit = 1;
	public const InputField.LineType MultiLineNewline = 2;

}

public sealed class InputField.OnValidateInput : MulticastDelegate // TypeDefIndex: 4951
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xD928B0 Offset: 0xD91CB0 VA: 0x180D928B0 Slot: 12
	public virtual char Invoke(string text, int charIndex, char addedChar) { }

	// RVA: 0x1711CD0 Offset: 0x17110D0 VA: 0x181711CD0 Slot: 13
	public virtual IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

	// RVA: 0xD92880 Offset: 0xD91C80 VA: 0x180D92880 Slot: 14
	public virtual char EndInvoke(IAsyncResult result) { }

}

public class InputField.SubmitEvent : UnityEvent<string> // TypeDefIndex: 4952
{	// Methods

	// RVA: 0x17218D0 Offset: 0x1720CD0 VA: 0x1817218D0
	public void .ctor() { }

}

public class InputField.OnChangeEvent : UnityEvent<string> // TypeDefIndex: 4953
{	// Methods

	// RVA: 0x1711C90 Offset: 0x1711090 VA: 0x181711C90
	public void .ctor() { }

}

private sealed class InputField.<CaretBlink>d__159 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 4955
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public InputField <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1721910 Offset: 0x1720D10 VA: 0x181721910 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1721A60 Offset: 0x1720E60 VA: 0x181721A60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class InputField.<MouseDragOutsideRect>d__179 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 4956
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public InputField <>4__this; // 0x20
	public PointerEventData eventData; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1721E30 Offset: 0x1721230 VA: 0x181721E30 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1722100 Offset: 0x1721500 VA: 0x181722100 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}


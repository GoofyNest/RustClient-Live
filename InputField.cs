public class InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement // TypeDefIndex: 4946
{	protected TouchScreenKeyboard m_Keyboard; // 0xE8
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


	private BaseInput get_input() { }

	private string get_compositionString() { }

	protected void .ctor() { }

	protected Mesh get_mesh() { }

	protected TextGenerator get_cachedInputTextGenerator() { }

	public void set_shouldHideMobileInput(bool value) { }

	public bool get_shouldHideMobileInput() { }

	private bool get_shouldActivateOnSelect() { }

	public string get_text() { }

	public void set_text(string value) { }

	public void SetTextWithoutNotify(string input) { }

	private void SetText(string value, bool sendCallback = True) { }

	public bool get_isFocused() { }

	public float get_caretBlinkRate() { }

	public void set_caretBlinkRate(float value) { }

	public int get_caretWidth() { }

	public void set_caretWidth(int value) { }

	public Text get_textComponent() { }

	public void set_textComponent(Text value) { }

	public Graphic get_placeholder() { }

	public void set_placeholder(Graphic value) { }

	public Color get_caretColor() { }

	public void set_caretColor(Color value) { }

	public bool get_customCaretColor() { }

	public void set_customCaretColor(bool value) { }

	public Color get_selectionColor() { }

	public void set_selectionColor(Color value) { }

	public InputField.SubmitEvent get_onEndEdit() { }

	public void set_onEndEdit(InputField.SubmitEvent value) { }

	public InputField.OnChangeEvent get_onValueChange() { }

	public void set_onValueChange(InputField.OnChangeEvent value) { }

	public InputField.OnChangeEvent get_onValueChanged() { }

	public void set_onValueChanged(InputField.OnChangeEvent value) { }

	public InputField.OnValidateInput get_onValidateInput() { }

	public void set_onValidateInput(InputField.OnValidateInput value) { }

	public int get_characterLimit() { }

	public void set_characterLimit(int value) { }

	public InputField.ContentType get_contentType() { }

	public void set_contentType(InputField.ContentType value) { }

	public InputField.LineType get_lineType() { }

	public void set_lineType(InputField.LineType value) { }

	public InputField.InputType get_inputType() { }

	public void set_inputType(InputField.InputType value) { }

	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	public TouchScreenKeyboardType get_keyboardType() { }

	public void set_keyboardType(TouchScreenKeyboardType value) { }

	public InputField.CharacterValidation get_characterValidation() { }

	public void set_characterValidation(InputField.CharacterValidation value) { }

	public bool get_readOnly() { }

	public void set_readOnly(bool value) { }

	public bool get_multiLine() { }

	public char get_asteriskChar() { }

	public void set_asteriskChar(char value) { }

	public bool get_wasCanceled() { }

	protected void ClampPos(ref int pos) { }

	protected int get_caretPositionInternal() { }

	protected void set_caretPositionInternal(int value) { }

	protected int get_caretSelectPositionInternal() { }

	protected void set_caretSelectPositionInternal(int value) { }

	private bool get_hasSelection() { }

	public int get_caretPosition() { }

	public void set_caretPosition(int value) { }

	public int get_selectionAnchorPosition() { }

	public void set_selectionAnchorPosition(int value) { }

	public int get_selectionFocusPosition() { }

	public void set_selectionFocusPosition(int value) { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	[IteratorStateMachineAttribute] // RVA: 0xEE7B0 Offset: 0xEDBB0 VA: 0x1800EE7B0
	private IEnumerator CaretBlink() { }

	private void SetCaretVisible() { }

	private void SetCaretActive() { }

	private void UpdateCaretMaterial() { }

	protected void OnFocus() { }

	protected void SelectAll() { }

	public void MoveTextEnd(bool shift) { }

	public void MoveTextStart(bool shift) { }

	private static string get_clipboard() { }

	private static void set_clipboard(string value) { }

	private bool InPlaceEditing() { }

	private void UpdateCaretFromKeyboard() { }

	protected virtual void LateUpdate() { }

	[ObsoleteAttribute] // RVA: 0xEE960 Offset: 0xEDD60 VA: 0x1800EE960
	public Vector2 ScreenToLocal(Vector2 screen) { }

	private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator) { }

	protected int GetCharacterIndexFromPosition(Vector2 pos) { }

	private bool MayDrag(PointerEventData eventData) { }

	public virtual void OnBeginDrag(PointerEventData eventData) { }

	public virtual void OnDrag(PointerEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0xEEB00 Offset: 0xEDF00 VA: 0x1800EEB00
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	public virtual void OnEndDrag(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	protected InputField.EditState KeyPressed(Event evt) { }

	private bool IsValidChar(char c) { }

	public void ProcessEvent(Event e) { }

	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	private string GetSelectedString() { }

	private int FindtNextWordBegin() { }

	private void MoveRight(bool shift, bool ctrl) { }

	private int FindtPrevWordBegin() { }

	private void MoveLeft(bool shift, bool ctrl) { }

	private int DetermineCharacterLine(int charPos, TextGenerator generator) { }

	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	private void MoveDown(bool shift) { }

	private void MoveDown(bool shift, bool goToLastChar) { }

	private void MoveUp(bool shift) { }

	private void MoveUp(bool shift, bool goToFirstChar) { }

	private void Delete() { }

	private void ForwardSpace() { }

	private void Backspace() { }

	private void Insert(char c) { }

	private void UpdateTouchKeyboardFromEditChanges() { }

	private void SendOnValueChangedAndUpdateLabel() { }

	private void SendOnValueChanged() { }

	protected void SendOnSubmit() { }

	protected virtual void Append(string input) { }

	protected virtual void Append(char input) { }

	protected void UpdateLabel() { }

	private bool IsSelectionVisible() { }

	private static int GetLineStartPosition(TextGenerator gen, int line) { }

	private static int GetLineEndPosition(TextGenerator gen, int line) { }

	private void SetDrawRangeToContainCaretPosition(int caretPos) { }

	public void ForceLabelUpdate() { }

	private void MarkGeometryAsDirty() { }

	public virtual void Rebuild(CanvasUpdate update) { }

	public virtual void LayoutComplete() { }

	public virtual void GraphicUpdateComplete() { }

	private void UpdateGeometry() { }

	private void AssignPositioningIfNeeded() { }

	private void OnFillVBO(Mesh vbo) { }

	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	private void CreateCursorVerts() { }

	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	protected char Validate(string text, int pos, char ch) { }

	public void ActivateInputField() { }

	private void ActivateInputFieldInternal() { }

	public override void OnSelect(BaseEventData eventData) { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	public void DeactivateInputField() { }

	public override void OnDeselect(BaseEventData eventData) { }

	public virtual void OnSubmit(BaseEventData eventData) { }

	private void EnforceContentType() { }

	private void EnforceTextHOverflow() { }

	private void SetToCustomIfContentTypeIsNot(InputField.ContentType[] allowedContentTypes) { }

	private void SetToCustom() { }

	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	public virtual void CalculateLayoutInputHorizontal() { }

	public virtual void CalculateLayoutInputVertical() { }

	public virtual float get_minWidth() { }

	public virtual float get_preferredWidth() { }

	public virtual float get_flexibleWidth() { }

	public virtual float get_minHeight() { }

	public virtual float get_preferredHeight() { }

	public virtual float get_flexibleHeight() { }

	public virtual int get_layoutPriority() { }

	private static void .cctor() { }

	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

public enum InputField.ContentType // TypeDefIndex: 4947
{	public int value__; // 0x0
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
{	public int value__; // 0x0
	public const InputField.InputType Standard = 0;
	public const InputField.InputType AutoCorrect = 1;
	public const InputField.InputType Password = 2;

}

public enum InputField.CharacterValidation // TypeDefIndex: 4949
{	public int value__; // 0x0
	public const InputField.CharacterValidation None = 0;
	public const InputField.CharacterValidation Integer = 1;
	public const InputField.CharacterValidation Decimal = 2;
	public const InputField.CharacterValidation Alphanumeric = 3;
	public const InputField.CharacterValidation Name = 4;
	public const InputField.CharacterValidation EmailAddress = 5;

}

public enum InputField.LineType // TypeDefIndex: 4950
{	public int value__; // 0x0
	public const InputField.LineType SingleLine = 0;
	public const InputField.LineType MultiLineSubmit = 1;
	public const InputField.LineType MultiLineNewline = 2;

}

public sealed class InputField.OnValidateInput : MulticastDelegate // TypeDefIndex: 4951
{
	public void .ctor(object object, IntPtr method) { }

	public virtual char Invoke(string text, int charIndex, char addedChar) { }

	public virtual IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

	public virtual char EndInvoke(IAsyncResult result) { }

}

public class InputField.SubmitEvent : UnityEvent<string> // TypeDefIndex: 4952
{
	public void .ctor() { }

}

public class InputField.OnChangeEvent : UnityEvent<string> // TypeDefIndex: 4953
{
	public void .ctor() { }

}

private sealed class InputField.<CaretBlink>d__159 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 4955
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public InputField <>4__this; // 0x20

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class InputField.<MouseDragOutsideRect>d__179 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 4956
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public InputField <>4__this; // 0x20
	public PointerEventData eventData; // 0x28

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}


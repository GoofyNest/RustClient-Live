public class InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement // TypeDefIndex: 4952
{
	protected TouchScreenKeyboard m_Keyboard;
	private static readonly char[] kSeparators;
	[SerializeField]
	[FormerlySerializedAsAttribute]
	protected Text m_TextComponent;
	[SerializeField]
	protected Graphic m_Placeholder;
	[SerializeField]
	private InputField.ContentType m_ContentType;
	[FormerlySerializedAsAttribute]
	[SerializeField]
	private InputField.InputType m_InputType;
	[FormerlySerializedAsAttribute]
	[SerializeField]
	private char m_AsteriskChar;
	[FormerlySerializedAsAttribute]
	[SerializeField]
	private TouchScreenKeyboardType m_KeyboardType;
	[SerializeField]
	private InputField.LineType m_LineType;
	[FormerlySerializedAsAttribute]
	[SerializeField]
	private bool m_HideMobileInput;
	[FormerlySerializedAsAttribute]
	[SerializeField]
	private InputField.CharacterValidation m_CharacterValidation;
	[FormerlySerializedAsAttribute]
	[SerializeField]
	private int m_CharacterLimit;
	[FormerlySerializedAsAttribute]
	[FormerlySerializedAsAttribute]
	[FormerlySerializedAsAttribute]
	[SerializeField]
	private InputField.SubmitEvent m_OnEndEdit;
	[FormerlySerializedAsAttribute]
	[FormerlySerializedAsAttribute]
	[SerializeField]
	private InputField.OnChangeEvent m_OnValueChanged;
	[FormerlySerializedAsAttribute]
	[SerializeField]
	private InputField.OnValidateInput m_OnValidateInput;
	[FormerlySerializedAsAttribute]
	[SerializeField]
	private Color m_CaretColor;
	[SerializeField]
	private bool m_CustomCaretColor;
	[SerializeField]
	private Color m_SelectionColor;
	[SerializeField]
	[FormerlySerializedAsAttribute]
	protected string m_Text;
	[SerializeField]
	[RangeAttribute]
	private float m_CaretBlinkRate;
	[SerializeField]
	[RangeAttribute]
	private int m_CaretWidth;
	[SerializeField]
	private bool m_ReadOnly;
	protected int m_CaretPosition;
	protected int m_CaretSelectPosition;
	private RectTransform caretRectTrans;
	protected UIVertex[] m_CursorVerts;
	private TextGenerator m_InputTextCache;
	private CanvasRenderer m_CachedInputRenderer;
	private bool m_PreventFontCallback;
	protected Mesh m_Mesh;
	private bool m_AllowInput;
	private bool m_ShouldActivateNextUpdate;
	private bool m_UpdateDrag;
	private bool m_DragPositionOutOfBounds;
	private const float kHScrollSpeed = 0,05;
	private const float kVScrollSpeed = 0,1;
	protected bool m_CaretVisible;
	private Coroutine m_BlinkCoroutine;
	private float m_BlinkStartTime;
	protected int m_DrawStart;
	protected int m_DrawEnd;
	private Coroutine m_DragCoroutine;
	private string m_OriginalText;
	private bool m_WasCanceled;
	private bool m_HasDoneFocusTransition;
	private WaitForSecondsRealtime m_WaitForSecondsRealtime;
	private bool m_TouchKeyboardAllowsInPlaceEditing;
	private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~";
	private Event m_ProcessingEvent;
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
	[ObsoleteAttribute]
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

	[IteratorStateMachineAttribute]
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

	[ObsoleteAttribute]
	public Vector2 ScreenToLocal(Vector2 screen) { }

	private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator) { }

	protected int GetCharacterIndexFromPosition(Vector2 pos) { }

	private bool MayDrag(PointerEventData eventData) { }

	public virtual void OnBeginDrag(PointerEventData eventData) { }

	public virtual void OnDrag(PointerEventData eventData) { }

	[IteratorStateMachineAttribute]
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

public enum InputField.ContentType // TypeDefIndex: 4953
{
	public int value__;
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

public enum InputField.InputType // TypeDefIndex: 4954
{
	public int value__;
	public const InputField.InputType Standard = 0;
	public const InputField.InputType AutoCorrect = 1;
	public const InputField.InputType Password = 2;

}

public enum InputField.CharacterValidation // TypeDefIndex: 4955
{
	public int value__;
	public const InputField.CharacterValidation None = 0;
	public const InputField.CharacterValidation Integer = 1;
	public const InputField.CharacterValidation Decimal = 2;
	public const InputField.CharacterValidation Alphanumeric = 3;
	public const InputField.CharacterValidation Name = 4;
	public const InputField.CharacterValidation EmailAddress = 5;

}

public enum InputField.LineType // TypeDefIndex: 4956
{
	public int value__;
	public const InputField.LineType SingleLine = 0;
	public const InputField.LineType MultiLineSubmit = 1;
	public const InputField.LineType MultiLineNewline = 2;

}

public sealed class InputField.OnValidateInput : MulticastDelegate // TypeDefIndex: 4957
{

	public void .ctor(object object, IntPtr method) { }

	public virtual char Invoke(string text, int charIndex, char addedChar) { }

	public virtual IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

	public virtual char EndInvoke(IAsyncResult result) { }

}

public class InputField.SubmitEvent : UnityEvent<string> // TypeDefIndex: 4958
{

	public void .ctor() { }

}

public class InputField.OnChangeEvent : UnityEvent<string> // TypeDefIndex: 4959
{

	public void .ctor() { }

}

private sealed class InputField.<CaretBlink>d__159 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 4961
{
	private int <>1__state;
	private object <>2__current;
	public InputField <>4__this;

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class InputField.<MouseDragOutsideRect>d__179 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 4962
{
	private int <>1__state;
	private object <>2__current;
	public InputField <>4__this;
	public PointerEventData eventData;

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

}


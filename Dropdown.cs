public class Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 4927
{
	[SerializeField]
	private RectTransform m_Template;
	[SerializeField]
	private Text m_CaptionText;
	[SerializeField]
	private Image m_CaptionImage;
	[SpaceAttribute]
	[SerializeField]
	private Text m_ItemText;
	[SerializeField]
	private Image m_ItemImage;
	[SpaceAttribute]
	[SerializeField]
	private int m_Value;
	[SpaceAttribute]
	[SerializeField]
	private Dropdown.OptionDataList m_Options;
	[SpaceAttribute]
	[SerializeField]
	private Dropdown.DropdownEvent m_OnValueChanged;
	[SerializeField]
	private float m_AlphaFadeSpeed;
	private GameObject m_Dropdown;
	private GameObject m_Blocker;
	private List<Dropdown.DropdownItem> m_Items;
	private TweenRunner<FloatTween> m_AlphaTweenRunner;
	private bool validTemplate;
	private static Dropdown.OptionData s_NoOptionData;

	public RectTransform template { get; set; }
	public Text captionText { get; set; }
	public Image captionImage { get; set; }
	public Text itemText { get; set; }
	public Image itemImage { get; set; }
	public List<Dropdown.OptionData> options { get; set; }
	public Dropdown.DropdownEvent onValueChanged { get; set; }
	public float alphaFadeSpeed { get; set; }
	public int value { get; set; }


	public RectTransform get_template() { }

	public void set_template(RectTransform value) { }

	public Text get_captionText() { }

	public void set_captionText(Text value) { }

	public Image get_captionImage() { }

	public void set_captionImage(Image value) { }

	public Text get_itemText() { }

	public void set_itemText(Text value) { }

	public Image get_itemImage() { }

	public void set_itemImage(Image value) { }

	public List<Dropdown.OptionData> get_options() { }

	public void set_options(List<Dropdown.OptionData> value) { }

	public Dropdown.DropdownEvent get_onValueChanged() { }

	public void set_onValueChanged(Dropdown.DropdownEvent value) { }

	public float get_alphaFadeSpeed() { }

	public void set_alphaFadeSpeed(float value) { }

	public int get_value() { }

	public void set_value(int value) { }

	public void SetValueWithoutNotify(int input) { }

	private void Set(int value, bool sendCallback = True) { }

	protected void .ctor() { }

	protected override void Awake() { }

	protected override void Start() { }

	protected override void OnDisable() { }

	public void RefreshShownValue() { }

	public void AddOptions(List<Dropdown.OptionData> options) { }

	public void AddOptions(List<string> options) { }

	public void AddOptions(List<Sprite> options) { }

	public void ClearOptions() { }

	private void SetupTemplate() { }

	private static T GetOrAddComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-Dropdown.GetOrAddComponent<object>
	|-Dropdown.GetOrAddComponent<Canvas>
	|-Dropdown.GetOrAddComponent<CanvasGroup>
	|-Dropdown.GetOrAddComponent<GraphicRaycaster>
	*/

	public virtual void OnPointerClick(PointerEventData eventData) { }

	public virtual void OnSubmit(BaseEventData eventData) { }

	public virtual void OnCancel(BaseEventData eventData) { }

	public void Show() { }

	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	protected virtual void DestroyBlocker(GameObject blocker) { }

	protected virtual GameObject CreateDropdownList(GameObject template) { }

	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	protected virtual Dropdown.DropdownItem CreateItem(Dropdown.DropdownItem itemTemplate) { }

	protected virtual void DestroyItem(Dropdown.DropdownItem item) { }

	private Dropdown.DropdownItem AddItem(Dropdown.OptionData data, bool selected, Dropdown.DropdownItem itemTemplate, List<Dropdown.DropdownItem> items) { }

	private void AlphaFadeList(float duration, float alpha) { }

	private void AlphaFadeList(float duration, float start, float end) { }

	private void SetAlpha(float alpha) { }

	public void Hide() { }

	[IteratorStateMachineAttribute]
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	private void ImmediateDestroyDropdownList() { }

	private void OnSelectItem(Toggle toggle) { }

	private static void .cctor() { }

}

public class Dropdown.OptionData // TypeDefIndex: 4929
{
	[SerializeField]
	private string m_Text;
	[SerializeField]
	private Sprite m_Image;

	public string text { get; set; }
	public Sprite image { get; set; }


	public string get_text() { }

	public void set_text(string value) { }

	public Sprite get_image() { }

	public void set_image(Sprite value) { }

	public void .ctor() { }

	public void .ctor(string text) { }

	public void .ctor(Sprite image) { }

	public void .ctor(string text, Sprite image) { }

}

public class Dropdown.OptionDataList // TypeDefIndex: 4930
{
	[SerializeField]
	private List<Dropdown.OptionData> m_Options;

	public List<Dropdown.OptionData> options { get; set; }


	public List<Dropdown.OptionData> get_options() { }

	public void set_options(List<Dropdown.OptionData> value) { }

	public void .ctor() { }

}

public class Dropdown.DropdownEvent : UnityEvent<int> // TypeDefIndex: 4931
{

	public void .ctor() { }

}

private sealed class Dropdown.<>c__DisplayClass62_0 // TypeDefIndex: 4932
{
	public Dropdown.DropdownItem item;
	public Dropdown <>4__this;


	public void .ctor() { }

	internal void <Show>

}

private sealed class Dropdown.<DelayedDestroyDropdownList>d__74 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 4933
{
	private int <>1__state;
	private object <>2__current;
	public float delay;
	public Dropdown <>4__this;

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

public class Dropdown : RustControl, IPointerDownHandler, IEventSystemHandler // TypeDefIndex: 7046
{
	public RustIcon Icon;
	public RustText Text;
	public RustIcon OptionIcon;
	public Option[] Options;
	private int CurrentOption;
	public Dropdown.ChangedEvent OnChanged;

	public Option Value { get; }


	public Option get_Value() { }

	protected override void Awake() { }

	public void SetOptions(Option[] options) { }

	protected void SetOptionFromUser(Option option) { }

	public void SetOption(int i) { }

	public void SetOption(Option option) { }

	public void SetOptionDefault() { }

	public void OnLeft() { }

	public void OnRight() { }

	protected override void ApplyStyle(StyleAsset.Group s) { }

	public void OnPointerDown(PointerEventData eventData) { }

	public void OpenMenu() { }

	public void .ctor() { }

}

public class Dropdown.ChangedEvent : UnityEvent<Option> // TypeDefIndex: 7047
{

	public void .ctor() { }

}


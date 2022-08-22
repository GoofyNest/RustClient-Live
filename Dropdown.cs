public class Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 4921
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RectTransform m_Template; // 0xE8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Text m_CaptionText; // 0xF0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Image m_CaptionImage; // 0xF8
	[SpaceAttribute] // RVA: 0x7CB60 Offset: 0x7BF60 VA: 0x18007CB60
	[SerializeField] // RVA: 0x7CB60 Offset: 0x7BF60 VA: 0x18007CB60
	private Text m_ItemText; // 0x100
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Image m_ItemImage; // 0x108
	[SpaceAttribute] // RVA: 0x7CB60 Offset: 0x7BF60 VA: 0x18007CB60
	[SerializeField] // RVA: 0x7CB60 Offset: 0x7BF60 VA: 0x18007CB60
	private int m_Value; // 0x110
	[SpaceAttribute] // RVA: 0x7CB60 Offset: 0x7BF60 VA: 0x18007CB60
	[SerializeField] // RVA: 0x7CB60 Offset: 0x7BF60 VA: 0x18007CB60
	private Dropdown.OptionDataList m_Options; // 0x118
	[SpaceAttribute] // RVA: 0x7CB60 Offset: 0x7BF60 VA: 0x18007CB60
	[SerializeField] // RVA: 0x7CB60 Offset: 0x7BF60 VA: 0x18007CB60
	private Dropdown.DropdownEvent m_OnValueChanged; // 0x120
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_AlphaFadeSpeed; // 0x128
	private GameObject m_Dropdown; // 0x130
	private GameObject m_Blocker; // 0x138
	private List<Dropdown.DropdownItem> m_Items; // 0x140
	private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x148
	private bool validTemplate; // 0x150
	private static Dropdown.OptionData s_NoOptionData; // 0x0

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
	|-RVA: 0x14A47D0 Offset: 0x14A3BD0 VA: 0x1814A47D0
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

	[IteratorStateMachineAttribute] // RVA: 0xE7770 Offset: 0xE6B70 VA: 0x1800E7770
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	private void ImmediateDestroyDropdownList() { }

	private void OnSelectItem(Toggle toggle) { }

	private static void .cctor() { }

}

public class Dropdown.OptionData // TypeDefIndex: 4923
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string m_Text; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Sprite m_Image; // 0x18

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

public class Dropdown.OptionDataList // TypeDefIndex: 4924
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private List<Dropdown.OptionData> m_Options; // 0x10

	public List<Dropdown.OptionData> options { get; set; }


	public List<Dropdown.OptionData> get_options() { }

	public void set_options(List<Dropdown.OptionData> value) { }

	public void .ctor() { }

}

public class Dropdown.DropdownEvent : UnityEvent<int> // TypeDefIndex: 4925
{
	public void .ctor() { }

}

private sealed class Dropdown.<>c__DisplayClass62_0 // TypeDefIndex: 4926
{	public Dropdown.DropdownItem item; // 0x10
	public Dropdown <>4__this; // 0x18


	public void .ctor() { }

	internal void <Show>b__0(bool x) { }

}

private sealed class Dropdown.<DelayedDestroyDropdownList>d__74 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 4927
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public float delay; // 0x20
	public Dropdown <>4__this; // 0x28

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

public class Dropdown : RustControl, IPointerDownHandler, IEventSystemHandler // TypeDefIndex: 7005
{	public RustIcon Icon; // 0x30
	public RustText Text; // 0x38
	public RustIcon OptionIcon; // 0x40
	public Option[] Options; // 0x48
	private int CurrentOption; // 0x50
	public Dropdown.ChangedEvent OnChanged; // 0x58

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

public class Dropdown.ChangedEvent : UnityEvent<Option> // TypeDefIndex: 7006
{
	public void .ctor() { }

}


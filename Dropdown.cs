public class Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 4921
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Properties
	public RectTransform template { get; set; }
	public Text captionText { get; set; }
	public Image captionImage { get; set; }
	public Text itemText { get; set; }
	public Image itemImage { get; set; }
	public List<Dropdown.OptionData> options { get; set; }
	public Dropdown.DropdownEvent onValueChanged { get; set; }
	public float alphaFadeSpeed { get; set; }
	public int value { get; set; }

	// Methods

	// RVA: 0x94E830 Offset: 0x94DC30 VA: 0x18094E830
	public RectTransform get_template() { }

	// RVA: 0x10BDA30 Offset: 0x10BCE30 VA: 0x1810BDA30
	public void set_template(RectTransform value) { }

	// RVA: 0xC53210 Offset: 0xC52610 VA: 0x180C53210
	public Text get_captionText() { }

	// RVA: 0x10BD960 Offset: 0x10BCD60 VA: 0x1810BD960
	public void set_captionText(Text value) { }

	// RVA: 0xB0A550 Offset: 0xB09950 VA: 0x180B0A550
	public Image get_captionImage() { }

	// RVA: 0x10BD930 Offset: 0x10BCD30 VA: 0x1810BD930
	public void set_captionImage(Image value) { }

	// RVA: 0xA09500 Offset: 0xA08900 VA: 0x180A09500
	public Text get_itemText() { }

	// RVA: 0x10BD9C0 Offset: 0x10BCDC0 VA: 0x1810BD9C0
	public void set_itemText(Text value) { }

	// RVA: 0xC62850 Offset: 0xC61C50 VA: 0x180C62850
	public Image get_itemImage() { }

	// RVA: 0x10BD990 Offset: 0x10BCD90 VA: 0x1810BD990
	public void set_itemImage(Image value) { }

	// RVA: 0x10BD900 Offset: 0x10BCD00 VA: 0x1810BD900
	public List<Dropdown.OptionData> get_options() { }

	// RVA: 0x10BD9F0 Offset: 0x10BCDF0 VA: 0x1810BD9F0
	public void set_options(List<Dropdown.OptionData> value) { }

	// RVA: 0x7F5E00 Offset: 0x7F5200 VA: 0x1807F5E00
	public Dropdown.DropdownEvent get_onValueChanged() { }

	// RVA: 0xC53320 Offset: 0xC52720 VA: 0x180C53320
	public void set_onValueChanged(Dropdown.DropdownEvent value) { }

	// RVA: 0xC62A10 Offset: 0xC61E10 VA: 0x180C62A10
	public float get_alphaFadeSpeed() { }

	// RVA: 0x10BD920 Offset: 0x10BCD20 VA: 0x1810BD920
	public void set_alphaFadeSpeed(float value) { }

	// RVA: 0xED4C60 Offset: 0xED4060 VA: 0x180ED4C60
	public int get_value() { }

	// RVA: 0x10BDA60 Offset: 0x10BCE60 VA: 0x1810BDA60
	public void set_value(int value) { }

	// RVA: 0x10BBFC0 Offset: 0x10BB3C0 VA: 0x1810BBFC0
	public void SetValueWithoutNotify(int input) { }

	// RVA: 0x10BBFD0 Offset: 0x10BB3D0 VA: 0x1810BBFD0
	private void Set(int value, bool sendCallback = True) { }

	// RVA: 0x10BD810 Offset: 0x10BCC10 VA: 0x1810BD810
	protected void .ctor() { }

	// RVA: 0x10BADA0 Offset: 0x10BA1A0 VA: 0x1810BADA0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x10BD7A0 Offset: 0x10BCBA0 VA: 0x1810BD7A0 Slot: 6
	protected override void Start() { }

	// RVA: 0x10BB990 Offset: 0x10BAD90 VA: 0x1810BB990 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x10BBD00 Offset: 0x10BB100 VA: 0x1810BBD00
	public void RefreshShownValue() { }

	// RVA: 0x10BAB60 Offset: 0x10B9F60 VA: 0x1810BAB60
	public void AddOptions(List<Dropdown.OptionData> options) { }

	// RVA: 0x10BA980 Offset: 0x10B9D80 VA: 0x1810BA980
	public void AddOptions(List<string> options) { }

	// RVA: 0x10BAA70 Offset: 0x10B9E70 VA: 0x1810BAA70
	public void AddOptions(List<Sprite> options) { }

	// RVA: 0x10BAF20 Offset: 0x10BA320 VA: 0x1810BAF20
	public void ClearOptions() { }

	// RVA: 0x10BC100 Offset: 0x10BB500 VA: 0x1810BC100
	private void SetupTemplate() { }

	// RVA: -1 Offset: -1
	private static T GetOrAddComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A47D0 Offset: 0x14A3BD0 VA: 0x1814A47D0
	|-Dropdown.GetOrAddComponent<object>
	|-Dropdown.GetOrAddComponent<Canvas>
	|-Dropdown.GetOrAddComponent<CanvasGroup>
	|-Dropdown.GetOrAddComponent<GraphicRaycaster>
	*/

	// RVA: 0x10BBBC0 Offset: 0x10BAFC0 VA: 0x1810BBBC0 Slot: 42
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x10BBBC0 Offset: 0x10BAFC0 VA: 0x1810BBBC0 Slot: 43
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x10BB980 Offset: 0x10BAD80 VA: 0x1810BB980 Slot: 44
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x10BC7E0 Offset: 0x10BBBE0 VA: 0x1810BC7E0
	public void Show() { }

	// RVA: 0x10BAF90 Offset: 0x10BA390 VA: 0x1810BAF90 Slot: 45
	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x10BB530 Offset: 0x10BA930 VA: 0x1810BB530 Slot: 46
	protected virtual void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x10BB3F0 Offset: 0x10BA7F0 VA: 0x1810BB3F0 Slot: 47
	protected virtual GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x10BB590 Offset: 0x10BA990 VA: 0x1810BB590 Slot: 48
	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x10BB450 Offset: 0x10BA850 VA: 0x1810BB450 Slot: 49
	protected virtual Dropdown.DropdownItem CreateItem(Dropdown.DropdownItem itemTemplate) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 50
	protected virtual void DestroyItem(Dropdown.DropdownItem item) { }

	// RVA: 0x10BA6D0 Offset: 0x10B9AD0 VA: 0x1810BA6D0
	private Dropdown.DropdownItem AddItem(Dropdown.OptionData data, bool selected, Dropdown.DropdownItem itemTemplate, List<Dropdown.DropdownItem> items) { }

	// RVA: 0x10BABD0 Offset: 0x10B9FD0 VA: 0x1810BABD0
	private void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x10BAC60 Offset: 0x10BA060 VA: 0x1810BAC60
	private void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x10BBF10 Offset: 0x10BB310 VA: 0x1810BBF10
	private void SetAlpha(float alpha) { }

	// RVA: 0x10BB5F0 Offset: 0x10BA9F0 VA: 0x1810BB5F0
	public void Hide() { }

	[IteratorStateMachineAttribute] // RVA: 0xE7770 Offset: 0xE6B70 VA: 0x1800E7770
	// RVA: 0x10BB4B0 Offset: 0x10BA8B0 VA: 0x1810BB4B0
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x10BB7E0 Offset: 0x10BABE0 VA: 0x1810BB7E0
	private void ImmediateDestroyDropdownList() { }

	// RVA: 0x10BBBD0 Offset: 0x10BAFD0 VA: 0x1810BBBD0
	private void OnSelectItem(Toggle toggle) { }

	// RVA: 0x10BD7B0 Offset: 0x10BCBB0 VA: 0x1810BD7B0
	private static void .cctor() { }

}

public class Dropdown.OptionData // TypeDefIndex: 4923
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string m_Text; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Sprite m_Image; // 0x18

	// Properties
	public string text { get; set; }
	public Sprite image { get; set; }

	// Methods

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_text() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_text(string value) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public Sprite get_image() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_image(Sprite value) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	public void .ctor(string text) { }

	// RVA: 0x10B06F0 Offset: 0x10AFAF0 VA: 0x1810B06F0
	public void .ctor(Sprite image) { }

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	public void .ctor(string text, Sprite image) { }

}

public class Dropdown.OptionDataList // TypeDefIndex: 4924
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private List<Dropdown.OptionData> m_Options; // 0x10

	// Properties
	public List<Dropdown.OptionData> options { get; set; }

	// Methods

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public List<Dropdown.OptionData> get_options() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_options(List<Dropdown.OptionData> value) { }

	// RVA: 0x15FF910 Offset: 0x15FED10 VA: 0x1815FF910
	public void .ctor() { }

}

public class Dropdown.DropdownEvent : UnityEvent<int> // TypeDefIndex: 4925
{	// Methods

	// RVA: 0x15E53A0 Offset: 0x15E47A0 VA: 0x1815E53A0
	public void .ctor() { }

}

private sealed class Dropdown.<>c__DisplayClass62_0 // TypeDefIndex: 4926
{	// Fields
	public Dropdown.DropdownItem item; // 0x10
	public Dropdown <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x15FFAD0 Offset: 0x15FEED0 VA: 0x1815FFAD0
	internal void <Show>b__0(bool x) { }

}

private sealed class Dropdown.<DelayedDestroyDropdownList>d__74 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 4927
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public float delay; // 0x20
	public Dropdown <>4__this; // 0x28

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

	// RVA: 0x15FF980 Offset: 0x15FED80 VA: 0x1815FF980 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x15FFA30 Offset: 0x15FEE30 VA: 0x1815FFA30 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class Dropdown : RustControl, IPointerDownHandler, IEventSystemHandler // TypeDefIndex: 7005
{	// Fields
	public RustIcon Icon; // 0x30
	public RustText Text; // 0x38
	public RustIcon OptionIcon; // 0x40
	public Option[] Options; // 0x48
	private int CurrentOption; // 0x50
	public Dropdown.ChangedEvent OnChanged; // 0x58

	// Properties
	public Option Value { get; }

	// Methods

	// RVA: 0xFB9CB0 Offset: 0xFB90B0 VA: 0x180FB9CB0
	public Option get_Value() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFB9BD0 Offset: 0xFB8FD0 VA: 0x180FB9BD0
	public void SetOptions(Option[] options) { }

	// RVA: 0xFB9950 Offset: 0xFB8D50 VA: 0x180FB9950
	protected void SetOptionFromUser(Option option) { }

	// RVA: 0xFB9A50 Offset: 0xFB8E50 VA: 0x180FB9A50
	public void SetOption(int i) { }

	// RVA: 0xFB9B20 Offset: 0xFB8F20 VA: 0x180FB9B20
	public void SetOption(Option option) { }

	// RVA: 0xFB98F0 Offset: 0xFB8CF0 VA: 0x180FB98F0
	public void SetOptionDefault() { }

	// RVA: 0xFB94C0 Offset: 0xFB88C0 VA: 0x180FB94C0
	public void OnLeft() { }

	// RVA: 0xFB9570 Offset: 0xFB8970 VA: 0x180FB9570
	public void OnRight() { }

	// RVA: 0xFB92E0 Offset: 0xFB86E0 VA: 0x180FB92E0 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFB9560 Offset: 0xFB8960 VA: 0x180FB9560 Slot: 31
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xFB9610 Offset: 0xFB8A10 VA: 0x180FB9610
	public void OpenMenu() { }

	// RVA: 0xFB9C50 Offset: 0xFB9050 VA: 0x180FB9C50
	public void .ctor() { }

}

public class Dropdown.ChangedEvent : UnityEvent<Option> // TypeDefIndex: 7006
{	// Methods

	// RVA: 0xFB8DB0 Offset: 0xFB81B0 VA: 0x180FB8DB0
	public void .ctor() { }

}


public class Toggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement // TypeDefIndex: 5015
{	// Fields
	public Toggle.ToggleTransition toggleTransition; // 0xE8
	public Graphic graphic; // 0xF0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ToggleGroup m_Group; // 0xF8
	public Toggle.ToggleEvent onValueChanged; // 0x100
	[TooltipAttribute] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	[SerializeField] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	private bool m_IsOn; // 0x108

	// Properties
	public ToggleGroup group { get; set; }
	public bool isOn { get; set; }

	// Methods

	// RVA: 0xB0A550 Offset: 0xB09950 VA: 0x180B0A550
	public ToggleGroup get_group() { }

	// RVA: 0x2242D10 Offset: 0x2242110 VA: 0x182242D10
	public void set_group(ToggleGroup value) { }

	// RVA: 0x2242C60 Offset: 0x2242060 VA: 0x182242C60
	protected void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 46
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 47
	public virtual void LayoutComplete() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 48
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x2242560 Offset: 0x2241960 VA: 0x182242560 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x2242730 Offset: 0x2241B30 VA: 0x182242730 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2242700 Offset: 0x2241B00 VA: 0x182242700 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x22425F0 Offset: 0x22419F0 VA: 0x1822425F0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x22428C0 Offset: 0x2241CC0 VA: 0x1822428C0
	private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue) { }

	// RVA: 0xA09570 Offset: 0xA08970 VA: 0x180A09570
	public bool get_isOn() { }

	// RVA: 0x2242D60 Offset: 0x2242160 VA: 0x182242D60
	public void set_isOn(bool value) { }

	// RVA: 0x22428B0 Offset: 0x2241CB0 VA: 0x1822428B0
	public void SetIsOnWithoutNotify(bool value) { }

	// RVA: 0x2242AF0 Offset: 0x2241EF0 VA: 0x182242AF0
	private void Set(bool value, bool sendCallback = True) { }

	// RVA: 0x22427E0 Offset: 0x2241BE0 VA: 0x1822427E0
	private void PlayEffect(bool instant) { }

	// RVA: 0x2242C50 Offset: 0x2242050 VA: 0x182242C50 Slot: 6
	protected override void Start() { }

	// RVA: 0x2242500 Offset: 0x2241900 VA: 0x182242500
	private void InternalToggle() { }

	// RVA: 0x2242770 Offset: 0x2241B70 VA: 0x182242770 Slot: 49
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x2242500 Offset: 0x2241900 VA: 0x182242500 Slot: 50
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0xAB8650 Offset: 0xAB7A50 VA: 0x180AB8650 Slot: 42
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

public enum Toggle.ToggleTransition // TypeDefIndex: 5016
{	// Fields
	public int value__; // 0x0
	public const Toggle.ToggleTransition None = 0;
	public const Toggle.ToggleTransition Fade = 1;

}

public class Toggle.ToggleEvent : UnityEvent<bool> // TypeDefIndex: 5017
{	// Methods

	// RVA: 0x2241BD0 Offset: 0x2240FD0 VA: 0x182241BD0
	public void .ctor() { }

}


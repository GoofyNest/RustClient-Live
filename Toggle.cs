public class Toggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement // TypeDefIndex: 5015
{	public Toggle.ToggleTransition toggleTransition; // 0xE8
	public Graphic graphic; // 0xF0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ToggleGroup m_Group; // 0xF8
	public Toggle.ToggleEvent onValueChanged; // 0x100
	[TooltipAttribute] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	[SerializeField] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	private bool m_IsOn; // 0x108

	public ToggleGroup group { get; set; }
	public bool isOn { get; set; }


	public ToggleGroup get_group() { }

	public void set_group(ToggleGroup value) { }

	protected void .ctor() { }

	public virtual void Rebuild(CanvasUpdate executing) { }

	public virtual void LayoutComplete() { }

	public virtual void GraphicUpdateComplete() { }

	protected override void OnDestroy() { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	protected override void OnDidApplyAnimationProperties() { }

	private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue) { }

	public bool get_isOn() { }

	public void set_isOn(bool value) { }

	public void SetIsOnWithoutNotify(bool value) { }

	private void Set(bool value, bool sendCallback = True) { }

	private void PlayEffect(bool instant) { }

	protected override void Start() { }

	private void InternalToggle() { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	public virtual void OnSubmit(BaseEventData eventData) { }

	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

public enum Toggle.ToggleTransition // TypeDefIndex: 5016
{	public int value__; // 0x0
	public const Toggle.ToggleTransition None = 0;
	public const Toggle.ToggleTransition Fade = 1;

}

public class Toggle.ToggleEvent : UnityEvent<bool> // TypeDefIndex: 5017
{
	public void .ctor() { }

}


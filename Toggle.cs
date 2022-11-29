public class Toggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement // TypeDefIndex: 5021
{
	public Toggle.ToggleTransition toggleTransition; 
	public Graphic graphic; 
	[SerializeField] 
	private ToggleGroup m_Group; 
	public Toggle.ToggleEvent onValueChanged; 
	[TooltipAttribute] 
	[SerializeField] 
	private bool m_IsOn; 

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

public enum Toggle.ToggleTransition // TypeDefIndex: 5022
{
	public int value__; 
	public const Toggle.ToggleTransition None = 0;
	public const Toggle.ToggleTransition Fade = 1;

}

public class Toggle.ToggleEvent : UnityEvent<bool> // TypeDefIndex: 5023
{

	public void .ctor() { }

}


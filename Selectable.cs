public class Selectable : UIBehaviour, IMoveHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 5003
{	// Fields
	private static Selectable[] s_Selectables; // 0x0
	private static int s_SelectableCount; // 0x8
	private static bool s_IsDirty; // 0xC
	[FormerlySerializedAsAttribute] // RVA: 0x7B000 Offset: 0x7A400 VA: 0x18007B000
	[SerializeField] // RVA: 0x7B000 Offset: 0x7A400 VA: 0x18007B000
	private Navigation m_Navigation; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x7B280 Offset: 0x7A680 VA: 0x18007B280
	[SerializeField] // RVA: 0x7B280 Offset: 0x7A680 VA: 0x18007B280
	private Selectable.Transition m_Transition; // 0x40
	[FormerlySerializedAsAttribute] // RVA: 0x7B3C0 Offset: 0x7A7C0 VA: 0x18007B3C0
	[SerializeField] // RVA: 0x7B3C0 Offset: 0x7A7C0 VA: 0x18007B3C0
	private ColorBlock m_Colors; // 0x44
	[FormerlySerializedAsAttribute] // RVA: 0x7B5A0 Offset: 0x7A9A0 VA: 0x18007B5A0
	[SerializeField] // RVA: 0x7B5A0 Offset: 0x7A9A0 VA: 0x18007B5A0
	private SpriteState m_SpriteState; // 0xA0
	[FormerlySerializedAsAttribute] // RVA: 0x7B720 Offset: 0x7AB20 VA: 0x18007B720
	[SerializeField] // RVA: 0x7B720 Offset: 0x7AB20 VA: 0x18007B720
	private AnimationTriggers m_AnimationTriggers; // 0xC0
	[TooltipAttribute] // RVA: 0x7B8F0 Offset: 0x7ACF0 VA: 0x18007B8F0
	[SerializeField] // RVA: 0x7B8F0 Offset: 0x7ACF0 VA: 0x18007B8F0
	private bool m_Interactable; // 0xC8
	[FormerlySerializedAsAttribute] // RVA: 0x7B970 Offset: 0x7AD70 VA: 0x18007B970
	[FormerlySerializedAsAttribute] // RVA: 0x7B970 Offset: 0x7AD70 VA: 0x18007B970
	[SerializeField] // RVA: 0x7B970 Offset: 0x7AD70 VA: 0x18007B970
	private Graphic m_TargetGraphic; // 0xD0
	private bool m_GroupsAllowInteraction; // 0xD8
	private bool m_WillRemove; // 0xD9
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <isPointerInside>k__BackingField; // 0xDA
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <isPointerDown>k__BackingField; // 0xDB
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <hasSelection>k__BackingField; // 0xDC
	private readonly List<CanvasGroup> m_CanvasGroupCache; // 0xE0

	// Properties
	public static Selectable[] allSelectablesArray { get; }
	public static int allSelectableCount { get; }
	[ObsoleteAttribute] // RVA: 0x7C490 Offset: 0x7B890 VA: 0x18007C490
	public static List<Selectable> allSelectables { get; }
	public Navigation navigation { get; set; }
	public Selectable.Transition transition { get; set; }
	public ColorBlock colors { get; set; }
	public SpriteState spriteState { get; set; }
	public AnimationTriggers animationTriggers { get; set; }
	public Graphic targetGraphic { get; set; }
	public bool interactable { get; set; }
	private bool isPointerInside { get; set; }
	private bool isPointerDown { get; set; }
	private bool hasSelection { get; set; }
	public Image image { get; set; }
	public Animator animator { get; }
	protected Selectable.SelectionState currentSelectionState { get; }

	// Methods

	// RVA: 0x171ED20 Offset: 0x171E120 VA: 0x18171ED20
	public static Selectable[] get_allSelectablesArray() { }

	// RVA: 0x171ECC0 Offset: 0x171E0C0 VA: 0x18171ECC0
	public static int get_allSelectableCount() { }

	// RVA: 0x171EE00 Offset: 0x171E200 VA: 0x18171EE00
	public static List<Selectable> get_allSelectables() { }

	// RVA: 0x171C5C0 Offset: 0x171B9C0 VA: 0x18171C5C0
	public static int AllSelectablesNoAlloc(Selectable[] selectables) { }

	// RVA: 0x171F0E0 Offset: 0x171E4E0 VA: 0x18171F0E0
	public Navigation get_navigation() { }

	// RVA: 0x171F3D0 Offset: 0x171E7D0 VA: 0x18171F3D0
	public void set_navigation(Navigation value) { }

	// RVA: 0x5F7C80 Offset: 0x5F7080 VA: 0x1805F7C80
	public Selectable.Transition get_transition() { }

	// RVA: 0x171F520 Offset: 0x171E920 VA: 0x18171F520
	public void set_transition(Selectable.Transition value) { }

	// RVA: 0x171EF90 Offset: 0x171E390 VA: 0x18171EF90
	public ColorBlock get_colors() { }

	// RVA: 0x171F180 Offset: 0x171E580 VA: 0x18171F180
	public void set_colors(ColorBlock value) { }

	// RVA: 0x171F100 Offset: 0x171E500 VA: 0x18171F100
	public SpriteState get_spriteState() { }

	// RVA: 0x171F450 Offset: 0x171E850 VA: 0x18171F450
	public void set_spriteState(SpriteState value) { }

	// RVA: 0x104A060 Offset: 0x1049460 VA: 0x18104A060
	public AnimationTriggers get_animationTriggers() { }

	// RVA: 0x171F120 Offset: 0x171E520 VA: 0x18171F120
	public void set_animationTriggers(AnimationTriggers value) { }

	// RVA: 0xC53130 Offset: 0xC52530 VA: 0x180C53130
	public Graphic get_targetGraphic() { }

	// RVA: 0x171F4C0 Offset: 0x171E8C0 VA: 0x18171F4C0
	public void set_targetGraphic(Graphic value) { }

	// RVA: 0x13EC3A0 Offset: 0x13EB7A0 VA: 0x1813EC3A0
	public bool get_interactable() { }

	// RVA: 0x171F230 Offset: 0x171E630 VA: 0x18171F230
	public void set_interactable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x171F0D0 Offset: 0x171E4D0 VA: 0x18171F0D0
	private bool get_isPointerInside() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x171F3C0 Offset: 0x171E7C0 VA: 0x18171F3C0
	private void set_isPointerInside(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x171F0C0 Offset: 0x171E4C0 VA: 0x18171F0C0
	private bool get_isPointerDown() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x171F3B0 Offset: 0x171E7B0 VA: 0x18171F3B0
	private void set_isPointerDown(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x15F47E0 Offset: 0x15F3BE0 VA: 0x1815F47E0
	private bool get_hasSelection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x171F220 Offset: 0x171E620 VA: 0x18171F220
	private void set_hasSelection(bool value) { }

	// RVA: 0x171EB80 Offset: 0x171DF80 VA: 0x18171EB80
	protected void .ctor() { }

	// RVA: 0x171F040 Offset: 0x171E440 VA: 0x18171F040
	public Image get_image() { }

	// RVA: 0xC53280 Offset: 0xC52680 VA: 0x180C53280
	public void set_image(Image value) { }

	// RVA: 0x171EF50 Offset: 0x171E350 VA: 0x18171EF50
	public Animator get_animator() { }

	// RVA: 0x171C6F0 Offset: 0x171BAF0 VA: 0x18171C6F0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x171DA60 Offset: 0x171CE60 VA: 0x18171DA60 Slot: 14
	protected override void OnCanvasGroupChanged() { }

	// RVA: 0x171D940 Offset: 0x171CD40 VA: 0x18171D940 Slot: 24
	public virtual bool IsInteractable() { }

	// RVA: 0x171DC50 Offset: 0x171D050 VA: 0x18171DC50 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x171DD40 Offset: 0x171D140 VA: 0x18171DD40 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x171E430 Offset: 0x171D830 VA: 0x18171E430 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x171DC50 Offset: 0x171D050 VA: 0x18171DC50
	private void OnSetProperty() { }

	// RVA: 0x171DCC0 Offset: 0x171D0C0 VA: 0x18171DCC0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x171E460 Offset: 0x171D860 VA: 0x18171E460
	private static void RemoveInvalidSelectables() { }

	// RVA: 0x171EFD0 Offset: 0x171E3D0 VA: 0x18171EFD0
	protected Selectable.SelectionState get_currentSelectionState() { }

	// RVA: 0x171D7B0 Offset: 0x171CBB0 VA: 0x18171D7B0 Slot: 25
	protected virtual void InstantClearState() { }

	// RVA: 0x171C830 Offset: 0x171BC30 VA: 0x18171C830 Slot: 26
	protected virtual void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x171CF80 Offset: 0x171C380 VA: 0x18171CF80
	public Selectable FindSelectable(Vector3 dir) { }

	// RVA: 0x171D500 Offset: 0x171C900 VA: 0x18171D500
	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	// RVA: 0x171D9B0 Offset: 0x171CDB0 VA: 0x18171D9B0
	private void Navigate(AxisEventData eventData, Selectable sel) { }

	// RVA: 0x171CBC0 Offset: 0x171BFC0 VA: 0x18171CBC0 Slot: 27
	public virtual Selectable FindSelectableOnLeft() { }

	// RVA: 0x171CD00 Offset: 0x171C100 VA: 0x18171CD00 Slot: 28
	public virtual Selectable FindSelectableOnRight() { }

	// RVA: 0x171CE40 Offset: 0x171C240 VA: 0x18171CE40 Slot: 29
	public virtual Selectable FindSelectableOnUp() { }

	// RVA: 0x171CA80 Offset: 0x171BE80 VA: 0x18171CA80 Slot: 30
	public virtual Selectable FindSelectableOnDown() { }

	// RVA: 0x171DFB0 Offset: 0x171D3B0 VA: 0x18171DFB0 Slot: 31
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x171E7C0 Offset: 0x171DBC0 VA: 0x18171E7C0
	private void StartColorTween(Color targetColor, bool instant) { }

	// RVA: 0x171C790 Offset: 0x171BB90 VA: 0x18171C790
	private void DoSpriteSwap(Sprite newSprite) { }

	// RVA: 0x171E8A0 Offset: 0x171DCA0 VA: 0x18171E8A0
	private void TriggerAnimation(string triggername) { }

	// RVA: 0x171D8E0 Offset: 0x171CCE0 VA: 0x18171D8E0
	protected bool IsHighlighted() { }

	// RVA: 0x171D960 Offset: 0x171CD60 VA: 0x18171D960
	protected bool IsPressed() { }

	// RVA: 0x171CA10 Offset: 0x171BE10 VA: 0x18171CA10
	private void EvaluateAndTransitionToSelectionState() { }

	// RVA: 0x171E0E0 Offset: 0x171D4E0 VA: 0x18171E0E0 Slot: 32
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x171E340 Offset: 0x171D740 VA: 0x18171E340 Slot: 33
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x171E260 Offset: 0x171D660 VA: 0x18171E260 Slot: 34
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x171E2D0 Offset: 0x171D6D0 VA: 0x18171E2D0 Slot: 35
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x171E3C0 Offset: 0x171D7C0 VA: 0x18171E3C0 Slot: 36
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x171DBE0 Offset: 0x171CFE0 VA: 0x18171DBE0 Slot: 37
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x171E6B0 Offset: 0x171DAB0 VA: 0x18171E6B0 Slot: 38
	public virtual void Select() { }

	// RVA: 0x171EB00 Offset: 0x171DF00 VA: 0x18171EB00
	private static void .cctor() { }

}

public enum Selectable.Transition // TypeDefIndex: 5004
{	// Fields
	public int value__; // 0x0
	public const Selectable.Transition None = 0;
	public const Selectable.Transition ColorTint = 1;
	public const Selectable.Transition SpriteSwap = 2;
	public const Selectable.Transition Animation = 3;

}


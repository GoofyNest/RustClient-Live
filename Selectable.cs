public class Selectable : UIBehaviour, IMoveHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 5004
{
	private static Selectable[] s_Selectables; 
	private static int s_SelectableCount; 
	private static bool s_IsDirty; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private Navigation m_Navigation; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private Selectable.Transition m_Transition; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private ColorBlock m_Colors; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private SpriteState m_SpriteState; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private AnimationTriggers m_AnimationTriggers; 
	[TooltipAttribute] 
	[SerializeField] 
	private bool m_Interactable; 
	[FormerlySerializedAsAttribute] 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private Graphic m_TargetGraphic; 
	private bool m_GroupsAllowInteraction; 
	private bool m_WillRemove; 
	[CompilerGeneratedAttribute] 
	private bool <isPointerInside>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <isPointerDown>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <hasSelection>k__BackingField; 
	private readonly List<CanvasGroup> m_CanvasGroupCache; 

	public static Selectable[] allSelectablesArray { get; }
	public static int allSelectableCount { get; }
	[ObsoleteAttribute] 
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


	public static Selectable[] get_allSelectablesArray() { }

	public static int get_allSelectableCount() { }

	public static List<Selectable> get_allSelectables() { }

	public static int AllSelectablesNoAlloc(Selectable[] selectables) { }

	public Navigation get_navigation() { }

	public void set_navigation(Navigation value) { }

	public Selectable.Transition get_transition() { }

	public void set_transition(Selectable.Transition value) { }

	public ColorBlock get_colors() { }

	public void set_colors(ColorBlock value) { }

	public SpriteState get_spriteState() { }

	public void set_spriteState(SpriteState value) { }

	public AnimationTriggers get_animationTriggers() { }

	public void set_animationTriggers(AnimationTriggers value) { }

	public Graphic get_targetGraphic() { }

	public void set_targetGraphic(Graphic value) { }

	public bool get_interactable() { }

	public void set_interactable(bool value) { }

	[CompilerGeneratedAttribute] 
	private bool get_isPointerInside() { }

	[CompilerGeneratedAttribute] 
	private void set_isPointerInside(bool value) { }

	[CompilerGeneratedAttribute] 
	private bool get_isPointerDown() { }

	[CompilerGeneratedAttribute] 
	private void set_isPointerDown(bool value) { }

	[CompilerGeneratedAttribute] 
	private bool get_hasSelection() { }

	[CompilerGeneratedAttribute] 
	private void set_hasSelection(bool value) { }

	protected void .ctor() { }

	public Image get_image() { }

	public void set_image(Image value) { }

	public Animator get_animator() { }

	protected override void Awake() { }

	protected override void OnCanvasGroupChanged() { }

	public virtual bool IsInteractable() { }

	protected override void OnDidApplyAnimationProperties() { }

	protected override void OnEnable() { }

	protected override void OnTransformParentChanged() { }

	private void OnSetProperty() { }

	protected override void OnDisable() { }

	private static void RemoveInvalidSelectables() { }

	protected Selectable.SelectionState get_currentSelectionState() { }

	protected virtual void InstantClearState() { }

	protected virtual void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	public Selectable FindSelectable(Vector3 dir) { }

	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	private void Navigate(AxisEventData eventData, Selectable sel) { }

	public virtual Selectable FindSelectableOnLeft() { }

	public virtual Selectable FindSelectableOnRight() { }

	public virtual Selectable FindSelectableOnUp() { }

	public virtual Selectable FindSelectableOnDown() { }

	public virtual void OnMove(AxisEventData eventData) { }

	private void StartColorTween(Color targetColor, bool instant) { }

	private void DoSpriteSwap(Sprite newSprite) { }

	private void TriggerAnimation(string triggername) { }

	protected bool IsHighlighted() { }

	protected bool IsPressed() { }

	private void EvaluateAndTransitionToSelectionState() { }

	public virtual void OnPointerDown(PointerEventData eventData) { }

	public virtual void OnPointerUp(PointerEventData eventData) { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	public virtual void OnPointerExit(PointerEventData eventData) { }

	public virtual void OnSelect(BaseEventData eventData) { }

	public virtual void OnDeselect(BaseEventData eventData) { }

	public virtual void Select() { }

	private static void .cctor() { }

}

public enum Selectable.Transition // TypeDefIndex: 5005
{
	public int value__; 
	public const Selectable.Transition None = 0;
	public const Selectable.Transition ColorTint = 1;
	public const Selectable.Transition SpriteSwap = 2;
	public const Selectable.Transition Animation = 3;

}


public static class ExecuteEvents // TypeDefIndex: 5076
{	// Fields
	private static readonly ExecuteEvents.EventFunction<IPointerEnterHandler> s_PointerEnterHandler; // 0x0
	private static readonly ExecuteEvents.EventFunction<IPointerExitHandler> s_PointerExitHandler; // 0x8
	private static readonly ExecuteEvents.EventFunction<IPointerDownHandler> s_PointerDownHandler; // 0x10
	private static readonly ExecuteEvents.EventFunction<IPointerUpHandler> s_PointerUpHandler; // 0x18
	private static readonly ExecuteEvents.EventFunction<IPointerClickHandler> s_PointerClickHandler; // 0x20
	private static readonly ExecuteEvents.EventFunction<IInitializePotentialDragHandler> s_InitializePotentialDragHandler; // 0x28
	private static readonly ExecuteEvents.EventFunction<IBeginDragHandler> s_BeginDragHandler; // 0x30
	private static readonly ExecuteEvents.EventFunction<IDragHandler> s_DragHandler; // 0x38
	private static readonly ExecuteEvents.EventFunction<IEndDragHandler> s_EndDragHandler; // 0x40
	private static readonly ExecuteEvents.EventFunction<IDropHandler> s_DropHandler; // 0x48
	private static readonly ExecuteEvents.EventFunction<IScrollHandler> s_ScrollHandler; // 0x50
	private static readonly ExecuteEvents.EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler; // 0x58
	private static readonly ExecuteEvents.EventFunction<ISelectHandler> s_SelectHandler; // 0x60
	private static readonly ExecuteEvents.EventFunction<IDeselectHandler> s_DeselectHandler; // 0x68
	private static readonly ExecuteEvents.EventFunction<IMoveHandler> s_MoveHandler; // 0x70
	private static readonly ExecuteEvents.EventFunction<ISubmitHandler> s_SubmitHandler; // 0x78
	private static readonly ExecuteEvents.EventFunction<ICancelHandler> s_CancelHandler; // 0x80
	private static readonly ObjectPool<List<IEventSystemHandler>> s_HandlerListPool; // 0x88
	private static readonly List<Transform> s_InternalTransformList; // 0x90

	// Properties
	public static ExecuteEvents.EventFunction<IPointerEnterHandler> pointerEnterHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerExitHandler> pointerExitHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerDownHandler> pointerDownHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerUpHandler> pointerUpHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerClickHandler> pointerClickHandler { get; }
	public static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> initializePotentialDrag { get; }
	public static ExecuteEvents.EventFunction<IBeginDragHandler> beginDragHandler { get; }
	public static ExecuteEvents.EventFunction<IDragHandler> dragHandler { get; }
	public static ExecuteEvents.EventFunction<IEndDragHandler> endDragHandler { get; }
	public static ExecuteEvents.EventFunction<IDropHandler> dropHandler { get; }
	public static ExecuteEvents.EventFunction<IScrollHandler> scrollHandler { get; }
	public static ExecuteEvents.EventFunction<IUpdateSelectedHandler> updateSelectedHandler { get; }
	public static ExecuteEvents.EventFunction<ISelectHandler> selectHandler { get; }
	public static ExecuteEvents.EventFunction<IDeselectHandler> deselectHandler { get; }
	public static ExecuteEvents.EventFunction<IMoveHandler> moveHandler { get; }
	public static ExecuteEvents.EventFunction<ISubmitHandler> submitHandler { get; }
	public static ExecuteEvents.EventFunction<ICancelHandler> cancelHandler { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T ValidateEventData<T>(BaseEventData data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A9380 Offset: 0x14A8780 VA: 0x1814A9380
	|-ExecuteEvents.ValidateEventData<object>
	|-ExecuteEvents.ValidateEventData<AxisEventData>
	|-ExecuteEvents.ValidateEventData<PointerEventData>
	*/

	// RVA: 0x10BF9E0 Offset: 0x10BEDE0 VA: 0x1810BF9E0
	private static void Execute(IPointerEnterHandler handler, BaseEventData eventData) { }

	// RVA: 0x10BFAD0 Offset: 0x10BEED0 VA: 0x1810BFAD0
	private static void Execute(IPointerExitHandler handler, BaseEventData eventData) { }

	// RVA: 0x10BFD30 Offset: 0x10BF130 VA: 0x1810BFD30
	private static void Execute(IPointerDownHandler handler, BaseEventData eventData) { }

	// RVA: 0x10BFDC0 Offset: 0x10BF1C0 VA: 0x1810BFDC0
	private static void Execute(IPointerUpHandler handler, BaseEventData eventData) { }

	// RVA: 0x10BF6B0 Offset: 0x10BEAB0 VA: 0x1810BF6B0
	private static void Execute(IPointerClickHandler handler, BaseEventData eventData) { }

	// RVA: 0x10BF950 Offset: 0x10BED50 VA: 0x1810BF950
	private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x10BF740 Offset: 0x10BEB40 VA: 0x1810BF740
	private static void Execute(IBeginDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x10BF830 Offset: 0x10BEC30 VA: 0x1810BF830
	private static void Execute(IDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x10BFC40 Offset: 0x10BF040 VA: 0x1810BFC40
	private static void Execute(IEndDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x10BF8C0 Offset: 0x10BECC0 VA: 0x1810BF8C0
	private static void Execute(IDropHandler handler, BaseEventData eventData) { }

	// RVA: 0x10BFE50 Offset: 0x10BF250 VA: 0x1810BFE50
	private static void Execute(IScrollHandler handler, BaseEventData eventData) { }

	// RVA: 0x10BFA70 Offset: 0x10BEE70 VA: 0x1810BFA70
	private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData) { }

	// RVA: 0x10BFCD0 Offset: 0x10BF0D0 VA: 0x1810BFCD0
	private static void Execute(ISelectHandler handler, BaseEventData eventData) { }

	// RVA: 0x10BF7D0 Offset: 0x10BEBD0 VA: 0x1810BF7D0
	private static void Execute(IDeselectHandler handler, BaseEventData eventData) { }

	// RVA: 0x10BFB60 Offset: 0x10BEF60 VA: 0x1810BFB60
	private static void Execute(IMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x10BF650 Offset: 0x10BEA50 VA: 0x1810BF650
	private static void Execute(ISubmitHandler handler, BaseEventData eventData) { }

	// RVA: 0x10BFEE0 Offset: 0x10BF2E0 VA: 0x1810BFEE0
	private static void Execute(ICancelHandler handler, BaseEventData eventData) { }

	// RVA: 0x10C0B90 Offset: 0x10BFF90 VA: 0x1810C0B90
	public static ExecuteEvents.EventFunction<IPointerEnterHandler> get_pointerEnterHandler() { }

	// RVA: 0x10C0C50 Offset: 0x10C0050 VA: 0x1810C0C50
	public static ExecuteEvents.EventFunction<IPointerExitHandler> get_pointerExitHandler() { }

	// RVA: 0x10C0B30 Offset: 0x10BFF30 VA: 0x1810C0B30
	public static ExecuteEvents.EventFunction<IPointerDownHandler> get_pointerDownHandler() { }

	// RVA: 0x10C0D10 Offset: 0x10C0110 VA: 0x1810C0D10
	public static ExecuteEvents.EventFunction<IPointerUpHandler> get_pointerUpHandler() { }

	// RVA: 0x10C0A70 Offset: 0x10BFE70 VA: 0x1810C0A70
	public static ExecuteEvents.EventFunction<IPointerClickHandler> get_pointerClickHandler() { }

	// RVA: 0x10C0950 Offset: 0x10BFD50 VA: 0x1810C0950
	public static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> get_initializePotentialDrag() { }

	// RVA: 0x10C0650 Offset: 0x10BFA50 VA: 0x1810C0650
	public static ExecuteEvents.EventFunction<IBeginDragHandler> get_beginDragHandler() { }

	// RVA: 0x10C0770 Offset: 0x10BFB70 VA: 0x1810C0770
	public static ExecuteEvents.EventFunction<IDragHandler> get_dragHandler() { }

	// RVA: 0x10C0890 Offset: 0x10BFC90 VA: 0x1810C0890
	public static ExecuteEvents.EventFunction<IEndDragHandler> get_endDragHandler() { }

	// RVA: 0x10C07D0 Offset: 0x10BFBD0 VA: 0x1810C07D0
	public static ExecuteEvents.EventFunction<IDropHandler> get_dropHandler() { }

	// RVA: 0x10C0DD0 Offset: 0x10C01D0 VA: 0x1810C0DD0
	public static ExecuteEvents.EventFunction<IScrollHandler> get_scrollHandler() { }

	// RVA: 0x10C0EF0 Offset: 0x10C02F0 VA: 0x1810C0EF0
	public static ExecuteEvents.EventFunction<IUpdateSelectedHandler> get_updateSelectedHandler() { }

	// RVA: 0x10C0E30 Offset: 0x10C0230 VA: 0x1810C0E30
	public static ExecuteEvents.EventFunction<ISelectHandler> get_selectHandler() { }

	// RVA: 0x10C0710 Offset: 0x10BFB10 VA: 0x1810C0710
	public static ExecuteEvents.EventFunction<IDeselectHandler> get_deselectHandler() { }

	// RVA: 0x10C0A10 Offset: 0x10BFE10 VA: 0x1810C0A10
	public static ExecuteEvents.EventFunction<IMoveHandler> get_moveHandler() { }

	// RVA: 0x10C0E90 Offset: 0x10C0290 VA: 0x1810C0E90
	public static ExecuteEvents.EventFunction<ISubmitHandler> get_submitHandler() { }

	// RVA: 0x10C06B0 Offset: 0x10BFAB0 VA: 0x1810C06B0
	public static ExecuteEvents.EventFunction<ICancelHandler> get_cancelHandler() { }

	// RVA: 0x10BFF40 Offset: 0x10BF340 VA: 0x1810BFF40
	private static void GetEventChain(GameObject root, IList<Transform> eventChain) { }

	// RVA: -1 Offset: -1
	public static bool Execute<T>(GameObject target, BaseEventData eventData, ExecuteEvents.EventFunction<T> functor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBED680 Offset: 0xBECA80 VA: 0x180BED680
	|-ExecuteEvents.Execute<object>
	|-ExecuteEvents.Execute<IBeginDragHandler>
	|-ExecuteEvents.Execute<ICancelHandler>
	|-ExecuteEvents.Execute<IDeselectHandler>
	|-ExecuteEvents.Execute<IDragHandler>
	|-ExecuteEvents.Execute<IEndDragHandler>
	|-ExecuteEvents.Execute<IInitializePotentialDragHandler>
	|-ExecuteEvents.Execute<IMoveHandler>
	|-ExecuteEvents.Execute<IPointerClickHandler>
	|-ExecuteEvents.Execute<IPointerEnterHandler>
	|-ExecuteEvents.Execute<IPointerExitHandler>
	|-ExecuteEvents.Execute<IPointerUpHandler>
	|-ExecuteEvents.Execute<ISelectHandler>
	|-ExecuteEvents.Execute<ISubmitHandler>
	|-ExecuteEvents.Execute<IUpdateSelectedHandler>
	*/

	// RVA: -1 Offset: -1
	public static GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, ExecuteEvents.EventFunction<T> callbackFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A9F2B0 Offset: 0x1A9E6B0 VA: 0x181A9F2B0
	|-ExecuteEvents.ExecuteHierarchy<object>
	|-ExecuteEvents.ExecuteHierarchy<IDropHandler>
	|-ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>
	|-ExecuteEvents.ExecuteHierarchy<IPointerExitHandler>
	|-ExecuteEvents.ExecuteHierarchy<IScrollHandler>
	*/

	// RVA: -1 Offset: -1
	private static bool ShouldSendToComponent<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBED9A0 Offset: 0xBECDA0 VA: 0x180BED9A0
	|-ExecuteEvents.ShouldSendToComponent<object>
	*/

	// RVA: -1 Offset: -1
	private static void GetEventList<T>(GameObject go, IList<IEventSystemHandler> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E6BF0 Offset: 0x5E5FF0 VA: 0x1805E6BF0
	|-ExecuteEvents.GetEventList<object>
	*/

	// RVA: -1 Offset: -1
	public static bool CanHandleEvent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBED5A0 Offset: 0xBEC9A0 VA: 0x180BED5A0
	|-ExecuteEvents.CanHandleEvent<object>
	*/

	// RVA: -1 Offset: -1
	public static GameObject GetEventHandler<T>(GameObject root) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A9F430 Offset: 0x1A9E830 VA: 0x181A9F430
	|-ExecuteEvents.GetEventHandler<object>
	|-ExecuteEvents.GetEventHandler<IDragHandler>
	|-ExecuteEvents.GetEventHandler<IPointerClickHandler>
	|-ExecuteEvents.GetEventHandler<IScrollHandler>
	|-ExecuteEvents.GetEventHandler<ISelectHandler>
	*/

	// RVA: 0x10C00C0 Offset: 0x10BF4C0 VA: 0x1810C00C0
	private static void .cctor() { }

}

public sealed class ExecuteEvents.EventFunction<T1> : MulticastDelegate // TypeDefIndex: 5077
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	|-ExecuteEvents.EventFunction<object>..ctor
	|-ExecuteEvents.EventFunction<IBeginDragHandler>..ctor
	|-ExecuteEvents.EventFunction<ICancelHandler>..ctor
	|-ExecuteEvents.EventFunction<IDeselectHandler>..ctor
	|-ExecuteEvents.EventFunction<IDragHandler>..ctor
	|-ExecuteEvents.EventFunction<IDropHandler>..ctor
	|-ExecuteEvents.EventFunction<IEndDragHandler>..ctor
	|-ExecuteEvents.EventFunction<IInitializePotentialDragHandler>..ctor
	|-ExecuteEvents.EventFunction<IMoveHandler>..ctor
	|-ExecuteEvents.EventFunction<IPointerClickHandler>..ctor
	|-ExecuteEvents.EventFunction<IPointerDownHandler>..ctor
	|-ExecuteEvents.EventFunction<IPointerEnterHandler>..ctor
	|-ExecuteEvents.EventFunction<IPointerExitHandler>..ctor
	|-ExecuteEvents.EventFunction<IPointerUpHandler>..ctor
	|-ExecuteEvents.EventFunction<IScrollHandler>..ctor
	|-ExecuteEvents.EventFunction<ISelectHandler>..ctor
	|-ExecuteEvents.EventFunction<ISubmitHandler>..ctor
	|-ExecuteEvents.EventFunction<IUpdateSelectedHandler>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(T1 handler, BaseEventData eventData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50
	|-ExecuteEvents.EventFunction<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T1 handler, BaseEventData eventData, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10
	|-ExecuteEvents.EventFunction<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497050 Offset: 0x496450 VA: 0x180497050
	|-ExecuteEvents.EventFunction<object>.EndInvoke
	*/

}

private sealed class ExecuteEvents.<>c // TypeDefIndex: 5078
{	// Fields
	public static readonly ExecuteEvents.<>c <>9; // 0x12A50

	// Methods

	// RVA: 0x10C9C60 Offset: 0x10C9060 VA: 0x1810C9C60
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x10C9C10 Offset: 0x10C9010 VA: 0x1810C9C10
	internal void <.cctor>b__79_0(List<IEventSystemHandler> l) { }

}


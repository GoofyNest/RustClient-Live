public static class ExecuteEvents // TypeDefIndex: 5080
{
	private static readonly ExecuteEvents.EventFunction<IPointerEnterHandler> s_PointerEnterHandler; 
	private static readonly ExecuteEvents.EventFunction<IPointerExitHandler> s_PointerExitHandler; 
	private static readonly ExecuteEvents.EventFunction<IPointerDownHandler> s_PointerDownHandler; 
	private static readonly ExecuteEvents.EventFunction<IPointerUpHandler> s_PointerUpHandler; 
	private static readonly ExecuteEvents.EventFunction<IPointerClickHandler> s_PointerClickHandler; 
	private static readonly ExecuteEvents.EventFunction<IInitializePotentialDragHandler> s_InitializePotentialDragHandler; 
	private static readonly ExecuteEvents.EventFunction<IBeginDragHandler> s_BeginDragHandler; 
	private static readonly ExecuteEvents.EventFunction<IDragHandler> s_DragHandler; 
	private static readonly ExecuteEvents.EventFunction<IEndDragHandler> s_EndDragHandler; 
	private static readonly ExecuteEvents.EventFunction<IDropHandler> s_DropHandler; 
	private static readonly ExecuteEvents.EventFunction<IScrollHandler> s_ScrollHandler; 
	private static readonly ExecuteEvents.EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler; 
	private static readonly ExecuteEvents.EventFunction<ISelectHandler> s_SelectHandler; 
	private static readonly ExecuteEvents.EventFunction<IDeselectHandler> s_DeselectHandler; 
	private static readonly ExecuteEvents.EventFunction<IMoveHandler> s_MoveHandler; 
	private static readonly ExecuteEvents.EventFunction<ISubmitHandler> s_SubmitHandler; 
	private static readonly ExecuteEvents.EventFunction<ICancelHandler> s_CancelHandler; 
	private static readonly ObjectPool<List<IEventSystemHandler>> s_HandlerListPool; 
	private static readonly List<Transform> s_InternalTransformList; 

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


	public static T ValidateEventData<T>(BaseEventData data) { }
	/* GenericInstMethod :
	|
	|-ExecuteEvents.ValidateEventData<object>
	|-ExecuteEvents.ValidateEventData<AxisEventData>
	|-ExecuteEvents.ValidateEventData<PointerEventData>
	*/

	private static void Execute(IPointerEnterHandler handler, BaseEventData eventData) { }

	private static void Execute(IPointerExitHandler handler, BaseEventData eventData) { }

	private static void Execute(IPointerDownHandler handler, BaseEventData eventData) { }

	private static void Execute(IPointerUpHandler handler, BaseEventData eventData) { }

	private static void Execute(IPointerClickHandler handler, BaseEventData eventData) { }

	private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData) { }

	private static void Execute(IBeginDragHandler handler, BaseEventData eventData) { }

	private static void Execute(IDragHandler handler, BaseEventData eventData) { }

	private static void Execute(IEndDragHandler handler, BaseEventData eventData) { }

	private static void Execute(IDropHandler handler, BaseEventData eventData) { }

	private static void Execute(IScrollHandler handler, BaseEventData eventData) { }

	private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData) { }

	private static void Execute(ISelectHandler handler, BaseEventData eventData) { }

	private static void Execute(IDeselectHandler handler, BaseEventData eventData) { }

	private static void Execute(IMoveHandler handler, BaseEventData eventData) { }

	private static void Execute(ISubmitHandler handler, BaseEventData eventData) { }

	private static void Execute(ICancelHandler handler, BaseEventData eventData) { }

	public static ExecuteEvents.EventFunction<IPointerEnterHandler> get_pointerEnterHandler() { }

	public static ExecuteEvents.EventFunction<IPointerExitHandler> get_pointerExitHandler() { }

	public static ExecuteEvents.EventFunction<IPointerDownHandler> get_pointerDownHandler() { }

	public static ExecuteEvents.EventFunction<IPointerUpHandler> get_pointerUpHandler() { }

	public static ExecuteEvents.EventFunction<IPointerClickHandler> get_pointerClickHandler() { }

	public static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> get_initializePotentialDrag() { }

	public static ExecuteEvents.EventFunction<IBeginDragHandler> get_beginDragHandler() { }

	public static ExecuteEvents.EventFunction<IDragHandler> get_dragHandler() { }

	public static ExecuteEvents.EventFunction<IEndDragHandler> get_endDragHandler() { }

	public static ExecuteEvents.EventFunction<IDropHandler> get_dropHandler() { }

	public static ExecuteEvents.EventFunction<IScrollHandler> get_scrollHandler() { }

	public static ExecuteEvents.EventFunction<IUpdateSelectedHandler> get_updateSelectedHandler() { }

	public static ExecuteEvents.EventFunction<ISelectHandler> get_selectHandler() { }

	public static ExecuteEvents.EventFunction<IDeselectHandler> get_deselectHandler() { }

	public static ExecuteEvents.EventFunction<IMoveHandler> get_moveHandler() { }

	public static ExecuteEvents.EventFunction<ISubmitHandler> get_submitHandler() { }

	public static ExecuteEvents.EventFunction<ICancelHandler> get_cancelHandler() { }

	private static void GetEventChain(GameObject root, IList<Transform> eventChain) { }

	public static bool Execute<T>(GameObject target, BaseEventData eventData, ExecuteEvents.EventFunction<T> functor) { }
	/* GenericInstMethod :
	|
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

	public static GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, ExecuteEvents.EventFunction<T> callbackFunction) { }
	/* GenericInstMethod :
	|
	|-ExecuteEvents.ExecuteHierarchy<object>
	|-ExecuteEvents.ExecuteHierarchy<IDropHandler>
	|-ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>
	|-ExecuteEvents.ExecuteHierarchy<IPointerExitHandler>
	|-ExecuteEvents.ExecuteHierarchy<IScrollHandler>
	*/

	private static bool ShouldSendToComponent<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-ExecuteEvents.ShouldSendToComponent<object>
	*/

	private static void GetEventList<T>(GameObject go, IList<IEventSystemHandler> results) { }
	/* GenericInstMethod :
	|
	|-ExecuteEvents.GetEventList<object>
	*/

	public static bool CanHandleEvent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-ExecuteEvents.CanHandleEvent<object>
	*/

	public static GameObject GetEventHandler<T>(GameObject root) { }
	/* GenericInstMethod :
	|
	|-ExecuteEvents.GetEventHandler<object>
	|-ExecuteEvents.GetEventHandler<IDragHandler>
	|-ExecuteEvents.GetEventHandler<IPointerClickHandler>
	|-ExecuteEvents.GetEventHandler<IScrollHandler>
	|-ExecuteEvents.GetEventHandler<ISelectHandler>
	*/

	private static void .cctor() { }

}

public sealed class ExecuteEvents.EventFunction<T1> : MulticastDelegate // TypeDefIndex: 5081
{

	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
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

	public virtual void Invoke(T1 handler, BaseEventData eventData) { }
	/* GenericInstMethod :
	|
	|-ExecuteEvents.EventFunction<object>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(T1 handler, BaseEventData eventData, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-ExecuteEvents.EventFunction<object>.BeginInvoke
	*/

	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-ExecuteEvents.EventFunction<object>.EndInvoke
	*/

}

private sealed class ExecuteEvents.<>c // TypeDefIndex: 5082
{
	public static readonly ExecuteEvents.<>c <>9; 


	private static void .cctor() { }

	public void .ctor() { }

	internal void <.cctor>b__79_0(List<IEventSystemHandler> l) { }

}


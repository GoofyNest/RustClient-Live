public abstract class PointerInputModule : BaseInputModule // TypeDefIndex: 5082
{
	public const int kMouseLeftId = -1;
	public const int kMouseRightId = -2;
	public const int kMouseMiddleId = -3;
	public const int kFakeTouchesId = -4;
	protected Dictionary<int, PointerEventData> m_PointerData; 
	private readonly PointerInputModule.MouseState m_MouseState; 


	protected bool GetPointerData(int id, out PointerEventData data, bool create) { }

	protected void RemovePointerData(PointerEventData data) { }

	protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released) { }

	protected void CopyFromTo(PointerEventData from, PointerEventData to) { }

	protected PointerEventData.FramePressState StateForMouseButton(int buttonId) { }

	protected virtual PointerInputModule.MouseState GetMousePointerEventData() { }

	protected virtual PointerInputModule.MouseState GetMousePointerEventData(int id) { }

	protected PointerEventData GetLastPointerEventData(int id) { }

	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) { }

	protected virtual void ProcessMove(PointerEventData pointerEvent) { }

	protected virtual void ProcessDrag(PointerEventData pointerEvent) { }

	public override bool IsPointerOverGameObject(int pointerId) { }

	protected void ClearSelection() { }

	public override string ToString() { }

	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	protected void .ctor() { }

}

public class PointerInputModule.MouseButtonEventData // TypeDefIndex: 5085
{
	public PointerEventData.FramePressState buttonState; 
	public PointerEventData buttonData; 


	public bool PressedThisFrame() { }

	public bool ReleasedThisFrame() { }

	public void .ctor() { }

}


public abstract class PointerInputModule : BaseInputModule // TypeDefIndex: 5081
{	// Fields
	public const int kMouseLeftId = -1;
	public const int kMouseRightId = -2;
	public const int kMouseMiddleId = -3;
	public const int kFakeTouchesId = -4;
	protected Dictionary<int, PointerEventData> m_PointerData; // 0x48
	private readonly PointerInputModule.MouseState m_MouseState; // 0x50

	// Methods

	// RVA: 0x10C39E0 Offset: 0x10C2DE0 VA: 0x1810C39E0
	protected bool GetPointerData(int id, out PointerEventData data, bool create) { }

	// RVA: 0x10C43A0 Offset: 0x10C37A0 VA: 0x1810C43A0
	protected void RemovePointerData(PointerEventData data) { }

	// RVA: 0x10C3C10 Offset: 0x10C3010 VA: 0x1810C3C10
	protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released) { }

	// RVA: 0x10C3150 Offset: 0x10C2550 VA: 0x1810C3150
	protected void CopyFromTo(PointerEventData from, PointerEventData to) { }

	// RVA: 0x10C44B0 Offset: 0x10C38B0 VA: 0x1810C44B0
	protected PointerEventData.FramePressState StateForMouseButton(int buttonId) { }

	// RVA: 0x10C39C0 Offset: 0x10C2DC0 VA: 0x1810C39C0 Slot: 26
	protected virtual PointerInputModule.MouseState GetMousePointerEventData() { }

	// RVA: 0x10C3340 Offset: 0x10C2740 VA: 0x1810C3340 Slot: 27
	protected virtual PointerInputModule.MouseState GetMousePointerEventData(int id) { }

	// RVA: 0x10C3310 Offset: 0x10C2710 VA: 0x1810C3310
	protected PointerEventData GetLastPointerEventData(int id) { }

	// RVA: 0x10C4400 Offset: 0x10C3800 VA: 0x1810C4400
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) { }

	// RVA: 0x10C4350 Offset: 0x10C3750 VA: 0x1810C4350 Slot: 28
	protected virtual void ProcessMove(PointerEventData pointerEvent) { }

	// RVA: 0x10C3FE0 Offset: 0x10C33E0 VA: 0x1810C3FE0 Slot: 29
	protected virtual void ProcessDrag(PointerEventData pointerEvent) { }

	// RVA: 0x10C3F40 Offset: 0x10C3340 VA: 0x1810C3F40 Slot: 20
	public override bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x10C2FC0 Offset: 0x10C23C0 VA: 0x1810C2FC0
	protected void ClearSelection() { }

	// RVA: 0x10C4570 Offset: 0x10C3970 VA: 0x1810C4570 Slot: 3
	public override string ToString() { }

	// RVA: 0x10C3230 Offset: 0x10C2630 VA: 0x1810C3230
	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	// RVA: 0x10C4760 Offset: 0x10C3B60 VA: 0x1810C4760
	protected void .ctor() { }

}

public class PointerInputModule.MouseButtonEventData // TypeDefIndex: 5084
{	// Fields
	public PointerEventData.FramePressState buttonState; // 0x10
	public PointerEventData buttonData; // 0x18

	// Methods

	// RVA: 0x10C10F0 Offset: 0x10C04F0 VA: 0x1810C10F0
	public bool PressedThisFrame() { }

	// RVA: 0x10C1110 Offset: 0x10C0510 VA: 0x1810C1110
	public bool ReleasedThisFrame() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}


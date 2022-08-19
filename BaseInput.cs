public class BaseInput : UIBehaviour // TypeDefIndex: 5079
{	// Properties
	public virtual string compositionString { get; }
	public virtual IMECompositionMode imeCompositionMode { get; set; }
	public virtual Vector2 compositionCursorPos { get; set; }
	public virtual bool mousePresent { get; }
	public virtual Vector2 mousePosition { get; }
	public virtual Vector2 mouseScrollDelta { get; }
	public virtual bool touchSupported { get; }
	public virtual int touchCount { get; }

	// Methods

	// RVA: 0x10B16D0 Offset: 0x10B0AD0 VA: 0x1810B16D0 Slot: 17
	public virtual string get_compositionString() { }

	// RVA: 0x10B16E0 Offset: 0x10B0AE0 VA: 0x1810B16E0 Slot: 18
	public virtual IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x10B17D0 Offset: 0x10B0BD0 VA: 0x1810B17D0 Slot: 19
	public virtual void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x10B16C0 Offset: 0x10B0AC0 VA: 0x1810B16C0 Slot: 20
	public virtual Vector2 get_compositionCursorPos() { }

	// RVA: 0x10B17B0 Offset: 0x10B0BB0 VA: 0x1810B17B0 Slot: 21
	public virtual void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x10B1770 Offset: 0x10B0B70 VA: 0x1810B1770 Slot: 22
	public virtual bool get_mousePresent() { }

	// RVA: 0x10B1640 Offset: 0x10B0A40 VA: 0x1810B1640 Slot: 23
	public virtual bool GetMouseButtonDown(int button) { }

	// RVA: 0x10B1650 Offset: 0x10B0A50 VA: 0x1810B1650 Slot: 24
	public virtual bool GetMouseButtonUp(int button) { }

	// RVA: 0x10B1660 Offset: 0x10B0A60 VA: 0x1810B1660 Slot: 25
	public virtual bool GetMouseButton(int button) { }

	// RVA: 0x10B16F0 Offset: 0x10B0AF0 VA: 0x1810B16F0 Slot: 26
	public virtual Vector2 get_mousePosition() { }

	// RVA: 0x10B1780 Offset: 0x10B0B80 VA: 0x1810B1780 Slot: 27
	public virtual Vector2 get_mouseScrollDelta() { }

	// RVA: 0x10B17A0 Offset: 0x10B0BA0 VA: 0x1810B17A0 Slot: 28
	public virtual bool get_touchSupported() { }

	// RVA: 0x10B1790 Offset: 0x10B0B90 VA: 0x1810B1790 Slot: 29
	public virtual int get_touchCount() { }

	// RVA: 0x10B1670 Offset: 0x10B0A70 VA: 0x1810B1670 Slot: 30
	public virtual Touch GetTouch(int index) { }

	// RVA: 0x10B1620 Offset: 0x10B0A20 VA: 0x1810B1620 Slot: 31
	public virtual float GetAxisRaw(string axisName) { }

	// RVA: 0x10B1630 Offset: 0x10B0A30 VA: 0x1810B1630 Slot: 32
	public virtual bool GetButtonDown(string buttonName) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}


public class BaseInput : UIBehaviour // TypeDefIndex: 5079
{	public virtual string compositionString { get; }
	public virtual IMECompositionMode imeCompositionMode { get; set; }
	public virtual Vector2 compositionCursorPos { get; set; }
	public virtual bool mousePresent { get; }
	public virtual Vector2 mousePosition { get; }
	public virtual Vector2 mouseScrollDelta { get; }
	public virtual bool touchSupported { get; }
	public virtual int touchCount { get; }


	public virtual string get_compositionString() { }

	public virtual IMECompositionMode get_imeCompositionMode() { }

	public virtual void set_imeCompositionMode(IMECompositionMode value) { }

	public virtual Vector2 get_compositionCursorPos() { }

	public virtual void set_compositionCursorPos(Vector2 value) { }

	public virtual bool get_mousePresent() { }

	public virtual bool GetMouseButtonDown(int button) { }

	public virtual bool GetMouseButtonUp(int button) { }

	public virtual bool GetMouseButton(int button) { }

	public virtual Vector2 get_mousePosition() { }

	public virtual Vector2 get_mouseScrollDelta() { }

	public virtual bool get_touchSupported() { }

	public virtual int get_touchCount() { }

	public virtual Touch GetTouch(int index) { }

	public virtual float GetAxisRaw(string axisName) { }

	public virtual bool GetButtonDown(string buttonName) { }

	public void .ctor() { }

}


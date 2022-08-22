public class InputState // TypeDefIndex: 10101
{	public InputMessage current; // 0x10
	public InputMessage previous; // 0x18
	private int SwallowedButtons; // 0x20


	public bool IsDown(BUTTON btn) { }

	public bool WasDown(BUTTON btn) { }

	public bool IsAnyDown() { }

	public bool WasJustPressed(BUTTON btn) { }

	public bool WasJustReleased(BUTTON btn) { }

	public void SwallowButton(BUTTON btn) { }

	public Quaternion AimAngle() { }

	public Vector3 MouseDelta() { }

	public void Flip(InputMessage newcurrent) { }

	public void Clear() { }

	public void .ctor() { }

}


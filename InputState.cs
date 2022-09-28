public class InputState // TypeDefIndex: 11776
{
	public InputMessage current; 
	public InputMessage previous; 
	private int SwallowedButtons; 


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


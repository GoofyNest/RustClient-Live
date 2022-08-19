public class InputState // TypeDefIndex: 10101
{	// Fields
	public InputMessage current; // 0x10
	public InputMessage previous; // 0x18
	private int SwallowedButtons; // 0x20

	// Methods

	// RVA: 0x811900 Offset: 0x810D00 VA: 0x180811900
	public bool IsDown(BUTTON btn) { }

	// RVA: 0x8119D0 Offset: 0x810DD0 VA: 0x1808119D0
	public bool WasDown(BUTTON btn) { }

	// RVA: 0x8118D0 Offset: 0x810CD0 VA: 0x1808118D0
	public bool IsAnyDown() { }

	// RVA: 0x8119F0 Offset: 0x810DF0 VA: 0x1808119F0
	public bool WasJustPressed(BUTTON btn) { }

	// RVA: 0x811A30 Offset: 0x810E30 VA: 0x180811A30
	public bool WasJustReleased(BUTTON btn) { }

	// RVA: 0x8119C0 Offset: 0x810DC0 VA: 0x1808119C0
	public void SwallowButton(BUTTON btn) { }

	// RVA: 0x811690 Offset: 0x810A90 VA: 0x180811690
	public Quaternion AimAngle() { }

	// RVA: 0x811930 Offset: 0x810D30 VA: 0x180811930
	public Vector3 MouseDelta() { }

	// RVA: 0x811800 Offset: 0x810C00 VA: 0x180811800
	public void Flip(InputMessage newcurrent) { }

	// RVA: 0x811750 Offset: 0x810B50 VA: 0x180811750
	public void Clear() { }

	// RVA: 0x811A70 Offset: 0x810E70 VA: 0x180811A70
	public void .ctor() { }

}


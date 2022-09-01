public class CursorManager : SingletonComponent<CursorManager> // TypeDefIndex: 10855
{
	private static int iHoldOpen; 
	private static int iPreviousOpen; 
	private static float lastTimeVisible; 
	private static float lastTimeInvisible; 


	private void Update() { }

	public void SwitchToGame() { }

	private void SwitchToUI() { }

	public static void HoldOpen(bool cursorVisible = False) { }

	public static bool WasVisible(float deltaTime) { }

	public static bool WasInvisible(float deltaTime) { }

	public void .ctor() { }

	private static void .cctor() { }

}


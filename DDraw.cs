public class DDraw : MonoBehaviour // TypeDefIndex: 11679
{	public static GameObject store; // 0x0
	public static DDraw singleton; // 0x8
	public List<DDraw.BaseObject> list; // 0x18
	internal static int AutoYPosition; // 0x10
	internal static float LastAutoY; // 0x14
	private static Material lineMaterial; // 0x18
	internal static GUISkin _skin; // 0x20

	internal static GUISkin skin { get; }


	public static DDraw Get() { }

	public static void Capsule(Vector3 pos, Quaternion rotation, float fRadius, float fHeight, Color color, float fDuration = 0,5, bool distanceFade = True) { }

	public static void Sphere(Vector3 vPos, float fRadius, Color color, float fDuration = 0,5, bool distanceFade = True) { }

	public static void SphereGizmo(Vector3 vPos, float fRadius, Color color, float fDuration = 0,5, bool distanceFade = True, bool ztest = True) { }

	public static void Line(Vector3 vPos, Vector3 vPosB, Color color, float fDuration = 0,5, bool distanceFade = True, bool ztest = True) { }

	public static void Line(Vector3 vPos, Vector3 vNormal, float magnitude, Color color, float fDuration = 0,5, bool distanceFade = True, bool ztest = True) { }

	public static void Arrow(Vector3 vPos, Vector3 vPosB, float headSize, Color color, float fDuration = 0,5) { }

	public static void ArrowPadded(Vector3 vPos, Vector3 vPosB, float padding, float headSize, Color color, float fDuration = 0,5) { }

	public static void Arrow(Vector3 vPos, Vector3 vNormal, float magnitude, float headSize, Color color, float fDuration = 0,5) { }

	public static void Bounds(Bounds bnds, Color color, float fDuration = 0,5, bool distanceFade = True, bool ztest = False) { }

	public static void Bounds(Matrix4x4 matrix, Bounds bnds, Color color, float fDuration = 0,5) { }

	public static void Box(Vector3 vPos, float fSize, Color color, float fDuration = 1, bool distanceFade = True) { }

	public static void Box(Vector3 vPos, Quaternion rot, Vector3 size, Color color, float fDuration = 1, bool distanceFade = True) { }

	public static void Box(Vector3 vPos) { }

	public static void Box(Matrix4x4 matrix, Color color, float fDuration = 1) { }

	public static void Text(string text, Vector3 vPos, Color color, float fDuration = 0,5) { }

	public static void ScreenText(string text, int x, int y, Color color, float fDuration = 0,5) { }

	public static void ScreenText(string text, int x, Color color, float fDuration = 0,5) { }

	private void Awake() { }

	private void OnPreRender() { }

	private void OnPostRender() { }

	private void OnGUI() { }

	private static void CreateLineMaterial() { }

	internal static GUISkin get_skin() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class DDraw.BaseObject // TypeDefIndex: 11680
{	public Vector3 position; // 0x10
	public Matrix4x4 transform; // 0x1C
	public Color color; // 0x5C
	public float end; // 0x6C
	public float start; // 0x70
	public float delta; // 0x74
	public bool distanceFade; // 0x78
	public bool ztest; // 0x79
	public Stack<Matrix4x4> matrixStack; // 0x80
	private static Vector3[] vDisc; // 0x0
	private static Vector3[] vPlane; // 0x8


	public virtual void Draw() { }

	public virtual void DrawGUI() { }

	public virtual void Render() { }

	public void PushMatrix(Matrix4x4 mat) { }

	public void PopMatrix() { }

	public void DrawHalfDisc() { }

	public void DrawDisc() { }

	public void DrawPlane() { }

	internal void Begin(int type) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class DDraw.CapsuleObj : DDraw.BaseObject // TypeDefIndex: 11681
{	public float radius; // 0x88
	public float height; // 0x8C


	public override void Draw() { }

	public void .ctor() { }

}

public class DDraw.SphereObj : DDraw.BaseObject // TypeDefIndex: 11682
{
	public override void Draw() { }

	public void .ctor() { }

}

public class DDraw.SphereGizmoObj : DDraw.BaseObject // TypeDefIndex: 11683
{	private static Matrix4x4 XZ; // 0x0
	private static Matrix4x4 YZ; // 0x40
	private static Matrix4x4 XY; // 0x80


	public override void Draw() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class DDraw.LineObj : DDraw.BaseObject // TypeDefIndex: 11684
{
	public override void Draw() { }

	public void .ctor() { }

}

public class DDraw.CubeObj : DDraw.BaseObject // TypeDefIndex: 11685
{
	public override void Draw() { }

	public void .ctor() { }

}

public class DDraw.ArrowHead : DDraw.BaseObject // TypeDefIndex: 11686
{
	public override void Draw() { }

	public void .ctor() { }

}

public class DDraw.TextObj : DDraw.BaseObject // TypeDefIndex: 11687
{	public string text; // 0x88
	protected Rect rect; // 0x90
	protected bool draw; // 0xA0


	public override void Draw() { }

	public override void DrawGUI() { }

	public void .ctor() { }

}

public class DDraw.ScreenTextObj : DDraw.BaseObject // TypeDefIndex: 11688
{	public string text; // 0x88
	public int x; // 0x90
	public int y; // 0x94
	protected Rect rect; // 0x98


	public override void Draw() { }

	public override void DrawGUI() { }

	public void .ctor() { }

}

private sealed class DDraw.<>c // TypeDefIndex: 11689
{	public static readonly DDraw.<>c <>9; // 0x0
	public static Predicate<DDraw.BaseObject> <>9__24_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <OnPreRender>b__24_0(DDraw.BaseObject o) { }

}

public class DDraw // TypeDefIndex: 11895
{
	[ClientVar] // RVA: 0x92E90 Offset: 0x92290 VA: 0x180092E90
	public static void line(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x92E90 Offset: 0x92290 VA: 0x180092E90
	public static void arrow(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x92E90 Offset: 0x92290 VA: 0x180092E90
	public static void sphere(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x92E90 Offset: 0x92290 VA: 0x180092E90
	public static void text(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x92E90 Offset: 0x92290 VA: 0x180092E90
	public static void box(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

}


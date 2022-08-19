public class DDraw : MonoBehaviour // TypeDefIndex: 11679
{	// Fields
	public static GameObject store; // 0x0
	public static DDraw singleton; // 0x8
	public List<DDraw.BaseObject> list; // 0x18
	internal static int AutoYPosition; // 0x10
	internal static float LastAutoY; // 0x14
	private static Material lineMaterial; // 0x18
	internal static GUISkin _skin; // 0x20

	// Properties
	internal static GUISkin skin { get; }

	// Methods

	// RVA: 0x9D8C70 Offset: 0x9D8070 VA: 0x1809D8C70
	public static DDraw Get() { }

	// RVA: 0x9D8890 Offset: 0x9D7C90 VA: 0x1809D8890
	public static void Capsule(Vector3 pos, Quaternion rotation, float fRadius, float fHeight, Color color, float fDuration = 0,5, bool distanceFade = True) { }

	// RVA: 0x9DA110 Offset: 0x9D9510 VA: 0x1809DA110
	public static void Sphere(Vector3 vPos, float fRadius, Color color, float fDuration = 0,5, bool distanceFade = True) { }

	// RVA: 0x9D9E20 Offset: 0x9D9220 VA: 0x1809D9E20
	public static void SphereGizmo(Vector3 vPos, float fRadius, Color color, float fDuration = 0,5, bool distanceFade = True, bool ztest = True) { }

	// RVA: 0x9D8F40 Offset: 0x9D8340 VA: 0x1809D8F40
	public static void Line(Vector3 vPos, Vector3 vPosB, Color color, float fDuration = 0,5, bool distanceFade = True, bool ztest = True) { }

	// RVA: 0x9D90C0 Offset: 0x9D84C0 VA: 0x1809D90C0
	public static void Line(Vector3 vPos, Vector3 vNormal, float magnitude, Color color, float fDuration = 0,5, bool distanceFade = True, bool ztest = True) { }

	// RVA: 0x9D7960 Offset: 0x9D6D60 VA: 0x1809D7960
	public static void Arrow(Vector3 vPos, Vector3 vPosB, float headSize, Color color, float fDuration = 0,5) { }

	// RVA: 0x9D7260 Offset: 0x9D6660 VA: 0x1809D7260
	public static void ArrowPadded(Vector3 vPos, Vector3 vPosB, float padding, float headSize, Color color, float fDuration = 0,5) { }

	// RVA: 0x9D7560 Offset: 0x9D6960 VA: 0x1809D7560
	public static void Arrow(Vector3 vPos, Vector3 vNormal, float magnitude, float headSize, Color color, float fDuration = 0,5) { }

	// RVA: 0x9D7B90 Offset: 0x9D6F90 VA: 0x1809D7B90
	public static void Bounds(Bounds bnds, Color color, float fDuration = 0,5, bool distanceFade = True, bool ztest = False) { }

	// RVA: 0x9D7E40 Offset: 0x9D7240 VA: 0x1809D7E40
	public static void Bounds(Matrix4x4 matrix, Bounds bnds, Color color, float fDuration = 0,5) { }

	// RVA: 0x9D8150 Offset: 0x9D7550 VA: 0x1809D8150
	public static void Box(Vector3 vPos, float fSize, Color color, float fDuration = 1, bool distanceFade = True) { }

	// RVA: 0x9D8400 Offset: 0x9D7800 VA: 0x1809D8400
	public static void Box(Vector3 vPos, Quaternion rot, Vector3 size, Color color, float fDuration = 1, bool distanceFade = True) { }

	// RVA: 0x9D8610 Offset: 0x9D7A10 VA: 0x1809D8610
	public static void Box(Vector3 vPos) { }

	// RVA: 0x9D86C0 Offset: 0x9D7AC0 VA: 0x1809D86C0
	public static void Box(Matrix4x4 matrix, Color color, float fDuration = 1) { }

	// RVA: 0x9DA3F0 Offset: 0x9D97F0 VA: 0x1809DA3F0
	public static void Text(string text, Vector3 vPos, Color color, float fDuration = 0,5) { }

	// RVA: 0x9D9C80 Offset: 0x9D9080 VA: 0x1809D9C80
	public static void ScreenText(string text, int x, int y, Color color, float fDuration = 0,5) { }

	// RVA: 0x9D99B0 Offset: 0x9D8DB0 VA: 0x1809D99B0
	public static void ScreenText(string text, int x, Color color, float fDuration = 0,5) { }

	// RVA: 0x9D7B20 Offset: 0x9D6F20 VA: 0x1809D7B20
	private void Awake() { }

	// RVA: 0x9D98A0 Offset: 0x9D8CA0 VA: 0x1809D98A0
	private void OnPreRender() { }

	// RVA: 0x9D9560 Offset: 0x9D8960 VA: 0x1809D9560
	private void OnPostRender() { }

	// RVA: 0x9D9390 Offset: 0x9D8790 VA: 0x1809D9390
	private void OnGUI() { }

	// RVA: 0x9D8B10 Offset: 0x9D7F10 VA: 0x1809D8B10
	private static void CreateLineMaterial() { }

	// RVA: 0x9DA600 Offset: 0x9D9A00 VA: 0x1809DA600
	internal static GUISkin get_skin() { }

	// RVA: 0x9DA590 Offset: 0x9D9990 VA: 0x1809DA590
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

public class DDraw.BaseObject // TypeDefIndex: 11680
{	// Fields
	public Vector3 position; // 0x10
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

	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 4
	public virtual void Draw() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	public virtual void DrawGUI() { }

	// RVA: 0x9CD670 Offset: 0x9CCA70 VA: 0x1809CD670 Slot: 6
	public virtual void Render() { }

	// RVA: 0x9CD4A0 Offset: 0x9CC8A0 VA: 0x1809CD4A0
	public void PushMatrix(Matrix4x4 mat) { }

	// RVA: 0x9CD440 Offset: 0x9CC840 VA: 0x1809CD440
	public void PopMatrix() { }

	// RVA: 0x9CCF70 Offset: 0x9CC370 VA: 0x1809CCF70
	public void DrawHalfDisc() { }

	// RVA: 0x9CCD40 Offset: 0x9CC140 VA: 0x1809CCD40
	public void DrawDisc() { }

	// RVA: 0x9CD210 Offset: 0x9CC610 VA: 0x1809CD210
	public void DrawPlane() { }

	// RVA: 0x9CCBA0 Offset: 0x9CBFA0 VA: 0x1809CCBA0
	internal void Begin(int type) { }

	// RVA: 0x9CDF30 Offset: 0x9CD330 VA: 0x1809CDF30
	public void .ctor() { }

	// RVA: 0x9CD780 Offset: 0x9CCB80 VA: 0x1809CD780
	private static void .cctor() { }

}

public class DDraw.CapsuleObj : DDraw.BaseObject // TypeDefIndex: 11681
{	// Fields
	public float radius; // 0x88
	public float height; // 0x8C

	// Methods

	// RVA: 0x9CF410 Offset: 0x9CE810 VA: 0x1809CF410 Slot: 4
	public override void Draw() { }

	// RVA: 0x9D01C0 Offset: 0x9CF5C0 VA: 0x1809D01C0
	public void .ctor() { }

}

public class DDraw.SphereObj : DDraw.BaseObject // TypeDefIndex: 11682
{	// Methods

	// RVA: 0x9DE390 Offset: 0x9DD790 VA: 0x1809DE390 Slot: 4
	public override void Draw() { }

	// RVA: 0x9DE5F0 Offset: 0x9DD9F0 VA: 0x1809DE5F0
	public void .ctor() { }

}

public class DDraw.SphereGizmoObj : DDraw.BaseObject // TypeDefIndex: 11683
{	// Fields
	private static Matrix4x4 XZ; // 0x0
	private static Matrix4x4 YZ; // 0x40
	private static Matrix4x4 XY; // 0x80

	// Methods

	// RVA: 0x9DDE70 Offset: 0x9DD270 VA: 0x1809DDE70 Slot: 4
	public override void Draw() { }

	// RVA: 0x9DE330 Offset: 0x9DD730 VA: 0x1809DE330
	public void .ctor() { }

	// RVA: 0x9DE080 Offset: 0x9DD480 VA: 0x1809DE080
	private static void .cctor() { }

}

public class DDraw.LineObj : DDraw.BaseObject // TypeDefIndex: 11684
{	// Methods

	// RVA: 0x9DC4A0 Offset: 0x9DB8A0 VA: 0x1809DC4A0 Slot: 4
	public override void Draw() { }

	// RVA: 0x9DC550 Offset: 0x9DB950 VA: 0x1809DC550
	public void .ctor() { }

}

public class DDraw.CubeObj : DDraw.BaseObject // TypeDefIndex: 11685
{	// Methods

	// RVA: 0x9D6B80 Offset: 0x9D5F80 VA: 0x1809D6B80 Slot: 4
	public override void Draw() { }

	// RVA: 0x9D7200 Offset: 0x9D6600 VA: 0x1809D7200
	public void .ctor() { }

}

public class DDraw.ArrowHead : DDraw.BaseObject // TypeDefIndex: 11686
{	// Methods

	// RVA: 0x9CB870 Offset: 0x9CAC70 VA: 0x1809CB870 Slot: 4
	public override void Draw() { }

	// RVA: 0x9CB9F0 Offset: 0x9CADF0 VA: 0x1809CB9F0
	public void .ctor() { }

}

public class DDraw.TextObj : DDraw.BaseObject // TypeDefIndex: 11687
{	// Fields
	public string text; // 0x88
	protected Rect rect; // 0x90
	protected bool draw; // 0xA0

	// Methods

	// RVA: 0x9DE870 Offset: 0x9DDC70 VA: 0x1809DE870 Slot: 4
	public override void Draw() { }

	// RVA: 0x9DE650 Offset: 0x9DDA50 VA: 0x1809DE650 Slot: 5
	public override void DrawGUI() { }

	// RVA: 0x9DE9E0 Offset: 0x9DDDE0 VA: 0x1809DE9E0
	public void .ctor() { }

}

public class DDraw.ScreenTextObj : DDraw.BaseObject // TypeDefIndex: 11688
{	// Fields
	public string text; // 0x88
	public int x; // 0x90
	public int y; // 0x94
	protected Rect rect; // 0x98

	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 4
	public override void Draw() { }

	// RVA: 0x9DDBE0 Offset: 0x9DCFE0 VA: 0x1809DDBE0 Slot: 5
	public override void DrawGUI() { }

	// RVA: 0x9DDE00 Offset: 0x9DD200 VA: 0x1809DDE00
	public void .ctor() { }

}

private sealed class DDraw.<>c // TypeDefIndex: 11689
{	// Fields
	public static readonly DDraw.<>c <>9; // 0x0
	public static Predicate<DDraw.BaseObject> <>9__24_0; // 0x8

	// Methods

	// RVA: 0x9DEC80 Offset: 0x9DE080 VA: 0x1809DEC80
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x9DEBF0 Offset: 0x9DDFF0 VA: 0x1809DEBF0
	internal bool <OnPreRender>b__24_0(DDraw.BaseObject o) { }

}

public class DDraw // TypeDefIndex: 11895
{	// Methods

	[ClientVar] // RVA: 0x92E90 Offset: 0x92290 VA: 0x180092E90
	// RVA: 0x6D3230 Offset: 0x6D2630 VA: 0x1806D3230
	public static void line(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x92E90 Offset: 0x92290 VA: 0x180092E90
	// RVA: 0x6D2E70 Offset: 0x6D2270 VA: 0x1806D2E70
	public static void arrow(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x92E90 Offset: 0x92290 VA: 0x180092E90
	// RVA: 0x6D3420 Offset: 0x6D2820 VA: 0x1806D3420
	public static void sphere(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x92E90 Offset: 0x92290 VA: 0x180092E90
	// RVA: 0x6D35C0 Offset: 0x6D29C0 VA: 0x1806D35C0
	public static void text(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x92E90 Offset: 0x92290 VA: 0x180092E90
	// RVA: 0x6D3090 Offset: 0x6D2490 VA: 0x1806D3090
	public static void box(ConsoleSystem.Arg arg) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}


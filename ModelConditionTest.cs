public abstract class ModelConditionTest : PrefabAttribute // TypeDefIndex: 9066
{	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool DoTest(BaseEntity ent);

	// RVA: 0x76D680 Offset: 0x76CA80 VA: 0x18076D680 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x76D100 Offset: 0x76C500 VA: 0x18076D100
	protected void .ctor() { }

}

public class ModelConditionTest_False : ModelConditionTest // TypeDefIndex: 9067
{	// Fields
	public ConditionalModel reference; // 0x98

	// Methods

	// RVA: 0x76D0D0 Offset: 0x76C4D0 VA: 0x18076D0D0 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76D100 Offset: 0x76C500 VA: 0x18076D100
	public void .ctor() { }

}

public class ModelConditionTest_FoundationSide : ModelConditionTest // TypeDefIndex: 9068
{	// Fields
	private const string square_south = "foundation/sockets/foundation-top/1";
	private const string square_north = "foundation/sockets/foundation-top/3";
	private const string square_west = "foundation/sockets/foundation-top/2";
	private const string square_east = "foundation/sockets/foundation-top/4";
	private const string triangle_south = "foundation.triangle/sockets/foundation-top/1";
	private const string triangle_northwest = "foundation.triangle/sockets/foundation-top/2";
	private const string triangle_northeast = "foundation.triangle/sockets/foundation-top/3";
	private string socket; // 0x98

	// Methods

	// RVA: 0x76D4F0 Offset: 0x76C8F0 VA: 0x18076D4F0
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x76D160 Offset: 0x76C560 VA: 0x18076D160 Slot: 6
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x76D370 Offset: 0x76C770 VA: 0x18076D370 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76D5F0 Offset: 0x76C9F0 VA: 0x18076D5F0
	public void .ctor() { }

}

public class ModelConditionTest_RampHigh : ModelConditionTest // TypeDefIndex: 9069
{	// Fields
	private const string socket = "ramp/sockets/block-male/1";

	// Methods

	// RVA: 0x76D740 Offset: 0x76CB40 VA: 0x18076D740
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x76D6E0 Offset: 0x76CAE0 VA: 0x18076D6E0 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76D100 Offset: 0x76C500 VA: 0x18076D100
	public void .ctor() { }

}

public class ModelConditionTest_RampLow : ModelConditionTest // TypeDefIndex: 9070
{	// Fields
	private const string socket = "ramp/sockets/block-male/1";

	// Methods

	// RVA: 0x76D8C0 Offset: 0x76CCC0 VA: 0x18076D8C0
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x76D850 Offset: 0x76CC50 VA: 0x18076D850 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76D100 Offset: 0x76C500 VA: 0x18076D100
	public void .ctor() { }

}

public class ModelConditionTest_RoofBottom : ModelConditionTest // TypeDefIndex: 9071
{	// Fields
	private const string roof_square = "roof/";
	private const string roof_triangle = "roof.triangle/";
	private const string socket_bot_right = "sockets/neighbour/3";
	private const string socket_bot_left = "sockets/neighbour/4";
	private const string socket_top_right = "sockets/neighbour/5";
	private const string socket_top_left = "sockets/neighbour/6";
	private static string[] sockets_bot_right; // 0x0
	private static string[] sockets_bot_left; // 0x8

	// Methods

	// RVA: 0x76DBC0 Offset: 0x76CFC0 VA: 0x18076DBC0
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x76D9D0 Offset: 0x76CDD0 VA: 0x18076D9D0 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76D100 Offset: 0x76C500 VA: 0x18076D100
	public void .ctor() { }

	// RVA: 0x76DCD0 Offset: 0x76D0D0 VA: 0x18076DCD0
	private static void .cctor() { }

}

public class ModelConditionTest_RoofLeft : ModelConditionTest // TypeDefIndex: 9072
{	// Fields
	public ModelConditionTest_RoofLeft.AngleType angle; // 0x98
	public ModelConditionTest_RoofLeft.ShapeType shape; // 0x9C
	private const string roof_square = "roof/";
	private const string roof_triangle = "roof.triangle/";
	private const string socket_right = "sockets/neighbour/3";
	private const string socket_left = "sockets/neighbour/4";
	private static string[] sockets_left; // 0x0

	// Properties
	private bool IsConvex { get; }
	private bool IsConcave { get; }

	// Methods

	// RVA: 0x76E660 Offset: 0x76DA60 VA: 0x18076E660
	private bool get_IsConvex() { }

	// RVA: 0x76E650 Offset: 0x76DA50 VA: 0x18076E650
	private bool get_IsConcave() { }

	// RVA: 0x76E3C0 Offset: 0x76D7C0 VA: 0x18076E3C0
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x76DF00 Offset: 0x76D300 VA: 0x18076DF00 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76E5F0 Offset: 0x76D9F0 VA: 0x18076E5F0
	public void .ctor() { }

	// RVA: 0x76E4D0 Offset: 0x76D8D0 VA: 0x18076E4D0
	private static void .cctor() { }

}

public enum ModelConditionTest_RoofLeft.AngleType // TypeDefIndex: 9073
{	// Fields
	public int value__; // 0x0
	public const ModelConditionTest_RoofLeft.AngleType None = -1;
	public const ModelConditionTest_RoofLeft.AngleType Straight = 0;
	public const ModelConditionTest_RoofLeft.AngleType Convex60 = 60;
	public const ModelConditionTest_RoofLeft.AngleType Convex90 = 90;
	public const ModelConditionTest_RoofLeft.AngleType Convex120 = 120;
	public const ModelConditionTest_RoofLeft.AngleType Concave30 = -30;
	public const ModelConditionTest_RoofLeft.AngleType Concave60 = -60;
	public const ModelConditionTest_RoofLeft.AngleType Concave90 = -90;
	public const ModelConditionTest_RoofLeft.AngleType Concave120 = -120;

}

public enum ModelConditionTest_RoofLeft.ShapeType // TypeDefIndex: 9074
{	// Fields
	public int value__; // 0x0
	public const ModelConditionTest_RoofLeft.ShapeType Any = -1;
	public const ModelConditionTest_RoofLeft.ShapeType Square = 0;
	public const ModelConditionTest_RoofLeft.ShapeType Triangle = 1;

}

public class ModelConditionTest_RoofRight : ModelConditionTest // TypeDefIndex: 9075
{	// Fields
	public ModelConditionTest_RoofRight.AngleType angle; // 0x98
	public ModelConditionTest_RoofRight.ShapeType shape; // 0x9C
	private const string roof_square = "roof/";
	private const string roof_triangle = "roof.triangle/";
	private const string socket_right = "sockets/neighbour/3";
	private const string socket_left = "sockets/neighbour/4";
	private static string[] sockets_right; // 0x0

	// Properties
	private bool IsConvex { get; }
	private bool IsConcave { get; }

	// Methods

	// RVA: 0x76E660 Offset: 0x76DA60 VA: 0x18076E660
	private bool get_IsConvex() { }

	// RVA: 0x76E650 Offset: 0x76DA50 VA: 0x18076E650
	private bool get_IsConcave() { }

	// RVA: 0x76EB50 Offset: 0x76DF50 VA: 0x18076EB50
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x76E670 Offset: 0x76DA70 VA: 0x18076E670 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76E5F0 Offset: 0x76D9F0 VA: 0x18076E5F0
	public void .ctor() { }

	// RVA: 0x76EC60 Offset: 0x76E060 VA: 0x18076EC60
	private static void .cctor() { }

}

public enum ModelConditionTest_RoofRight.AngleType // TypeDefIndex: 9076
{	// Fields
	public int value__; // 0x0
	public const ModelConditionTest_RoofRight.AngleType None = -1;
	public const ModelConditionTest_RoofRight.AngleType Straight = 0;
	public const ModelConditionTest_RoofRight.AngleType Convex60 = 60;
	public const ModelConditionTest_RoofRight.AngleType Convex90 = 90;
	public const ModelConditionTest_RoofRight.AngleType Convex120 = 120;
	public const ModelConditionTest_RoofRight.AngleType Concave30 = -30;
	public const ModelConditionTest_RoofRight.AngleType Concave60 = -60;
	public const ModelConditionTest_RoofRight.AngleType Concave90 = -90;
	public const ModelConditionTest_RoofRight.AngleType Concave120 = -120;

}

public enum ModelConditionTest_RoofRight.ShapeType // TypeDefIndex: 9077
{	// Fields
	public int value__; // 0x0
	public const ModelConditionTest_RoofRight.ShapeType Any = -1;
	public const ModelConditionTest_RoofRight.ShapeType Square = 0;
	public const ModelConditionTest_RoofRight.ShapeType Triangle = 1;

}

public class ModelConditionTest_RoofTop : ModelConditionTest // TypeDefIndex: 9078
{	// Fields
	private const string roof_square = "roof/";
	private const string roof_triangle = "roof.triangle/";
	private const string socket_bot_right = "sockets/neighbour/3";
	private const string socket_bot_left = "sockets/neighbour/4";
	private const string socket_top_right = "sockets/neighbour/5";
	private const string socket_top_left = "sockets/neighbour/6";
	private static string[] sockets_top_right; // 0x0
	private static string[] sockets_top_left; // 0x8

	// Methods

	// RVA: 0x76DBC0 Offset: 0x76CFC0 VA: 0x18076DBC0
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x76ED80 Offset: 0x76E180 VA: 0x18076ED80 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76D100 Offset: 0x76C500 VA: 0x18076D100
	public void .ctor() { }

	// RVA: 0x76EF70 Offset: 0x76E370 VA: 0x18076EF70
	private static void .cctor() { }

}

public class ModelConditionTest_RoofTriangle : ModelConditionTest // TypeDefIndex: 9079
{	// Fields
	private const string socket = "roof/sockets/wall-female";

	// Methods

	// RVA: 0x76F1A0 Offset: 0x76E5A0 VA: 0x18076F1A0 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76D100 Offset: 0x76C500 VA: 0x18076D100
	public void .ctor() { }

}

public class ModelConditionTest_SpiralStairs : ModelConditionTest // TypeDefIndex: 9080
{	// Fields
	private const string stairs_socket_female = "sockets/stairs-female/1";
	private static string[] stairs_sockets_female; // 0x0
	private const string floor_socket_female = "sockets/floor-female/1";
	private static string[] floor_sockets_female; // 0x8

	// Methods

	// RVA: 0x76F470 Offset: 0x76E870 VA: 0x18076F470
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x76F210 Offset: 0x76E610 VA: 0x18076F210 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76D100 Offset: 0x76C500 VA: 0x18076D100
	public void .ctor() { }

	// RVA: 0x76F580 Offset: 0x76E980 VA: 0x18076F580
	private static void .cctor() { }

}

public class ModelConditionTest_True : ModelConditionTest // TypeDefIndex: 9081
{	// Fields
	public ConditionalModel reference; // 0x98

	// Methods

	// RVA: 0x76F7B0 Offset: 0x76EBB0 VA: 0x18076F7B0 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76D100 Offset: 0x76C500 VA: 0x18076D100
	public void .ctor() { }

}

public class ModelConditionTest_Wall : ModelConditionTest // TypeDefIndex: 9082
{	// Methods

	// RVA: 0x770F10 Offset: 0x770310 VA: 0x180770F10 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76D100 Offset: 0x76C500 VA: 0x18076D100
	public void .ctor() { }

}

public class ModelConditionTest_WallCornerLeft : ModelConditionTest // TypeDefIndex: 9083
{	// Fields
	private const string socket = "sockets/stability/2";
	private static string[] sockets; // 0x2B0AA98

	// Methods

	// RVA: 0x76F7E0 Offset: 0x76EBE0 VA: 0x18076F7E0 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76D100 Offset: 0x76C500 VA: 0x18076D100
	public void .ctor() { }

	// RVA: 0x76FC00 Offset: 0x76F000 VA: 0x18076FC00
	private static void .cctor() { }

}

public class ModelConditionTest_WallCornerRight : ModelConditionTest // TypeDefIndex: 9084
{	// Fields
	private const string socket = "sockets/stability/1";
	private static string[] sockets; // 0x1761

	// Methods

	// RVA: 0x76FE60 Offset: 0x76F260 VA: 0x18076FE60 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76D100 Offset: 0x76C500 VA: 0x18076D100
	public void .ctor() { }

	// RVA: 0x770280 Offset: 0x76F680 VA: 0x180770280
	private static void .cctor() { }

}

public class ModelConditionTest_WallTriangleLeft : ModelConditionTest // TypeDefIndex: 9085
{	// Fields
	private const string socket_1 = "wall/sockets/wall-female";
	private const string socket_2 = "wall/sockets/floor-female/1";
	private const string socket_3 = "wall/sockets/floor-female/2";
	private const string socket_4 = "wall/sockets/floor-female/3";
	private const string socket_5 = "wall/sockets/floor-female/4";
	private const string socket_6 = "wall/sockets/stability/1";
	private const string socket = "wall/sockets/neighbour/1";

	// Methods

	// RVA: 0x7704E0 Offset: 0x76F8E0 VA: 0x1807704E0
	public static bool CheckCondition(BaseEntity ent) { }

	// RVA: 0x7709A0 Offset: 0x76FDA0 VA: 0x1807709A0
	private static bool CheckSocketOccupied(BaseEntity ent, string socket) { }

	// RVA: 0x7709E0 Offset: 0x76FDE0 VA: 0x1807709E0 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76D100 Offset: 0x76C500 VA: 0x18076D100
	public void .ctor() { }

}

public class ModelConditionTest_WallTriangleRight : ModelConditionTest // TypeDefIndex: 9086
{	// Fields
	private const string socket_1 = "wall/sockets/wall-female";
	private const string socket_2 = "wall/sockets/floor-female/1";
	private const string socket_3 = "wall/sockets/floor-female/2";
	private const string socket_4 = "wall/sockets/floor-female/3";
	private const string socket_5 = "wall/sockets/floor-female/4";
	private const string socket_6 = "wall/sockets/stability/2";
	private const string socket = "wall/sockets/neighbour/1";

	// Methods

	// RVA: 0x7709F0 Offset: 0x76FDF0 VA: 0x1807709F0
	public static bool CheckCondition(BaseEntity ent) { }

	// RVA: 0x7709A0 Offset: 0x76FDA0 VA: 0x1807709A0
	private static bool CheckSocketOccupied(BaseEntity ent, string socket) { }

	// RVA: 0x770F00 Offset: 0x770300 VA: 0x180770F00 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76D100 Offset: 0x76C500 VA: 0x18076D100
	public void .ctor() { }

}


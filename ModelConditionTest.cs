public abstract class ModelConditionTest : PrefabAttribute // TypeDefIndex: 9066
{

public abstract bool DoTest(BaseEntity ent);

protected override Type GetIndexedType() { }

protected void .ctor() { }

}

public class ModelConditionTest_False : ModelConditionTest // TypeDefIndex: 9067
{
	public ConditionalModel reference; 


public override bool DoTest(BaseEntity ent) { }

public void .ctor() { }

}

public class ModelConditionTest_FoundationSide : ModelConditionTest // TypeDefIndex: 9068
{
private const string square_south = "foundation/sockets/foundation-top/1";
private const string square_north = "foundation/sockets/foundation-top/3";
private const string square_west = "foundation/sockets/foundation-top/2";
private const string square_east = "foundation/sockets/foundation-top/4";
private const string triangle_south = "foundation.triangle/sockets/foundation-top/1";
private const string triangle_northwest = "foundation.triangle/sockets/foundation-top/2";
private const string triangle_northeast = "foundation.triangle/sockets/foundation-top/3";
	private string socket; 


protected void OnDrawGizmosSelected() { }

protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

public override bool DoTest(BaseEntity ent) { }

public void .ctor() { }

}

public class ModelConditionTest_RampHigh : ModelConditionTest // TypeDefIndex: 9069
{
private const string socket = "ramp/sockets/block-male/1";


protected void OnDrawGizmosSelected() { }

public override bool DoTest(BaseEntity ent) { }

public void .ctor() { }

}

public class ModelConditionTest_RampLow : ModelConditionTest // TypeDefIndex: 9070
{
private const string socket = "ramp/sockets/block-male/1";


protected void OnDrawGizmosSelected() { }

public override bool DoTest(BaseEntity ent) { }

public void .ctor() { }

}

public class ModelConditionTest_RoofBottom : ModelConditionTest // TypeDefIndex: 9071
{
private const string roof_square = "roof/";
private const string roof_triangle = "roof.triangle/";
private const string socket_bot_right = "sockets/neighbour/3";
private const string socket_bot_left = "sockets/neighbour/4";
private const string socket_top_right = "sockets/neighbour/5";
private const string socket_top_left = "sockets/neighbour/6";
	private static string[] sockets_bot_right; 
	private static string[] sockets_bot_left; 


protected void OnDrawGizmosSelected() { }

public override bool DoTest(BaseEntity ent) { }

public void .ctor() { }

private static void .cctor() { }

}

public class ModelConditionTest_RoofLeft : ModelConditionTest // TypeDefIndex: 9072
{
	public ModelConditionTest_RoofLeft.AngleType angle; 
	public ModelConditionTest_RoofLeft.ShapeType shape; 
private const string roof_square = "roof/";
private const string roof_triangle = "roof.triangle/";
private const string socket_right = "sockets/neighbour/3";
private const string socket_left = "sockets/neighbour/4";
	private static string[] sockets_left; 

private bool IsConvex { get; }
private bool IsConcave { get; }


private bool get_IsConvex() { }

private bool get_IsConcave() { }

protected void OnDrawGizmosSelected() { }

public override bool DoTest(BaseEntity ent) { }

public void .ctor() { }

private static void .cctor() { }

}

public enum ModelConditionTest_RoofLeft.AngleType // TypeDefIndex: 9073
{
	public int value__; 
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
{
	public int value__; 
public const ModelConditionTest_RoofLeft.ShapeType Any = -1;
public const ModelConditionTest_RoofLeft.ShapeType Square = 0;
public const ModelConditionTest_RoofLeft.ShapeType Triangle = 1;

}

public class ModelConditionTest_RoofRight : ModelConditionTest // TypeDefIndex: 9075
{
	public ModelConditionTest_RoofRight.AngleType angle; 
	public ModelConditionTest_RoofRight.ShapeType shape; 
private const string roof_square = "roof/";
private const string roof_triangle = "roof.triangle/";
private const string socket_right = "sockets/neighbour/3";
private const string socket_left = "sockets/neighbour/4";
	private static string[] sockets_right; 

private bool IsConvex { get; }
private bool IsConcave { get; }


private bool get_IsConvex() { }

private bool get_IsConcave() { }

protected void OnDrawGizmosSelected() { }

public override bool DoTest(BaseEntity ent) { }

public void .ctor() { }

private static void .cctor() { }

}

public enum ModelConditionTest_RoofRight.AngleType // TypeDefIndex: 9076
{
	public int value__; 
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
{
	public int value__; 
public const ModelConditionTest_RoofRight.ShapeType Any = -1;
public const ModelConditionTest_RoofRight.ShapeType Square = 0;
public const ModelConditionTest_RoofRight.ShapeType Triangle = 1;

}

public class ModelConditionTest_RoofTop : ModelConditionTest // TypeDefIndex: 9078
{
private const string roof_square = "roof/";
private const string roof_triangle = "roof.triangle/";
private const string socket_bot_right = "sockets/neighbour/3";
private const string socket_bot_left = "sockets/neighbour/4";
private const string socket_top_right = "sockets/neighbour/5";
private const string socket_top_left = "sockets/neighbour/6";
	private static string[] sockets_top_right; 
	private static string[] sockets_top_left; 


protected void OnDrawGizmosSelected() { }

public override bool DoTest(BaseEntity ent) { }

public void .ctor() { }

private static void .cctor() { }

}

public class ModelConditionTest_RoofTriangle : ModelConditionTest // TypeDefIndex: 9079
{
private const string socket = "roof/sockets/wall-female";


public override bool DoTest(BaseEntity ent) { }

public void .ctor() { }

}

public class ModelConditionTest_SpiralStairs : ModelConditionTest // TypeDefIndex: 9080
{
private const string stairs_socket_female = "sockets/stairs-female/1";
	private static string[] stairs_sockets_female; 
private const string floor_socket_female = "sockets/floor-female/1";
	private static string[] floor_sockets_female; 


protected void OnDrawGizmosSelected() { }

public override bool DoTest(BaseEntity ent) { }

public void .ctor() { }

private static void .cctor() { }

}

public class ModelConditionTest_True : ModelConditionTest // TypeDefIndex: 9081
{
	public ConditionalModel reference; 


public override bool DoTest(BaseEntity ent) { }

public void .ctor() { }

}

public class ModelConditionTest_Wall : ModelConditionTest // TypeDefIndex: 9082
{

public override bool DoTest(BaseEntity ent) { }

public void .ctor() { }

}

public class ModelConditionTest_WallCornerLeft : ModelConditionTest // TypeDefIndex: 9083
{
private const string socket = "sockets/stability/2";
	private static string[] sockets; 


public override bool DoTest(BaseEntity ent) { }

public void .ctor() { }

private static void .cctor() { }

}

public class ModelConditionTest_WallCornerRight : ModelConditionTest // TypeDefIndex: 9084
{
private const string socket = "sockets/stability/1";
	private static string[] sockets; 


public override bool DoTest(BaseEntity ent) { }

public void .ctor() { }

private static void .cctor() { }

}

public class ModelConditionTest_WallTriangleLeft : ModelConditionTest // TypeDefIndex: 9085
{
private const string socket_1 = "wall/sockets/wall-female";
private const string socket_2 = "wall/sockets/floor-female/1";
private const string socket_3 = "wall/sockets/floor-female/2";
private const string socket_4 = "wall/sockets/floor-female/3";
private const string socket_5 = "wall/sockets/floor-female/4";
private const string socket_6 = "wall/sockets/stability/1";
private const string socket = "wall/sockets/neighbour/1";


public static bool CheckCondition(BaseEntity ent) { }

private static bool CheckSocketOccupied(BaseEntity ent, string socket) { }

public override bool DoTest(BaseEntity ent) { }

public void .ctor() { }

}

public class ModelConditionTest_WallTriangleRight : ModelConditionTest // TypeDefIndex: 9086
{
private const string socket_1 = "wall/sockets/wall-female";
private const string socket_2 = "wall/sockets/floor-female/1";
private const string socket_3 = "wall/sockets/floor-female/2";
private const string socket_4 = "wall/sockets/floor-female/3";
private const string socket_5 = "wall/sockets/floor-female/4";
private const string socket_6 = "wall/sockets/stability/2";
private const string socket = "wall/sockets/neighbour/1";


public static bool CheckCondition(BaseEntity ent) { }

private static bool CheckSocketOccupied(BaseEntity ent, string socket) { }

public override bool DoTest(BaseEntity ent) { }

public void .ctor() { }

}


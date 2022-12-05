public class DiagnosticsConSys : ConsoleSystem // TypeDefIndex: 11012
{

	private static void DumpAnimators(string targetFolder) { }

	private static void DumpEntities(string targetFolder) { }

	private static void DumpLODGroups(string targetFolder) { }

	private static void DumpLODGroupTotals(string targetFolder) { }

	private static void DumpNetwork(string targetFolder) { }

	private static void DumpObjects(string targetFolder) { }

	private static void DumpPhysics(string targetFolder) { }

	private static void DumpTotals(string targetFolder) { }

	private static void DumpColliders(string targetFolder) { }

	private static void DumpRigidBodies(string targetFolder) { }

	private static void DumpGameObjects(string targetFolder) { }

	private static void DumpGameObjectRecursive(StringBuilder str, Transform tx, int indent, bool includeComponents = False) { }

	[ServerVar]
	[ClientVar]
	public static void dump(ConsoleSystem.Arg args) { }

	private static void DumpSystemInformation(string targetFolder) { }

	private static void WriteTextToFile(string file, string text) { }

	public void .ctor() { }

}

private sealed class DiagnosticsConSys.<>c // TypeDefIndex: 11013
{
	public static readonly DiagnosticsConSys.<>c <>9;
	public static Func<Animator, string> <>9__0_0;
	public static Func<IGrouping<string, Animator>, int> <>9__0_1;
	public static Func<Animator, string> <>9__0_2;
	public static Func<IGrouping<string, Animator>, int> <>9__0_3;
	public static Func<BaseNetworkable, uint> <>9__1_0;
	public static Func<IGrouping<uint, BaseNetworkable>, int> <>9__1_1;
	public static Func<LODGroup, string> <>9__3_0;
	public static Func<IGrouping<string, LODGroup>, int> <>9__3_1;
	public static Func<Object, Type> <>9__5_0;
	public static Func<IGrouping<Type, Object>, int> <>9__5_1;
	public static Func<Object, bool> <>9__5_2;
	public static Func<Object, Type> <>9__5_3;
	public static Func<IGrouping<Type, Object>, int> <>9__5_4;
	public static Func<Collider, bool> <>9__7_0;
	public static Func<Collider, string> <>9__8_0;
	public static Func<IGrouping<string, Collider>, int> <>9__8_1;
	public static Func<Collider, bool> <>9__8_2;
	public static Func<Collider, bool> <>9__8_3;
	public static Func<Rigidbody, string> <>9__9_0;
	public static Func<IGrouping<string, Rigidbody>, int> <>9__9_1;
	public static Func<Rigidbody, bool> <>9__9_2;
	public static Func<Rigidbody, bool> <>9__9_3;
	public static Func<Rigidbody, bool> <>9__9_4;
	public static Func<Transform, string> <>9__10_0;
	public static Func<IGrouping<string, Transform>, int> <>9__10_1;
	public static Func<Transform, string> <>9__10_2;
	public static Func<Transform, int> <>9__10_5;
	public static Func<IGrouping<string, Transform>, KeyValuePair<Transform, int>> <>9__10_3;
	public static Func<KeyValuePair<Transform, int>, int> <>9__10_4;


	private static void .cctor() { }

	public void .ctor() { }

	internal string <DumpAnimators>

	internal int <DumpAnimators>

	internal string <DumpAnimators>

	internal int <DumpAnimators>

	internal uint <DumpEntities>

	internal int <DumpEntities>

	internal string <DumpLODGroupTotals>

	internal int <DumpLODGroupTotals>

	internal Type <DumpObjects>

	internal int <DumpObjects>

	internal bool <DumpObjects>

	internal Type <DumpObjects>

	internal int <DumpObjects>

	internal bool <DumpTotals>

	internal string <DumpColliders>

	internal int <DumpColliders>

	internal bool <DumpColliders>

	internal bool <DumpColliders>

	internal string <DumpRigidBodies>

	internal int <DumpRigidBodies>

	internal bool <DumpRigidBodies>

	internal bool <DumpRigidBodies>

	internal bool <DumpRigidBodies>

	internal string <DumpGameObjects>

	internal int <DumpGameObjects>

	internal string <DumpGameObjects>

	internal KeyValuePair<Transform, int> <DumpGameObjects>

	internal int <DumpGameObjects>

	internal int <DumpGameObjects>

}


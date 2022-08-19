public class DiagnosticsConSys : ConsoleSystem // TypeDefIndex: 9275
{	// Methods

	// RVA: 0x9BF210 Offset: 0x9BE610 VA: 0x1809BF210
	private static void DumpAnimators(string targetFolder) { }

	// RVA: 0x9C0330 Offset: 0x9BF730 VA: 0x1809C0330
	private static void DumpEntities(string targetFolder) { }

	// RVA: 0x9C1DC0 Offset: 0x9C11C0 VA: 0x1809C1DC0
	private static void DumpLODGroups(string targetFolder) { }

	// RVA: 0x9C1950 Offset: 0x9C0D50 VA: 0x1809C1950
	private static void DumpLODGroupTotals(string targetFolder) { }

	// RVA: 0x9C1DD0 Offset: 0x9C11D0 VA: 0x1809C1DD0
	private static void DumpNetwork(string targetFolder) { }

	// RVA: 0x9C1F50 Offset: 0x9C1350 VA: 0x1809C1F50
	private static void DumpObjects(string targetFolder) { }

	// RVA: 0x9C28C0 Offset: 0x9C1CC0 VA: 0x1809C28C0
	private static void DumpPhysics(string targetFolder) { }

	// RVA: 0x9C3540 Offset: 0x9C2940 VA: 0x1809C3540
	private static void DumpTotals(string targetFolder) { }

	// RVA: 0x9BFC70 Offset: 0x9BF070 VA: 0x1809BFC70
	private static void DumpColliders(string targetFolder) { }

	// RVA: 0x9C28F0 Offset: 0x9C1CF0 VA: 0x1809C28F0
	private static void DumpRigidBodies(string targetFolder) { }

	// RVA: 0x9C0D40 Offset: 0x9C0140 VA: 0x1809C0D40
	private static void DumpGameObjects(string targetFolder) { }

	// RVA: 0x9C0A50 Offset: 0x9BFE50 VA: 0x1809C0A50
	private static void DumpGameObjectRecursive(StringBuilder str, Transform tx, int indent, bool includeComponents = False) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x9C39C0 Offset: 0x9C2DC0 VA: 0x1809C39C0
	public static void dump(ConsoleSystem.Arg args) { }

	// RVA: 0x9C34E0 Offset: 0x9C28E0 VA: 0x1809C34E0
	private static void DumpSystemInformation(string targetFolder) { }

	// RVA: 0x9C3950 Offset: 0x9C2D50 VA: 0x1809C3950
	private static void WriteTextToFile(string file, string text) { }

	// RVA: 0x9C3960 Offset: 0x9C2D60 VA: 0x1809C3960
	public void .ctor() { }

}

private sealed class DiagnosticsConSys.<>c // TypeDefIndex: 9276
{	// Fields
	public static readonly DiagnosticsConSys.<>c <>9; // 0x0
	public static Func<Animator, string> <>9__0_0; // 0x8
	public static Func<IGrouping<string, Animator>, int> <>9__0_1; // 0x10
	public static Func<Animator, string> <>9__0_2; // 0x18
	public static Func<IGrouping<string, Animator>, int> <>9__0_3; // 0x20
	public static Func<BaseNetworkable, uint> <>9__1_0; // 0x28
	public static Func<IGrouping<uint, BaseNetworkable>, int> <>9__1_1; // 0x30
	public static Func<LODGroup, string> <>9__3_0; // 0x38
	public static Func<IGrouping<string, LODGroup>, int> <>9__3_1; // 0x40
	public static Func<Object, Type> <>9__5_0; // 0x48
	public static Func<IGrouping<Type, Object>, int> <>9__5_1; // 0x50
	public static Func<Object, bool> <>9__5_2; // 0x58
	public static Func<Object, Type> <>9__5_3; // 0x60
	public static Func<IGrouping<Type, Object>, int> <>9__5_4; // 0x68
	public static Func<Collider, bool> <>9__7_0; // 0x70
	public static Func<Collider, string> <>9__8_0; // 0x78
	public static Func<IGrouping<string, Collider>, int> <>9__8_1; // 0x80
	public static Func<Collider, bool> <>9__8_2; // 0x88
	public static Func<Collider, bool> <>9__8_3; // 0x90
	public static Func<Rigidbody, string> <>9__9_0; // 0x98
	public static Func<IGrouping<string, Rigidbody>, int> <>9__9_1; // 0xA0
	public static Func<Rigidbody, bool> <>9__9_2; // 0xA8
	public static Func<Rigidbody, bool> <>9__9_3; // 0xB0
	public static Func<Rigidbody, bool> <>9__9_4; // 0xB8
	public static Func<Transform, string> <>9__10_0; // 0xC0
	public static Func<IGrouping<string, Transform>, int> <>9__10_1; // 0xC8
	public static Func<Transform, string> <>9__10_2; // 0xD0
	public static Func<Transform, int> <>9__10_5; // 0xD8
	public static Func<IGrouping<string, Transform>, KeyValuePair<Transform, int>> <>9__10_3; // 0xE0
	public static Func<KeyValuePair<Transform, int>, int> <>9__10_4; // 0xE8

	// Methods

	// RVA: 0x9CA8A0 Offset: 0x9C9CA0 VA: 0x1809CA8A0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x9C9F30 Offset: 0x9C9330 VA: 0x1809C9F30
	internal string <DumpAnimators>b__0_0(Animator x) { }

	// RVA: 0x9C9F80 Offset: 0x9C9380 VA: 0x1809C9F80
	internal int <DumpAnimators>b__0_1(IGrouping<string, Animator> x) { }

	// RVA: 0x9C9FC0 Offset: 0x9C93C0 VA: 0x1809C9FC0
	internal string <DumpAnimators>b__0_2(Animator x) { }

	// RVA: 0x9CA040 Offset: 0x9C9440 VA: 0x1809CA040
	internal int <DumpAnimators>b__0_3(IGrouping<string, Animator> x) { }

	// RVA: 0x9CA130 Offset: 0x9C9530 VA: 0x1809CA130
	internal uint <DumpEntities>b__1_0(BaseNetworkable x) { }

	// RVA: 0x9CA150 Offset: 0x9C9550 VA: 0x1809CA150
	internal int <DumpEntities>b__1_1(IGrouping<uint, BaseNetworkable> x) { }

	// RVA: 0x9CA3B0 Offset: 0x9C97B0 VA: 0x1809CA3B0
	internal string <DumpLODGroupTotals>b__3_0(LODGroup x) { }

	// RVA: 0x9CA400 Offset: 0x9C9800 VA: 0x1809CA400
	internal int <DumpLODGroupTotals>b__3_1(IGrouping<string, LODGroup> x) { }

	// RVA: 0x9CA440 Offset: 0x9C9840 VA: 0x1809CA440
	internal Type <DumpObjects>b__5_0(Object x) { }

	// RVA: 0x9CA460 Offset: 0x9C9860 VA: 0x1809CA460
	internal int <DumpObjects>b__5_1(IGrouping<Type, Object> x) { }

	// RVA: 0x9CA4A0 Offset: 0x9C98A0 VA: 0x1809CA4A0
	internal bool <DumpObjects>b__5_2(Object x) { }

	// RVA: 0x9CA440 Offset: 0x9C9840 VA: 0x1809CA440
	internal Type <DumpObjects>b__5_3(Object x) { }

	// RVA: 0x9CA520 Offset: 0x9C9920 VA: 0x1809CA520
	internal int <DumpObjects>b__5_4(IGrouping<Type, Object> x) { }

	// RVA: 0x6E5B20 Offset: 0x6E4F20 VA: 0x1806E5B20
	internal bool <DumpTotals>b__7_0(Collider x) { }

	// RVA: 0x9CA080 Offset: 0x9C9480 VA: 0x1809CA080
	internal string <DumpColliders>b__8_0(Collider x) { }

	// RVA: 0x9CA0D0 Offset: 0x9C94D0 VA: 0x1809CA0D0
	internal int <DumpColliders>b__8_1(IGrouping<string, Collider> x) { }

	// RVA: 0x9CA110 Offset: 0x9C9510 VA: 0x1809CA110
	internal bool <DumpColliders>b__8_2(Collider x) { }

	// RVA: 0x6E5B20 Offset: 0x6E4F20 VA: 0x1806E5B20
	internal bool <DumpColliders>b__8_3(Collider x) { }

	// RVA: 0x9CA560 Offset: 0x9C9960 VA: 0x1809CA560
	internal string <DumpRigidBodies>b__9_0(Rigidbody x) { }

	// RVA: 0x9CA5B0 Offset: 0x9C99B0 VA: 0x1809CA5B0
	internal int <DumpRigidBodies>b__9_1(IGrouping<string, Rigidbody> x) { }

	// RVA: 0x9CA5F0 Offset: 0x9C99F0 VA: 0x1809CA5F0
	internal bool <DumpRigidBodies>b__9_2(Rigidbody x) { }

	// RVA: 0x9CA620 Offset: 0x9C9A20 VA: 0x1809CA620
	internal bool <DumpRigidBodies>b__9_3(Rigidbody x) { }

	// RVA: 0x9CA640 Offset: 0x9C9A40 VA: 0x1809CA640
	internal bool <DumpRigidBodies>b__9_4(Rigidbody x) { }

	// RVA: 0x7CFD80 Offset: 0x7CF180 VA: 0x1807CFD80
	internal string <DumpGameObjects>b__10_0(Transform x) { }

	// RVA: 0x9CA190 Offset: 0x9C9590 VA: 0x1809CA190
	internal int <DumpGameObjects>b__10_1(IGrouping<string, Transform> x) { }

	// RVA: 0x7CFD80 Offset: 0x7CF180 VA: 0x1807CFD80
	internal string <DumpGameObjects>b__10_2(Transform x) { }

	// RVA: 0x9CA1D0 Offset: 0x9C95D0 VA: 0x1809CA1D0
	internal KeyValuePair<Transform, int> <DumpGameObjects>b__10_3(IGrouping<string, Transform> x) { }

	// RVA: 0x9CA360 Offset: 0x9C9760 VA: 0x1809CA360
	internal int <DumpGameObjects>b__10_5(Transform y) { }

	// RVA: 0x9CA320 Offset: 0x9C9720 VA: 0x1809CA320
	internal int <DumpGameObjects>b__10_4(KeyValuePair<Transform, int> x) { }

}


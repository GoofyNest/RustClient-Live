internal struct Internal_DrawTextureArguments // TypeDefIndex: 3394
{	// Fields
	public Rect screenRect; // 0x0
	public Rect sourceRect; // 0x10
	public int leftBorder; // 0x20
	public int rightBorder; // 0x24
	public int topBorder; // 0x28
	public int bottomBorder; // 0x2C
	public Color leftBorderColor; // 0x30
	public Color rightBorderColor; // 0x40
	public Color topBorderColor; // 0x50
	public Color bottomBorderColor; // 0x60
	public Color color; // 0x70
	public Vector4 borderWidths; // 0x80
	public Vector4 cornerRadiuses; // 0x90
	public bool smoothCorners; // 0xA0
	public int pass; // 0xA4
	public Texture texture; // 0xA8
	public Material mat; // 0xB0

}

internal static class Internal_SubsystemInstances // TypeDefIndex: 3942
{	// Fields
	internal static List<ISubsystem> s_IntegratedSubsystemInstances; // 0x0
	internal static List<ISubsystem> s_StandaloneSubsystemInstances; // 0x8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2313E30 Offset: 0x2313230 VA: 0x182313E30
	internal static void Internal_InitializeManagedInstance(IntPtr ptr, IntegratedSubsystem inst) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2313A20 Offset: 0x2312E20 VA: 0x182313A20
	internal static void Internal_ClearManagedInstances() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2313EF0 Offset: 0x23132F0 VA: 0x182313EF0
	internal static void Internal_RemoveInstanceByPtr(IntPtr ptr) { }

	// RVA: 0x2313C50 Offset: 0x2313050 VA: 0x182313C50
	internal static IntegratedSubsystem Internal_GetInstanceByPtr(IntPtr ptr) { }

	// RVA: 0x2314190 Offset: 0x2313590 VA: 0x182314190
	private static void .cctor() { }

}

internal static class Internal_SubsystemDescriptors // TypeDefIndex: 3943
{	// Fields
	internal static List<ISubsystemDescriptorImpl> s_IntegratedSubsystemDescriptors; // 0x0
	internal static List<ISubsystemDescriptor> s_StandaloneSubsystemDescriptors; // 0x8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x23134C0 Offset: 0x23128C0 VA: 0x1823134C0
	internal static bool Internal_AddDescriptor(SubsystemDescriptor descriptor) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x23138E0 Offset: 0x2312CE0 VA: 0x1823138E0
	internal static void Internal_InitializeManagedDescriptor(IntPtr ptr, ISubsystemDescriptorImpl desc) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x23136F0 Offset: 0x2312AF0 VA: 0x1823136F0
	internal static void Internal_ClearManagedDescriptors() { }

	// RVA: 0x2313980 Offset: 0x2312D80 VA: 0x182313980
	private static void .cctor() { }

}


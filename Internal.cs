internal struct Internal_DrawTextureArguments // TypeDefIndex: 3394
{
	public Rect screenRect; 
	public Rect sourceRect; 
	public int leftBorder; 
	public int rightBorder; 
	public int topBorder; 
	public int bottomBorder; 
	public Color leftBorderColor; 
	public Color rightBorderColor; 
	public Color topBorderColor; 
	public Color bottomBorderColor; 
	public Color color; 
	public Vector4 borderWidths; 
	public Vector4 cornerRadiuses; 
	public bool smoothCorners; 
	public int pass; 
	public Texture texture; 
	public Material mat; 

}

internal static class Internal_SubsystemInstances // TypeDefIndex: 3942
{
	internal static List<ISubsystem> s_IntegratedSubsystemInstances; 
	internal static List<ISubsystem> s_StandaloneSubsystemInstances; 


	[RequiredByNativeCodeAttribute] 
	internal static void Internal_InitializeManagedInstance(IntPtr ptr, IntegratedSubsystem inst) { }

	[RequiredByNativeCodeAttribute] 
	internal static void Internal_ClearManagedInstances() { }

	[RequiredByNativeCodeAttribute] 
	internal static void Internal_RemoveInstanceByPtr(IntPtr ptr) { }

	internal static IntegratedSubsystem Internal_GetInstanceByPtr(IntPtr ptr) { }

	private static void .cctor() { }

}

internal static class Internal_SubsystemDescriptors // TypeDefIndex: 3943
{
	internal static List<ISubsystemDescriptorImpl> s_IntegratedSubsystemDescriptors; 
	internal static List<ISubsystemDescriptor> s_StandaloneSubsystemDescriptors; 


	[RequiredByNativeCodeAttribute] 
	internal static bool Internal_AddDescriptor(SubsystemDescriptor descriptor) { }

	[RequiredByNativeCodeAttribute] 
	internal static void Internal_InitializeManagedDescriptor(IntPtr ptr, ISubsystemDescriptorImpl desc) { }

	[RequiredByNativeCodeAttribute] 
	internal static void Internal_ClearManagedDescriptors() { }

	private static void .cctor() { }

}


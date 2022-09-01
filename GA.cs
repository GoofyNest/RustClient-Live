public static class GA // TypeDefIndex: 5677
{
	internal static bool initialized; 
	[CompilerGeneratedAttribute] 
	private static bool <Logging>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static string <CustomUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static string <Build>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static string <Device>k__BackingField; 

	public static bool Logging { get; set; }
	public static string CustomUserId { get; set; }
	public static string Build { get; set; }
	public static string Device { get; set; }


	[CompilerGeneratedAttribute] 
	public static bool get_Logging() { }

	[CompilerGeneratedAttribute] 
	public static void set_Logging(bool value) { }

	[CompilerGeneratedAttribute] 
	public static string get_CustomUserId() { }

	[CompilerGeneratedAttribute] 
	public static void set_CustomUserId(string value) { }

	[CompilerGeneratedAttribute] 
	public static string get_Build() { }

	[CompilerGeneratedAttribute] 
	public static void set_Build(string value) { }

	[CompilerGeneratedAttribute] 
	public static string get_Device() { }

	[CompilerGeneratedAttribute] 
	public static void set_Device(string value) { }

	public static void Initialize(string gameKey, string gameSecret) { }

	public static void DesignEvent(string eventName) { }

	public static void DesignEvent(string eventName, float eventValue) { }

	public static void BusinessEvent(string currency, int amount, string itemType, string itemId, string cartType) { }

	public static void Shutdown() { }

	private static void .cctor() { }

}


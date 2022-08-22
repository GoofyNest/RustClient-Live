public sealed class SystemInfo // TypeDefIndex: 3556
{	public static BatteryStatus batteryStatus { get; }
	public static string operatingSystem { get; }
	public static OperatingSystemFamily operatingSystemFamily { get; }
	public static string processorType { get; }
	public static int processorFrequency { get; }
	public static int processorCount { get; }
	public static int systemMemorySize { get; }
	public static string deviceUniqueIdentifier { get; }
	public static string deviceName { get; }
	public static string deviceModel { get; }
	public static DeviceType deviceType { get; }
	public static int graphicsMemorySize { get; }
	public static string graphicsDeviceName { get; }
	public static string graphicsDeviceVendor { get; }
	public static GraphicsDeviceType graphicsDeviceType { get; }
	public static bool graphicsUVStartsAtTop { get; }
	public static string graphicsDeviceVersion { get; }
	public static int graphicsShaderLevel { get; }
	public static bool graphicsMultiThreaded { get; }
	[ObsoleteAttribute] // RVA: 0xCD350 Offset: 0xCC750 VA: 0x1800CD350
	public static bool supportsRenderTextures { get; }
	public static bool supportsMotionVectors { get; }
	[ObsoleteAttribute] // RVA: 0xCD470 Offset: 0xCC870 VA: 0x1800CD470
	public static bool supportsImageEffects { get; }
	public static bool supports3DTextures { get; }
	public static bool supports3DRenderTextures { get; }
	public static CopyTextureSupport copyTextureSupport { get; }
	public static bool supportsComputeShaders { get; }
	public static bool supportsInstancing { get; }
	public static int supportedRenderTargetCount { get; }
	public static int supportedRandomWriteTargetCount { get; }
	public static bool usesReversedZBuffer { get; }
	public static bool supportsAsyncGPUReadback { get; }
	public static bool supportsMipStreaming { get; }


	public static BatteryStatus get_batteryStatus() { }

	public static string get_operatingSystem() { }

	public static OperatingSystemFamily get_operatingSystemFamily() { }

	public static string get_processorType() { }

	public static int get_processorFrequency() { }

	public static int get_processorCount() { }

	public static int get_systemMemorySize() { }

	public static string get_deviceUniqueIdentifier() { }

	public static string get_deviceName() { }

	public static string get_deviceModel() { }

	public static DeviceType get_deviceType() { }

	public static int get_graphicsMemorySize() { }

	public static string get_graphicsDeviceName() { }

	public static string get_graphicsDeviceVendor() { }

	public static GraphicsDeviceType get_graphicsDeviceType() { }

	public static bool get_graphicsUVStartsAtTop() { }

	public static string get_graphicsDeviceVersion() { }

	public static int get_graphicsShaderLevel() { }

	public static bool get_graphicsMultiThreaded() { }

	public static bool get_supportsRenderTextures() { }

	public static bool get_supportsMotionVectors() { }

	public static bool get_supportsImageEffects() { }

	public static bool get_supports3DTextures() { }

	public static bool get_supports3DRenderTextures() { }

	public static CopyTextureSupport get_copyTextureSupport() { }

	public static bool get_supportsComputeShaders() { }

	public static bool get_supportsInstancing() { }

	public static int get_supportedRenderTargetCount() { }

	public static int get_supportedRandomWriteTargetCount() { }

	public static bool get_usesReversedZBuffer() { }

	private static bool IsValidEnumValue(Enum value) { }

	public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

	public static bool SupportsTextureFormat(TextureFormat format) { }

	public static bool get_supportsAsyncGPUReadback() { }

	public static bool get_supportsMipStreaming() { }

	[FreeFunctionAttribute] // RVA: 0xCAB00 Offset: 0xC9F00 VA: 0x1800CAB00
	private static BatteryStatus GetBatteryStatus() { }

	[FreeFunctionAttribute] // RVA: 0xCAB80 Offset: 0xC9F80 VA: 0x1800CAB80
	private static string GetOperatingSystem() { }

	[FreeFunctionAttribute] // RVA: 0xCACA0 Offset: 0xCA0A0 VA: 0x1800CACA0
	private static OperatingSystemFamily GetOperatingSystemFamily() { }

	[FreeFunctionAttribute] // RVA: 0xCAD70 Offset: 0xCA170 VA: 0x1800CAD70
	private static string GetProcessorType() { }

	[FreeFunctionAttribute] // RVA: 0xCADE0 Offset: 0xCA1E0 VA: 0x1800CADE0
	private static int GetProcessorFrequencyMHz() { }

	[FreeFunctionAttribute] // RVA: 0xCAE30 Offset: 0xCA230 VA: 0x1800CAE30
	private static int GetProcessorCount() { }

	[FreeFunctionAttribute] // RVA: 0xCAF00 Offset: 0xCA300 VA: 0x1800CAF00
	private static int GetPhysicalMemoryMB() { }

	[FreeFunctionAttribute] // RVA: 0xCAF80 Offset: 0xCA380 VA: 0x1800CAF80
	private static string GetDeviceUniqueIdentifier() { }

	[FreeFunctionAttribute] // RVA: 0xCB0C0 Offset: 0xCA4C0 VA: 0x1800CB0C0
	private static string GetDeviceName() { }

	[FreeFunctionAttribute] // RVA: 0xCB1D0 Offset: 0xCA5D0 VA: 0x1800CB1D0
	private static string GetDeviceModel() { }

	[FreeFunctionAttribute] // RVA: 0xCB2A0 Offset: 0xCA6A0 VA: 0x1800CB2A0
	private static DeviceType GetDeviceType() { }

	[FreeFunctionAttribute] // RVA: 0xCB3B0 Offset: 0xCA7B0 VA: 0x1800CB3B0
	private static int GetGraphicsMemorySize() { }

	[FreeFunctionAttribute] // RVA: 0xCB550 Offset: 0xCA950 VA: 0x1800CB550
	private static string GetGraphicsDeviceName() { }

	[FreeFunctionAttribute] // RVA: 0xCB880 Offset: 0xCAC80 VA: 0x1800CB880
	private static string GetGraphicsDeviceVendor() { }

	[FreeFunctionAttribute] // RVA: 0xCBA80 Offset: 0xCAE80 VA: 0x1800CBA80
	private static GraphicsDeviceType GetGraphicsDeviceType() { }

	[FreeFunctionAttribute] // RVA: 0xCBBC0 Offset: 0xCAFC0 VA: 0x1800CBBC0
	private static bool GetGraphicsUVStartsAtTop() { }

	[FreeFunctionAttribute] // RVA: 0xCBCF0 Offset: 0xCB0F0 VA: 0x1800CBCF0
	private static string GetGraphicsDeviceVersion() { }

	[FreeFunctionAttribute] // RVA: 0xCBD60 Offset: 0xCB160 VA: 0x1800CBD60
	private static int GetGraphicsShaderLevel() { }

	[FreeFunctionAttribute] // RVA: 0xCBE30 Offset: 0xCB230 VA: 0x1800CBE30
	private static bool GetGraphicsMultiThreaded() { }

	[FreeFunctionAttribute] // RVA: 0xCBFF0 Offset: 0xCB3F0 VA: 0x1800CBFF0
	private static bool SupportsMotionVectors() { }

	[FreeFunctionAttribute] // RVA: 0xCC150 Offset: 0xCB550 VA: 0x1800CC150
	private static bool Supports3DTextures() { }

	[FreeFunctionAttribute] // RVA: 0xCC2F0 Offset: 0xCB6F0 VA: 0x1800CC2F0
	private static bool Supports3DRenderTextures() { }

	[FreeFunctionAttribute] // RVA: 0xCC3B0 Offset: 0xCB7B0 VA: 0x1800CC3B0
	private static CopyTextureSupport GetCopyTextureSupport() { }

	[FreeFunctionAttribute] // RVA: 0xCC5F0 Offset: 0xCB9F0 VA: 0x1800CC5F0
	private static bool SupportsComputeShaders() { }

	[FreeFunctionAttribute] // RVA: 0xCC680 Offset: 0xCBA80 VA: 0x1800CC680
	private static bool SupportsInstancing() { }

	[FreeFunctionAttribute] // RVA: 0xCC810 Offset: 0xCBC10 VA: 0x1800CC810
	private static int SupportedRenderTargetCount() { }

	[FreeFunctionAttribute] // RVA: 0xCC9F0 Offset: 0xCBDF0 VA: 0x1800CC9F0
	private static int SupportedRandomWriteTargetCount() { }

	[FreeFunctionAttribute] // RVA: 0xCCAE0 Offset: 0xCBEE0 VA: 0x1800CCAE0
	private static bool UsesReversedZBuffer() { }

	[FreeFunctionAttribute] // RVA: 0xCCCC0 Offset: 0xCC0C0 VA: 0x1800CCCC0
	private static bool HasRenderTextureNative(RenderTextureFormat format) { }

	[FreeFunctionAttribute] // RVA: 0xCCD40 Offset: 0xCC140 VA: 0x1800CCD40
	private static bool SupportsTextureFormatNative(TextureFormat format) { }

	[FreeFunctionAttribute] // RVA: 0xCCE00 Offset: 0xCC200 VA: 0x1800CCE00
	private static bool SupportsAsyncGPUReadback() { }

	[FreeFunctionAttribute] // RVA: 0xCCE30 Offset: 0xCC230 VA: 0x1800CCE30
	private static bool SupportsMipStreaming() { }

	[FreeFunctionAttribute] // RVA: 0xCD040 Offset: 0xCC440 VA: 0x1800CD040
	public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage) { }

	[FreeFunctionAttribute] // RVA: 0xCD100 Offset: 0xCC500 VA: 0x1800CD100
	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage) { }

	[FreeFunctionAttribute] // RVA: 0xCD240 Offset: 0xCC640 VA: 0x1800CD240
	public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) { }

}


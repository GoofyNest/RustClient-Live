public struct SystemInformation // TypeDefIndex: 6205
{	// Fields
	public SystemInformation.Hardware hardware; // 0x0
	public SystemInformation.Environment environment; // 0x1

}

public struct SystemInformation.Hardware // TypeDefIndex: 6206
{	// Properties
	public string deviceName { get; }
	public string operatingSystem { get; }
	public string processorType { get; }
	public string processorCount { get; }
	public string systemMemorySize { get; }
	public string graphicsDeviceName { get; }
	public string graphicsDeviceVersion { get; }
	public string graphicsMemorySize { get; }
	public string graphicsShaderLevel { get; }
	public string graphicsDeviceType { get; }
	public string deviceUniqueIdentifier { get; }
	public string graphicsDeviceVendor { get; }
	public bool graphicsMultiThreaded { get; }
	public int processorFrequency { get; }
	public string processorArchitecture { get; }

	// Methods

	// RVA: 0x1F0E00 Offset: 0x1F0200 VA: 0x1801F0E00
	public string get_deviceName() { }

	// RVA: 0x1F0E10 Offset: 0x1F0210 VA: 0x1801F0E10
	public string get_operatingSystem() { }

	// RVA: 0x1F0B90 Offset: 0x1EFF90 VA: 0x1801F0B90
	public string get_processorType() { }

	// RVA: 0x1F1760 Offset: 0x1F0B60 VA: 0x1801F1760
	public string get_processorCount() { }

	// RVA: 0x1F17A0 Offset: 0x1F0BA0 VA: 0x1801F17A0
	public string get_systemMemorySize() { }

	// RVA: 0x1F0BB0 Offset: 0x1EFFB0 VA: 0x1801F0BB0
	public string get_graphicsDeviceName() { }

	// RVA: 0x1F1670 Offset: 0x1F0A70 VA: 0x1801F1670
	public string get_graphicsDeviceVersion() { }

	// RVA: 0x1F1680 Offset: 0x1F0A80 VA: 0x1801F1680
	public string get_graphicsMemorySize() { }

	// RVA: 0x1F16F0 Offset: 0x1F0AF0 VA: 0x1801F16F0
	public string get_graphicsShaderLevel() { }

	// RVA: 0x1F15D0 Offset: 0x1F09D0 VA: 0x1801F15D0
	public string get_graphicsDeviceType() { }

	// RVA: 0x1F15C0 Offset: 0x1F09C0 VA: 0x1801F15C0
	public string get_deviceUniqueIdentifier() { }

	// RVA: 0x1F1660 Offset: 0x1F0A60 VA: 0x1801F1660
	public string get_graphicsDeviceVendor() { }

	// RVA: 0x1F16E0 Offset: 0x1F0AE0 VA: 0x1801F16E0
	public bool get_graphicsMultiThreaded() { }

	// RVA: 0x1F1790 Offset: 0x1F0B90 VA: 0x1801F1790
	public int get_processorFrequency() { }

	// RVA: 0x1F1720 Offset: 0x1F0B20 VA: 0x1801F1720
	public string get_processorArchitecture() { }

}

public struct SystemInformation.Environment // TypeDefIndex: 6207
{	// Properties
	public string unityVersion { get; }
	public string version { get; }
	public string companyName { get; }
	public bool isEditor { get; }
	public bool isPlayer { get; }
	public string systemLanguage { get; }
	public int targetFrameRate { get; }
	public Resolution currentResolution { get; }
	public int screenWidth { get; }
	public int screenHeight { get; }
	public bool fullScreen { get; }
	public string anisotropicFiltering { get; }
	public string antiAliasing { get; }
	public string qualityLevel { get; }
	public string globalMaximumLOD { get; }
	public string lodBias { get; }
	public string maximumLODLevel { get; }
	public string particleRaycastBudget { get; }
	public string pixelLightCount { get; }
	public string realtimeReflectionProbes { get; }
	public string shadowCascades { get; }
	public string shadowDistance { get; }
	public string softVegetation { get; }
	public string vSyncCount { get; }

	// Methods

	// RVA: 0x1F1390 Offset: 0x1F0790 VA: 0x1801F1390
	public string get_unityVersion() { }

	// RVA: 0x1F13D0 Offset: 0x1F07D0 VA: 0x1801F13D0
	public string get_version() { }

	// RVA: 0x1F1070 Offset: 0x1F0470 VA: 0x1801F1070
	public string get_companyName() { }

	// RVA: 0x1F10F0 Offset: 0x1F04F0 VA: 0x1801F10F0
	public bool get_isEditor() { }

	// RVA: 0x1F1100 Offset: 0x1F0500 VA: 0x1801F1100
	public bool get_isPlayer() { }

	// RVA: 0x1F12F0 Offset: 0x1F06F0 VA: 0x1801F12F0
	public string get_systemLanguage() { }

	// RVA: 0x1F1380 Offset: 0x1F0780 VA: 0x1801F1380
	public int get_targetFrameRate() { }

	// RVA: 0x1F1080 Offset: 0x1F0480 VA: 0x1801F1080
	public Resolution get_currentResolution() { }

	// RVA: 0x1F1250 Offset: 0x1F0650 VA: 0x1801F1250
	public int get_screenWidth() { }

	// RVA: 0x1F1240 Offset: 0x1F0640 VA: 0x1801F1240
	public int get_screenHeight() { }

	// RVA: 0x1F10B0 Offset: 0x1F04B0 VA: 0x1801F10B0
	public bool get_fullScreen() { }

	// RVA: 0x1F0FB0 Offset: 0x1F03B0 VA: 0x1801F0FB0
	public string get_anisotropicFiltering() { }

	// RVA: 0x1F1040 Offset: 0x1F0440 VA: 0x1801F1040
	public string get_antiAliasing() { }

	// RVA: 0x1F11E0 Offset: 0x1F05E0 VA: 0x1801F11E0
	public string get_qualityLevel() { }

	// RVA: 0x1F10C0 Offset: 0x1F04C0 VA: 0x1801F10C0
	public string get_globalMaximumLOD() { }

	// RVA: 0x1F1120 Offset: 0x1F0520 VA: 0x1801F1120
	public string get_lodBias() { }

	// RVA: 0x1F1150 Offset: 0x1F0550 VA: 0x1801F1150
	public string get_maximumLODLevel() { }

	// RVA: 0x1F1180 Offset: 0x1F0580 VA: 0x1801F1180
	public string get_particleRaycastBudget() { }

	// RVA: 0x1F11B0 Offset: 0x1F05B0 VA: 0x1801F11B0
	public string get_pixelLightCount() { }

	// RVA: 0x1F1210 Offset: 0x1F0610 VA: 0x1801F1210
	public string get_realtimeReflectionProbes() { }

	// RVA: 0x1F1260 Offset: 0x1F0660 VA: 0x1801F1260
	public string get_shadowCascades() { }

	// RVA: 0x1F1290 Offset: 0x1F0690 VA: 0x1801F1290
	public string get_shadowDistance() { }

	// RVA: 0x1F12C0 Offset: 0x1F06C0 VA: 0x1801F12C0
	public string get_softVegetation() { }

	// RVA: 0x1F13A0 Offset: 0x1F07A0 VA: 0x1801F13A0
	public string get_vSyncCount() { }

}


public sealed class QualitySettings : Object // TypeDefIndex: 3395
{	// Properties
	public static int pixelLightCount { get; }
	public static int shadowCascades { get; set; }
	public static float shadowDistance { get; set; }
	[NativePropertyAttribute] // RVA: 0x8D470 Offset: 0x8C870 VA: 0x18008D470
	public static float lodBias { get; set; }
	[NativePropertyAttribute] // RVA: 0x8D4F0 Offset: 0x8C8F0 VA: 0x18008D4F0
	public static AnisotropicFiltering anisotropicFiltering { get; set; }
	public static int masterTextureLimit { get; }
	public static int maximumLODLevel { get; }
	public static int particleRaycastBudget { get; }
	public static bool softVegetation { get; }
	public static int vSyncCount { get; set; }
	public static int antiAliasing { get; set; }
	public static bool realtimeReflectionProbes { get; }
	public static bool streamingMipmapsActive { get; set; }
	public static float streamingMipmapsMemoryBudget { get; set; }
	public static int streamingMipmapsMaxLevelReduction { get; }
	[StaticAccessorAttribute] // RVA: 0x8D680 Offset: 0x8CA80 VA: 0x18008D680
	public static int maxQueuedFrames { get; set; }
	public static ColorSpace activeColorSpace { get; }

	// Methods

	// RVA: 0x18F8590 Offset: 0x18F7990 VA: 0x1818F8590
	public static int get_pixelLightCount() { }

	// RVA: 0x18F85F0 Offset: 0x18F79F0 VA: 0x1818F85F0
	public static int get_shadowCascades() { }

	// RVA: 0x18F8840 Offset: 0x18F7C40 VA: 0x1818F8840
	public static void set_shadowCascades(int value) { }

	// RVA: 0x18F8620 Offset: 0x18F7A20 VA: 0x1818F8620
	public static float get_shadowDistance() { }

	// RVA: 0x18F8880 Offset: 0x18F7C80 VA: 0x1818F8880
	public static void set_shadowDistance(float value) { }

	// RVA: 0x18F84A0 Offset: 0x18F78A0 VA: 0x1818F84A0
	public static float get_lodBias() { }

	// RVA: 0x18F87C0 Offset: 0x18F7BC0 VA: 0x1818F87C0
	public static void set_lodBias(float value) { }

	// RVA: 0x18F8440 Offset: 0x18F7840 VA: 0x1818F8440
	public static AnisotropicFiltering get_anisotropicFiltering() { }

	// RVA: 0x18F8740 Offset: 0x18F7B40 VA: 0x1818F8740
	public static void set_anisotropicFiltering(AnisotropicFiltering value) { }

	// RVA: 0x18F84D0 Offset: 0x18F78D0 VA: 0x1818F84D0
	public static int get_masterTextureLimit() { }

	// RVA: 0x18F8530 Offset: 0x18F7930 VA: 0x1818F8530
	public static int get_maximumLODLevel() { }

	// RVA: 0x18F8560 Offset: 0x18F7960 VA: 0x1818F8560
	public static int get_particleRaycastBudget() { }

	// RVA: 0x18F8650 Offset: 0x18F7A50 VA: 0x1818F8650
	public static bool get_softVegetation() { }

	// RVA: 0x18F8710 Offset: 0x18F7B10 VA: 0x1818F8710
	public static int get_vSyncCount() { }

	// RVA: 0x18F8940 Offset: 0x18F7D40 VA: 0x1818F8940
	public static void set_vSyncCount(int value) { }

	// RVA: 0x18F8470 Offset: 0x18F7870 VA: 0x1818F8470
	public static int get_antiAliasing() { }

	// RVA: 0x18F8780 Offset: 0x18F7B80 VA: 0x1818F8780
	public static void set_antiAliasing(int value) { }

	// RVA: 0x18F85C0 Offset: 0x18F79C0 VA: 0x1818F85C0
	public static bool get_realtimeReflectionProbes() { }

	// RVA: 0x18F8680 Offset: 0x18F7A80 VA: 0x1818F8680
	public static bool get_streamingMipmapsActive() { }

	// RVA: 0x18F88C0 Offset: 0x18F7CC0 VA: 0x1818F88C0
	public static void set_streamingMipmapsActive(bool value) { }

	// RVA: 0x18F86E0 Offset: 0x18F7AE0 VA: 0x1818F86E0
	public static float get_streamingMipmapsMemoryBudget() { }

	// RVA: 0x18F8900 Offset: 0x18F7D00 VA: 0x1818F8900
	public static void set_streamingMipmapsMemoryBudget(float value) { }

	// RVA: 0x18F86B0 Offset: 0x18F7AB0 VA: 0x1818F86B0
	public static int get_streamingMipmapsMaxLevelReduction() { }

	// RVA: 0x18F8500 Offset: 0x18F7900 VA: 0x1818F8500
	public static int get_maxQueuedFrames() { }

	// RVA: 0x18F8800 Offset: 0x18F7C00 VA: 0x1818F8800
	public static void set_maxQueuedFrames(int value) { }

	[NativeNameAttribute] // RVA: 0x8D0D0 Offset: 0x8C4D0 VA: 0x18008D0D0
	// RVA: 0x18F83A0 Offset: 0x18F77A0 VA: 0x1818F83A0
	public static int GetQualityLevel() { }

	[NativeNameAttribute] // RVA: 0x8D130 Offset: 0x8C530 VA: 0x18008D130
	// RVA: 0x18F83D0 Offset: 0x18F77D0 VA: 0x1818F83D0
	public static void SetQualityLevel(int index, bool applyExpensiveChanges) { }

	[NativeNameAttribute] // RVA: 0x8D2B0 Offset: 0x8C6B0 VA: 0x18008D2B0
	[StaticAccessorAttribute] // RVA: 0x8D2B0 Offset: 0x8C6B0 VA: 0x18008D2B0
	// RVA: 0x18F8410 Offset: 0x18F7810 VA: 0x1818F8410
	public static ColorSpace get_activeColorSpace() { }

}


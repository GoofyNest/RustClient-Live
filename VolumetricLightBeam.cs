public class VolumetricLightBeam : MonoBehaviour // TypeDefIndex: 11554
{	// Fields
	public bool colorFromLight; // 0x18
	public ColorMode colorMode; // 0x1C
	[ColorUsageAttribute] // RVA: 0xC39D0 Offset: 0xC2DD0 VA: 0x1800C39D0
	[FormerlySerializedAsAttribute] // RVA: 0xC39D0 Offset: 0xC2DD0 VA: 0x1800C39D0
	public Color color; // 0x20
	public Gradient colorGradient; // 0x30
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float alphaInside; // 0x38
	[FormerlySerializedAsAttribute] // RVA: 0xC4E90 Offset: 0xC4290 VA: 0x1800C4E90
	[RangeAttribute] // RVA: 0xC4E90 Offset: 0xC4290 VA: 0x1800C4E90
	public float alphaOutside; // 0x3C
	public BlendingMode blendingMode; // 0x40
	[FormerlySerializedAsAttribute] // RVA: 0xC5050 Offset: 0xC4450 VA: 0x1800C5050
	public bool spotAngleFromLight; // 0x44
	[RangeAttribute] // RVA: 0xC5100 Offset: 0xC4500 VA: 0x1800C5100
	public float spotAngle; // 0x48
	[FormerlySerializedAsAttribute] // RVA: 0xC5120 Offset: 0xC4520 VA: 0x1800C5120
	public float coneRadiusStart; // 0x4C
	public MeshType geomMeshType; // 0x50
	[FormerlySerializedAsAttribute] // RVA: 0xC5260 Offset: 0xC4660 VA: 0x1800C5260
	public int geomCustomSides; // 0x54
	public int geomCustomSegments; // 0x58
	public bool geomCap; // 0x5C
	public bool fadeEndFromLight; // 0x5D
	public AttenuationEquation attenuationEquation; // 0x60
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float attenuationCustomBlending; // 0x64
	public float fadeStart; // 0x68
	public float fadeEnd; // 0x6C
	public float depthBlendDistance; // 0x70
	public float cameraClippingDistance; // 0x74
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float glareFrontal; // 0x78
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float glareBehind; // 0x7C
	[ObsoleteAttribute] // RVA: 0xC54C0 Offset: 0xC48C0 VA: 0x1800C54C0
	public float boostDistanceInside; // 0x80
	[ObsoleteAttribute] // RVA: 0xC56A0 Offset: 0xC4AA0 VA: 0x1800C56A0
	public float fresnelPowInside; // 0x84
	[FormerlySerializedAsAttribute] // RVA: 0xC5770 Offset: 0xC4B70 VA: 0x1800C5770
	public float fresnelPow; // 0x88
	public bool noiseEnabled; // 0x8C
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float noiseIntensity; // 0x90
	public bool noiseScaleUseGlobal; // 0x94
	[RangeAttribute] // RVA: 0xBF120 Offset: 0xBE520 VA: 0x1800BF120
	public float noiseScaleLocal; // 0x98
	public bool noiseVelocityUseGlobal; // 0x9C
	public Vector3 noiseVelocityLocal; // 0xA0
	private Plane m_PlaneWS; // 0xAC
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int pluginVersion; // 0xBC
	[FormerlySerializedAsAttribute] // RVA: 0xC5AD0 Offset: 0xC4ED0 VA: 0x1800C5AD0
	[SerializeField] // RVA: 0xC5AD0 Offset: 0xC4ED0 VA: 0x1800C5AD0
	private bool _TrackChangesDuringPlaytime; // 0xC0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int _SortingLayerID; // 0xC4
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int _SortingOrder; // 0xC8
	private BeamGeometry m_BeamGeom; // 0xD0
	private Coroutine m_CoPlaytimeUpdate; // 0xD8
	private Light _CachedLight; // 0xE0

	// Properties
	public float coneAngle { get; }
	public float coneRadiusEnd { get; }
	public float coneVolume { get; }
	public float coneApexOffsetZ { get; }
	public int geomSides { get; set; }
	public int geomSegments { get; set; }
	public float attenuationLerpLinearQuad { get; }
	public int sortingLayerID { get; set; }
	public string sortingLayerName { get; set; }
	public int sortingOrder { get; set; }
	public bool trackChangesDuringPlaytime { get; set; }
	public bool isCurrentlyTrackingChanges { get; }
	public bool hasGeometry { get; }
	public Bounds bounds { get; }
	public int blendingModeAsInt { get; }
	public MeshRenderer Renderer { get; }
	public string meshStats { get; }
	public int meshVerticesCount { get; }
	public int meshTrianglesCount { get; }
	private Light lightSpotAttached { get; }

	// Methods

	// RVA: 0xADDA40 Offset: 0xADCE40 VA: 0x180ADDA40
	public float get_coneAngle() { }

	// RVA: 0xADDB40 Offset: 0xADCF40 VA: 0x180ADDB40
	public float get_coneRadiusEnd() { }

	// RVA: 0xADDBD0 Offset: 0xADCFD0 VA: 0x180ADDBD0
	public float get_coneVolume() { }

	// RVA: 0xADDAE0 Offset: 0xADCEE0 VA: 0x180ADDAE0
	public float get_coneApexOffsetZ() { }

	// RVA: 0xADDC90 Offset: 0xADD090 VA: 0x180ADDC90
	public int get_geomSides() { }

	// RVA: 0xADE250 Offset: 0xADD650 VA: 0x180ADE250
	public void set_geomSides(int value) { }

	// RVA: 0xADDC20 Offset: 0xADD020 VA: 0x180ADDC20
	public int get_geomSegments() { }

	// RVA: 0xADE1E0 Offset: 0xADD5E0 VA: 0x180ADE1E0
	public void set_geomSegments(int value) { }

	// RVA: 0xADD7E0 Offset: 0xADCBE0 VA: 0x180ADD7E0
	public float get_attenuationLerpLinearQuad() { }

	// RVA: 0xADE1B0 Offset: 0xADD5B0 VA: 0x180ADE1B0
	public int get_sortingLayerID() { }

	// RVA: 0xADE2C0 Offset: 0xADD6C0 VA: 0x180ADE2C0
	public void set_sortingLayerID(int value) { }

	// RVA: 0xADE1C0 Offset: 0xADD5C0 VA: 0x180ADE1C0
	public string get_sortingLayerName() { }

	// RVA: 0xADE360 Offset: 0xADD760 VA: 0x180ADE360
	public void set_sortingLayerName(string value) { }

	// RVA: 0xADE1D0 Offset: 0xADD5D0 VA: 0x180ADE1D0
	public int get_sortingOrder() { }

	// RVA: 0xADE410 Offset: 0xADD810 VA: 0x180ADE410
	public void set_sortingOrder(int value) { }

	// RVA: 0x588350 Offset: 0x587750 VA: 0x180588350
	public bool get_trackChangesDuringPlaytime() { }

	// RVA: 0x588360 Offset: 0x587760 VA: 0x180588360
	public void set_trackChangesDuringPlaytime(bool value) { }

	// RVA: 0xADDD60 Offset: 0xADD160 VA: 0x180ADDD60
	public bool get_isCurrentlyTrackingChanges() { }

	// RVA: 0xADDD00 Offset: 0xADD100 VA: 0x180ADDD00
	public bool get_hasGeometry() { }

	// RVA: 0xADD8E0 Offset: 0xADCCE0 VA: 0x180ADD8E0
	public Bounds get_bounds() { }

	// RVA: 0xADD330 Offset: 0xADC730 VA: 0x180ADD330
	public void SetClippingPlane(Plane planeWS) { }

	// RVA: 0xADD2A0 Offset: 0xADC6A0 VA: 0x180ADD2A0
	public void SetClippingPlaneOff() { }

	// RVA: 0xADCFD0 Offset: 0xADC3D0 VA: 0x180ADCFD0
	public bool IsColliderHiddenByDynamicOccluder(Collider collider) { }

	// RVA: 0xADD800 Offset: 0xADCC00 VA: 0x180ADD800
	public int get_blendingModeAsInt() { }

	// RVA: 0xADD750 Offset: 0xADCB50 VA: 0x180ADD750
	public MeshRenderer get_Renderer() { }

	// RVA: 0xADDE60 Offset: 0xADD260 VA: 0x180ADDE60
	public string get_meshStats() { }

	// RVA: 0xADE0D0 Offset: 0xADD4D0 VA: 0x180ADE0D0
	public int get_meshVerticesCount() { }

	// RVA: 0xADDFD0 Offset: 0xADD3D0 VA: 0x180ADDFD0
	public int get_meshTrianglesCount() { }

	// RVA: 0xADDD70 Offset: 0xADD170 VA: 0x180ADDD70
	private Light get_lightSpotAttached() { }

	// RVA: 0xADCD00 Offset: 0xADC100 VA: 0x180ADCD00
	public float GetInsideBeamFactor(Vector3 posWS) { }

	// RVA: 0xADCB00 Offset: 0xADBF00 VA: 0x180ADCB00
	public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS) { }

	[ObsoleteAttribute] // RVA: 0xC5EA0 Offset: 0xC52A0 VA: 0x1800C5EA0
	// RVA: 0x4D0950 Offset: 0x4CFD50 VA: 0x1804D0950
	public void Generate() { }

	// RVA: 0xADC8C0 Offset: 0xADBCC0 VA: 0x180ADC8C0 Slot: 4
	public virtual void GenerateGeometry() { }

	// RVA: 0xADD3E0 Offset: 0xADC7E0 VA: 0x180ADD3E0 Slot: 5
	public virtual void UpdateAfterManualPropertyChange() { }

	// RVA: 0x4D0950 Offset: 0x4CFD50 VA: 0x1804D0950
	private void Start() { }

	// RVA: 0xADD210 Offset: 0xADC610 VA: 0x180ADD210
	private void OnEnable() { }

	// RVA: 0xADD170 Offset: 0xADC570 VA: 0x180ADD170
	private void OnDisable() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void StartPlaytimeUpdateIfNeeded() { }

	[IteratorStateMachineAttribute] // RVA: 0xC5F40 Offset: 0xC5340 VA: 0x1800C5F40
	// RVA: 0xADC780 Offset: 0xADBB80 VA: 0x180ADC780
	private IEnumerator CoPlaytimeUpdate() { }

	// RVA: 0xADC7F0 Offset: 0xADBBF0 VA: 0x180ADC7F0
	private void OnDestroy() { }

	// RVA: 0xADC7F0 Offset: 0xADBBF0 VA: 0x180ADC7F0
	private void DestroyBeam() { }

	// RVA: 0xADC500 Offset: 0xADB900 VA: 0x180ADC500
	private void AssignPropertiesFromSpotLight(Light lightSpot) { }

	// RVA: 0xADC5D0 Offset: 0xADB9D0 VA: 0x180ADC5D0
	private void ClampProperties() { }

	// RVA: 0xADD470 Offset: 0xADC870 VA: 0x180ADD470
	private void ValidateProperties() { }

	// RVA: 0xADCF40 Offset: 0xADC340 VA: 0x180ADCF40
	private void HandleBackwardCompatibility(int serializedVersion, int newVersion) { }

	// RVA: 0xADD610 Offset: 0xADCA10 VA: 0x180ADD610
	public void .ctor() { }

}

private sealed class VolumetricLightBeam.<CoPlaytimeUpdate>d__98 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11555
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public VolumetricLightBeam <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xAC53A0 Offset: 0xAC47A0 VA: 0x180AC53A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC5440 Offset: 0xAC4840 VA: 0x180AC5440 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}


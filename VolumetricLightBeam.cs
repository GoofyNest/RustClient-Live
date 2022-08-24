public class VolumetricLightBeam : MonoBehaviour // TypeDefIndex: 11554
{
	public bool colorFromLight; 
	public ColorMode colorMode; 
	[ColorUsageAttribute] 
	[FormerlySerializedAsAttribute] 
	public Color color; 
	public Gradient colorGradient; 
	[RangeAttribute] 
	public float alphaInside; 
	[FormerlySerializedAsAttribute] 
	[RangeAttribute] 
	public float alphaOutside; 
	public BlendingMode blendingMode; 
	[FormerlySerializedAsAttribute] 
	public bool spotAngleFromLight; 
	[RangeAttribute] 
	public float spotAngle; 
	[FormerlySerializedAsAttribute] 
	public float coneRadiusStart; 
	public MeshType geomMeshType; 
	[FormerlySerializedAsAttribute] 
	public int geomCustomSides; 
	public int geomCustomSegments; 
	public bool geomCap; 
	public bool fadeEndFromLight; 
	public AttenuationEquation attenuationEquation; 
	[RangeAttribute] 
	public float attenuationCustomBlending; 
	public float fadeStart; 
	public float fadeEnd; 
	public float depthBlendDistance; 
	public float cameraClippingDistance; 
	[RangeAttribute] 
	public float glareFrontal; 
	[RangeAttribute] 
	public float glareBehind; 
	[ObsoleteAttribute] 
	public float boostDistanceInside; 
	[ObsoleteAttribute] 
	public float fresnelPowInside; 
	[FormerlySerializedAsAttribute] 
	public float fresnelPow; 
	public bool noiseEnabled; 
	[RangeAttribute] 
	public float noiseIntensity; 
	public bool noiseScaleUseGlobal; 
	[RangeAttribute] 
	public float noiseScaleLocal; 
	public bool noiseVelocityUseGlobal; 
	public Vector3 noiseVelocityLocal; 
	private Plane m_PlaneWS; 
	[SerializeField] 
	private int pluginVersion; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private bool _TrackChangesDuringPlaytime; 
	[SerializeField] 
	private int _SortingLayerID; 
	[SerializeField] 
	private int _SortingOrder; 
	private BeamGeometry m_BeamGeom; 
	private Coroutine m_CoPlaytimeUpdate; 
	private Light _CachedLight; 

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


public float get_coneAngle() { }

public float get_coneRadiusEnd() { }

public float get_coneVolume() { }

public float get_coneApexOffsetZ() { }

public int get_geomSides() { }

public void set_geomSides(int value) { }

public int get_geomSegments() { }

public void set_geomSegments(int value) { }

public float get_attenuationLerpLinearQuad() { }

public int get_sortingLayerID() { }

public void set_sortingLayerID(int value) { }

public string get_sortingLayerName() { }

public void set_sortingLayerName(string value) { }

public int get_sortingOrder() { }

public void set_sortingOrder(int value) { }

public bool get_trackChangesDuringPlaytime() { }

public void set_trackChangesDuringPlaytime(bool value) { }

public bool get_isCurrentlyTrackingChanges() { }

public bool get_hasGeometry() { }

public Bounds get_bounds() { }

public void SetClippingPlane(Plane planeWS) { }

public void SetClippingPlaneOff() { }

public bool IsColliderHiddenByDynamicOccluder(Collider collider) { }

public int get_blendingModeAsInt() { }

public MeshRenderer get_Renderer() { }

public string get_meshStats() { }

public int get_meshVerticesCount() { }

public int get_meshTrianglesCount() { }

private Light get_lightSpotAttached() { }

public float GetInsideBeamFactor(Vector3 posWS) { }

public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS) { }

	[ObsoleteAttribute] 
public void Generate() { }

public virtual void GenerateGeometry() { }

public virtual void UpdateAfterManualPropertyChange() { }

private void Start() { }

private void OnEnable() { }

private void OnDisable() { }

private void StartPlaytimeUpdateIfNeeded() { }

	[IteratorStateMachineAttribute] 
private IEnumerator CoPlaytimeUpdate() { }

private void OnDestroy() { }

private void DestroyBeam() { }

private void AssignPropertiesFromSpotLight(Light lightSpot) { }

private void ClampProperties() { }

private void ValidateProperties() { }

private void HandleBackwardCompatibility(int serializedVersion, int newVersion) { }

public void .ctor() { }

}

private sealed class VolumetricLightBeam.<CoPlaytimeUpdate>d__98 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11555
{
	private int <>1__state; 
	private object <>2__current; 
	public VolumetricLightBeam <>4__this; 

private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
private void System.IDisposable.Dispose() { }

private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
private object System.Collections.IEnumerator.get_Current() { }

}


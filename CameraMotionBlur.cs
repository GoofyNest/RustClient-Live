public class CameraMotionBlur : PostEffectsBase // TypeDefIndex: 8168
{	// Fields
	private static float MAX_RADIUS; // 0x0
	public CameraMotionBlur.MotionBlurFilter filterType; // 0x28
	public bool preview; // 0x2C
	public Vector3 previewScale; // 0x30
	public float movementScale; // 0x3C
	public float rotationScale; // 0x40
	public float maxVelocity; // 0x44
	public float minVelocity; // 0x48
	public float velocityScale; // 0x4C
	public float softZDistance; // 0x50
	public int velocityDownsample; // 0x54
	public LayerMask excludeLayers; // 0x58
	private GameObject tmpCam; // 0x60
	public Shader shader; // 0x68
	public Shader dx11MotionBlurShader; // 0x70
	public Shader replacementClear; // 0x78
	private Material motionBlurMaterial; // 0x80
	private Material dx11MotionBlurMaterial; // 0x88
	public Texture2D noiseTexture; // 0x90
	public float jitter; // 0x98
	public bool showVelocity; // 0x9C
	public float showVelocityScale; // 0xA0
	private Matrix4x4 currentViewProjMat; // 0xA4
	private Matrix4x4 prevViewProjMat; // 0xE4
	private int prevFrameCount; // 0x124
	private bool wasActive; // 0x128
	private Vector3 prevFrameForward; // 0x12C
	private Vector3 prevFrameUp; // 0x138
	private Vector3 prevFramePos; // 0x144
	private Camera _camera; // 0x150

	// Methods

	// RVA: 0x12C27D0 Offset: 0x12C1BD0 VA: 0x1812C27D0
	private void CalculateViewProjection() { }

	// RVA: 0x12C4C60 Offset: 0x12C4060 VA: 0x1812C4C60
	private void Start() { }

	// RVA: 0x12C3020 Offset: 0x12C2420 VA: 0x1812C3020
	private void OnEnable() { }

	// RVA: 0x12C2E70 Offset: 0x12C2270 VA: 0x1812C2E70
	private void OnDisable() { }

	// RVA: 0x12C29B0 Offset: 0x12C1DB0 VA: 0x1812C29B0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x12C30F0 Offset: 0x12C24F0 VA: 0x1812C30F0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12C4A60 Offset: 0x12C3E60 VA: 0x1812C4A60
	private void Remember() { }

	// RVA: 0x12C2A60 Offset: 0x12C1E60 VA: 0x1812C2A60
	private Camera GetTmpCam() { }

	// RVA: 0x12C4B50 Offset: 0x12C3F50 VA: 0x1812C4B50
	private void StartFrame() { }

	// RVA: 0x12C4EB0 Offset: 0x12C42B0 VA: 0x1812C4EB0
	private static int divRoundUp(int x, int d) { }

	// RVA: 0x12C4D90 Offset: 0x12C4190 VA: 0x1812C4D90
	public void .ctor() { }

	// RVA: 0x12C4D50 Offset: 0x12C4150 VA: 0x1812C4D50
	private static void .cctor() { }

}

public enum CameraMotionBlur.MotionBlurFilter // TypeDefIndex: 8169
{	// Fields
	public int value__; // 0x0
	public const CameraMotionBlur.MotionBlurFilter CameraMotion = 0;
	public const CameraMotionBlur.MotionBlurFilter LocalBlur = 1;
	public const CameraMotionBlur.MotionBlurFilter Reconstruction = 2;
	public const CameraMotionBlur.MotionBlurFilter ReconstructionDX11 = 3;
	public const CameraMotionBlur.MotionBlurFilter ReconstructionDisc = 4;

}


public class CameraMotionBlur : PostEffectsBase // TypeDefIndex: 8186
{
	private static float MAX_RADIUS; 
	public CameraMotionBlur.MotionBlurFilter filterType; 
	public bool preview; 
	public Vector3 previewScale; 
	public float movementScale; 
	public float rotationScale; 
	public float maxVelocity; 
	public float minVelocity; 
	public float velocityScale; 
	public float softZDistance; 
	public int velocityDownsample; 
	public LayerMask excludeLayers; 
	private GameObject tmpCam; 
	public Shader shader; 
	public Shader dx11MotionBlurShader; 
	public Shader replacementClear; 
	private Material motionBlurMaterial; 
	private Material dx11MotionBlurMaterial; 
	public Texture2D noiseTexture; 
	public float jitter; 
	public bool showVelocity; 
	public float showVelocityScale; 
	private Matrix4x4 currentViewProjMat; 
	private Matrix4x4 prevViewProjMat; 
	private int prevFrameCount; 
	private bool wasActive; 
	private Vector3 prevFrameForward; 
	private Vector3 prevFrameUp; 
	private Vector3 prevFramePos; 
	private Camera _camera; 


	private void CalculateViewProjection() { }

	private void Start() { }

	private void OnEnable() { }

	private void OnDisable() { }

	public override bool CheckResources() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void Remember() { }

	private Camera GetTmpCam() { }

	private void StartFrame() { }

	private static int divRoundUp(int x, int d) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum CameraMotionBlur.MotionBlurFilter // TypeDefIndex: 8187
{
	public int value__; 
	public const CameraMotionBlur.MotionBlurFilter CameraMotion = 0;
	public const CameraMotionBlur.MotionBlurFilter LocalBlur = 1;
	public const CameraMotionBlur.MotionBlurFilter Reconstruction = 2;
	public const CameraMotionBlur.MotionBlurFilter ReconstructionDX11 = 3;
	public const CameraMotionBlur.MotionBlurFilter ReconstructionDisc = 4;

}


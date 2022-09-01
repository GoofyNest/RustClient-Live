public class RawImage : MaskableGraphic // TypeDefIndex: 4993
{
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private Texture m_Texture; 
	[SerializeField] 
	private Rect m_UVRect; 

	public override Texture mainTexture { get; }
	public Texture texture { get; set; }
	public Rect uvRect { get; set; }


	protected void .ctor() { }

	public override Texture get_mainTexture() { }

	public Texture get_texture() { }

	public void set_texture(Texture value) { }

	public Rect get_uvRect() { }

	public void set_uvRect(Rect value) { }

	public override void SetNativeSize() { }

	protected override void OnPopulateMesh(VertexHelper vh) { }

	protected override void OnDidApplyAnimationProperties() { }

}


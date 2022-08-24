public class Joint : Component // TypeDefIndex: 3927
{
	public Rigidbody connectedBody { set; }
	public Vector3 anchor { set; }
	public Vector3 connectedAnchor { set; }
	public bool autoConfigureConnectedAnchor { set; }
	public bool enableCollision { set; }
	public bool enablePreprocessing { set; }


	public void set_connectedBody(Rigidbody value) { }

	public void set_anchor(Vector3 value) { }

	public void set_connectedAnchor(Vector3 value) { }

	public void set_autoConfigureConnectedAnchor(bool value) { }

	public void set_enableCollision(bool value) { }

	public void set_enablePreprocessing(bool value) { }

	private void set_anchor_Injected(ref Vector3 value) { }

	private void set_connectedAnchor_Injected(ref Vector3 value) { }

}


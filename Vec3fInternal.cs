internal struct Vec3fInternal : IGettable<Vec3f>, ISettable<Vec3f>, IDisposable // TypeDefIndex: 9797
{
	private float m_x; 
	private float m_y; 
	private float m_z; 

	public float x { get; set; }
	public float y { get; set; }
	public float z { get; set; }


	public float get_x() { }

	public void set_x(float value) { }

	public float get_y() { }

	public void set_y(float value) { }

	public float get_z() { }

	public void set_z(float value) { }

	public void Set(ref Vec3f other) { }

	public void Set(ref Nullable<Vec3f> other) { }

	public void Dispose() { }

	public void Get(out Vec3f output) { }

}


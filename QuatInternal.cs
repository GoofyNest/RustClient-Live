internal struct QuatInternal : IGettable<Quat>, ISettable<Quat>, IDisposable // TypeDefIndex: 9786
{
	private float m_w; 
	private float m_x; 
	private float m_y; 
	private float m_z; 

	public float w { get; set; }
	public float x { get; set; }
	public float y { get; set; }
	public float z { get; set; }


	public float get_w() { }

	public void set_w(float value) { }

	public float get_x() { }

	public void set_x(float value) { }

	public float get_y() { }

	public void set_y(float value) { }

	public float get_z() { }

	public void set_z(float value) { }

	public void Set(ref Quat other) { }

	public void Set(ref Nullable<Quat> other) { }

	public void Dispose() { }

	public void Get(out Quat output) { }

}


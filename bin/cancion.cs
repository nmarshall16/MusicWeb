public class cancion{
	public string nombre;
	public string url;

	public cancion(){}

	public cancion(string nom,string ur){
		this.nombre=nom;
		this.url=ur;
	}

	public void setNombre(string nom){
		this.nombre=nom;
	}
}
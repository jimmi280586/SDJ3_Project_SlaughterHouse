package model;

public class Animal 
{
	private int id;
	private String type;
	private int waight;
	
	public Animal(int id, String type, int waight)
	{
		this.id = id;
		this.type = type;
		this.waight = waight;
		
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getType() {
		return type;
	}

	public void setType(String type) {
		this.type = type;
	}

	public int getWaight() {
		return waight;
	}

	public void setWaight(int waight) {
		this.waight = waight;
	}
}

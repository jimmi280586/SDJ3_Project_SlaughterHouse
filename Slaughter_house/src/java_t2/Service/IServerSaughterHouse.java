package java_t2.Service;

import java.util.ArrayList;

public interface IServerSaughterHouse {

  public String addAnimal(String IdAnimal,String type, float weight);//add new animal pig or cow
	
	
	public String addPart(String IdAnimal, String typePart, float weight);
	//add part by id animal , type of part(ribs or legs) and weight part
	
	public String addTray(String typeOfMeat, float maxWeight);//add tray by type(legs or ribs)and maxWei
	
	
	public int addToTray(String Tray, String Part);//add for ex. in tray ribs a part rib
	
	
	public String addOrder(String OrderID , float weight, String type);
	
	public int makeOrder(String TrayType, String OrderID);
	
	public double getTrayWeight(String TrayType);
	
	public ArrayList<String> complains(String OrderID);
}

//Generate the message and skeleton .java files with
//the command wsdl2java

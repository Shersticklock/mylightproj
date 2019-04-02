package com.starfish.muleesb.domain.productupdate;

import java.util.List;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlAnyElement;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name = "Элемент")
@XmlAccessorType(XmlAccessType.PROPERTY)
public class ProductBox {

	private String guid;
	private String name;
	private int coefficient;
	private List<BoxLine> boxLines;
	
	
	@XmlElement(name = "GUID")
	public String getGuid() {
		return guid;
	}

	public void setGuid(String guid) {
		this.guid = guid;
	}
	
	@XmlElement(name = "Наименование")
	public String getName() {
		return name;
	}
	
	public void setName(String name) {
		this.name = name;
	}
	
	@XmlElement(name = "Коэффициент")
	public int getCoefficient() {
		return coefficient;
	}
	
	public void setCoefficient(int coefficient) {
		this.coefficient = coefficient;
	}
	
	@XmlAnyElement(lax = true)
	public List<BoxLine> getBoxLines() {
		return boxLines;
	}
	
	public void setBoxLines(List<BoxLine> boxLines) {
		this.boxLines = boxLines;
	}

}

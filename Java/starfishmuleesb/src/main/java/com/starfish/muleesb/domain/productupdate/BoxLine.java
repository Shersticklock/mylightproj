package com.starfish.muleesb.domain.productupdate;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name = "Строка")
@XmlAccessorType(XmlAccessType.PROPERTY)
public class BoxLine {
	
	private String size;
	private int count;
	
	
	@XmlElement(name = "Размер")
	public String getSize() {
		return size;
	}
	
	public void setSize(String size) {
		this.size = size;
	}
	
	@XmlElement(name = "Количество")
	public int getCount() {
		return count;
	}
	
	public void setCount(int count) {
		this.count = count;
	}

}

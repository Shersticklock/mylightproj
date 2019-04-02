package com.starfish.muleesb.domain.shippingupdates.sdek.response;

import java.util.List;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;

@XmlAccessorType(XmlAccessType.PROPERTY)
public class SdekOrderPackage {

	private String number;
	private List<SdekOrderPackageItem> items;

	@XmlAttribute(name = "Number", required = true)
	public String getNumber() {
		return number;
	}

	public void setNumber(String number) {
		this.number = number;
	}

	@XmlElement(name = "Item")
	public List<SdekOrderPackageItem> getItems() {
		return items;
	}

	public void setItems(List<SdekOrderPackageItem> items) {
		this.items = items;
	}

}

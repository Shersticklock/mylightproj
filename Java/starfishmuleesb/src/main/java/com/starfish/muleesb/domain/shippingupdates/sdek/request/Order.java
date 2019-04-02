package com.starfish.muleesb.domain.shippingupdates.sdek.request;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlAttribute;

@XmlAccessorType(XmlAccessType.PROPERTY)
public class Order {

	private Integer dispatchNumber;
	private String number;
	private String date;

	@XmlAttribute(name = "DispatchNumber", required = true)
	public Integer getDispatchNumber() {
		return dispatchNumber;
	}

	public void setDispatchNumber(Integer dispatchNumber) {
		this.dispatchNumber = dispatchNumber;
	}

	@XmlAttribute(name = "Number", required = true)
	public String getNumber() {
		return number;
	}

	public void setNumber(String number) {
		this.number = number;
	}

	@XmlAttribute(name = "Date", required = true)
	public String getDate() {
		return date;
	}

	public void setDate(String date) {
		this.date = date;
	}

}

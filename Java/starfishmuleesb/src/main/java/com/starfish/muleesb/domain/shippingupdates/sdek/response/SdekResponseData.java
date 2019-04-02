package com.starfish.muleesb.domain.shippingupdates.sdek.response;

import java.util.List;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name = "StatusReport")
@XmlAccessorType(XmlAccessType.PROPERTY)
public class SdekResponseData {

	private String dateFirst;
	private String dateLast;
	private List<SdekOrder> orders;

	@XmlAttribute(name = "DateFirst")
	public String getDateFirst() {
		return dateFirst;
	}

	public void setDateFirst(String dateFirst) {
		this.dateFirst = dateFirst;
	}

	@XmlAttribute(name = "DateLast")
	public String getDateLast() {
		return dateLast;
	}

	public void setDateLast(String dateLast) {
		this.dateLast = dateLast;
	}

	@XmlElement(name = "Order")
	public List<SdekOrder> getOrders() {
		return orders;
	}

	public void setOrders(List<SdekOrder> orders) {
		this.orders = orders;
	}

}

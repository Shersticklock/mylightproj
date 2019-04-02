package com.starfish.muleesb.domain.shippingupdates.sdek.request;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlAttribute;

@XmlAccessorType(XmlAccessType.PROPERTY)
public class ChangePeriod {

	private String dateFirst;
	private String dateLast;

	@XmlAttribute(name = "DateFirst", required = true)
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

}

package com.starfish.muleesb.domain.shippingupdates.sdek.response;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlAttribute;

@XmlAccessorType(XmlAccessType.PROPERTY)
public class SdekOrderCallDelay {

	private String date;
	private String dateNext;

	@XmlAttribute(name = "Date", required = true)
	public String getDate() {
		return date;
	}

	public void setDate(String date) {
		this.date = date;
	}

	@XmlAttribute(name = "DateNext", required = true)
	public String getDateNext() {
		return dateNext;
	}

	public void setDateNext(String dateNext) {
		this.dateNext = dateNext;
	}

}

package com.starfish.muleesb.domain.shippingupdates.sdek.response;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlAttribute;

@XmlAccessorType(XmlAccessType.PROPERTY)
public class SdekOrderCallFail {

	private String date;
	private Integer reasonCode;
	private String reasonDescription;

	@XmlAttribute(name = "Date", required = true)
	public String getDate() {
		return date;
	}

	public void setDate(String date) {
		this.date = date;
	}

	@XmlAttribute(name = "ReasonCode", required = true)
	public Integer getReasonCode() {
		return reasonCode;
	}

	public void setReasonCode(Integer reasonCode) {
		this.reasonCode = reasonCode;
	}

	@XmlAttribute(name = "ReasonDescription", required = true)
	public String getReasonDescription() {
		return reasonDescription;
	}

	public void setReasonDescription(String reasonDescription) {
		this.reasonDescription = reasonDescription;
	}

}

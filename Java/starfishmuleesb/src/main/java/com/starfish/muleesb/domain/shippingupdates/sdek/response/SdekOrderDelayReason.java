package com.starfish.muleesb.domain.shippingupdates.sdek.response;

import java.util.List;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;

@XmlAccessorType(XmlAccessType.PROPERTY)
public class SdekOrderDelayReason {

	private String date;
	private Integer code;
	private String description;
	private List<SdekOrderDelayReasonState> states;

	@XmlAttribute(name = "Date", required = true)
	public String getDate() {
		return date;
	}

	public void setDate(String date) {
		this.date = date;
	}

	@XmlAttribute(name = "Code")
	public Integer getCode() {
		return code;
	}

	public void setCode(Integer code) {
		this.code = code;
	}

	@XmlAttribute(name = "Description")
	public String getDescription() {
		return description;
	}

	public void setDescription(String description) {
		this.description = description;
	}

	@XmlElement(name = "State")
	public List<SdekOrderDelayReasonState> getStates() {
		return states;
	}

	public void setStates(List<SdekOrderDelayReasonState> states) {
		this.states = states;
	}

}

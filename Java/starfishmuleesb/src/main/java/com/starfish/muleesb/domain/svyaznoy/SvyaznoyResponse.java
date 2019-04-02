package com.starfish.muleesb.domain.svyaznoy;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name = "response")
@XmlAccessorType(XmlAccessType.PROPERTY)
public class SvyaznoyResponse {
	
	private Integer code;
	private String text;
	private SvyaznoyPayload payload;


	@XmlElement
	public Integer getCode() {
		return code;
	}

	public void setCode(Integer code) {
		this.code = code;
	}

	@XmlElement
	public String getText() {
		return text;
	}

	public void setText(String text) {
		this.text = text;
	}

	@XmlElement
	public SvyaznoyPayload getPayload() {
		return payload;
	}

	public void setPayload(SvyaznoyPayload payload) {
		this.payload = payload;
	}

}

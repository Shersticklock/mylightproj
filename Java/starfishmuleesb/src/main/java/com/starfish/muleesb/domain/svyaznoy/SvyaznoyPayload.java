package com.starfish.muleesb.domain.svyaznoy;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name = "payload")
@XmlAccessorType(XmlAccessType.PROPERTY)
public class SvyaznoyPayload {

	private Long id;


	@XmlElement
	public Long getId() {
		return id;
	}

	public void setId(Long id) {
		this.id = id;
	}

}
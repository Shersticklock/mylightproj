package com.starfish.muleesb.domain.shippingupdates.sdek.response;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlAttribute;

@XmlAccessorType(XmlAccessType.PROPERTY)
public class SdekOrderAttempt {

	private Integer id;
	private Integer scheduleCode;
	private String scheduleDescription;

	@XmlAttribute(name = "ID", required = true)
	public Integer getId() {
		return id;
	}

	public void setId(Integer id) {
		this.id = id;
	}

	@XmlAttribute(name = "ScheduleCode", required = true)
	public Integer getScheduleCode() {
		return scheduleCode;
	}

	public void setScheduleCode(Integer scheduleCode) {
		this.scheduleCode = scheduleCode;
	}

	@XmlAttribute(name = "ScheduleDescription", required = true)
	public String getScheduleDescription() {
		return scheduleDescription;
	}

	public void setScheduleDescription(String scheduleDescription) {
		this.scheduleDescription = scheduleDescription;
	}

}

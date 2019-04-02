package com.starfish.muleesb.domain.shippingupdates.sdek.response;

import java.util.List;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;

@XmlAccessorType(XmlAccessType.PROPERTY)
public class SdekOrderStatus {

	private String date;
	private Integer code;
	private String description;
	private Integer cityCode;
	private String cityName;
	private List<SdekOrderStatusState> states;

	@XmlAttribute(name = "Date", required = true)
	public String getDate() {
		return date;
	}

	public void setDate(String date) {
		this.date = date;
	}

	@XmlAttribute(name = "Code", required = true)
	public Integer getCode() {
		return code;
	}

	public void setCode(Integer code) {
		this.code = code;
	}

	@XmlAttribute(name = "Description", required = true)
	public String getDescription() {
		return description;
	}

	public void setDescription(String description) {
		this.description = description;
	}

	@XmlAttribute(name = "CityCode", required = true)
	public Integer getCityCode() {
		return cityCode;
	}

	public void setCityCode(Integer cityCode) {
		this.cityCode = cityCode;
	}

	@XmlAttribute(name = "CityName", required = true)
	public String getCityName() {
		return cityName;
	}

	public void setCityName(String cityName) {
		this.cityName = cityName;
	}

	@XmlElement(name = "State")
	public List<SdekOrderStatusState> getStates() {
		return states;
	}

	public void setStates(List<SdekOrderStatusState> states) {
		this.states = states;
	}

}

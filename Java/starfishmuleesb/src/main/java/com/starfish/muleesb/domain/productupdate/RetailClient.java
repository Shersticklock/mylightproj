package com.starfish.muleesb.domain.productupdate;

import java.util.Date;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

import com.starfish.muleesb.stereotype.IsProductDictionary;

@XmlRootElement(name = "Элемент")
@XmlAccessorType(XmlAccessType.PROPERTY)
@IsProductDictionary
public class RetailClient {

	private String guid;
	private String name;
	private Date birthDate;
	private String phone;
	private String email;
	private String gender;
	private Boolean sendingEmail;
	private Boolean sendingSms;
	
	
	@XmlElement(name = "GUID")
	public String getGuid() {
		return guid;
	}
	
	public void setGuid(String guid) {
		this.guid = guid;
	}
	
	@XmlElement(name = "Наименование")
	public String getName() {
		return name;
	}
	
	public void setName(String name) {
		this.name = name;
	}

	@XmlElement(name = "ДатаРождения")
	public Date getBirthDate() {
		return birthDate;
	}

	public void setBirthDate(Date birthDate) {
		this.birthDate = birthDate;
	}

	@XmlElement(name = "Телефон")
	public String getPhone() {
		return phone;
	}

	public void setPhone(String phone) {
		this.phone = phone;
	}

	@XmlElement(name = "EMail")
	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	@XmlElement(name = "Пол")
	public String getGender() {
		return gender;
	}

	public void setGender(String gender) {
		this.gender = gender;
	}

	@XmlElement(name = "РассылкаEmail")
	public Boolean getSendingEmail() {
		return sendingEmail;
	}

	public void setSendingEmail(Boolean sendingEmail) {
		this.sendingEmail = sendingEmail;
	}

	@XmlElement(name = "РассылкаSMS")
	public Boolean getSendingSms() {
		return sendingSms;
	}

	public void setSendingSms(Boolean sendingSms) {
		this.sendingSms = sendingSms;
	}

}

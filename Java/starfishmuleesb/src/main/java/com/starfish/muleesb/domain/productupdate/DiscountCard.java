package com.starfish.muleesb.domain.productupdate;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

import com.starfish.muleesb.stereotype.IsProductDictionary;

@XmlRootElement(name = "Элемент")
@XmlAccessorType(XmlAccessType.PROPERTY)
@IsProductDictionary
public class DiscountCard {

	private String guid;
	private String name;
	private String type;
	private String retailClient;
	private String status;
	private int discount;
	private String blockingReason;
	
	
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

	@XmlElement(name = "ВидДК")
	public String getType() {
		return type;
	}

	public void setType(String type) {
		this.type = type;
	}

	@XmlElement(name = "РозничныйПокупатель")
	public String getRetailClient() {
		return retailClient;
	}

	public void setRetailClient(String retailClient) {
		this.retailClient = retailClient;
	}

	@XmlElement(name = "Статус")
	public String getStatus() {
		return status;
	}

	public void setStatus(String status) {
		this.status = status;
	}

	@XmlElement(name = "ПроцентСкидки")
	public int getDiscount() {
		return discount;
	}

	public void setDiscount(int discount) {
		this.discount = discount;
	}

	@XmlElement(name = "ПричинаБлокировки")
	public String getBlockingReason() {
		return blockingReason;
	}

	public void setBlockingReason(String blockingReason) {
		this.blockingReason = blockingReason;
	}

}

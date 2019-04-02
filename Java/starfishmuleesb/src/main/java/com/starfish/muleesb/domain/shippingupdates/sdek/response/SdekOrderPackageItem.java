package com.starfish.muleesb.domain.shippingupdates.sdek.response;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlAttribute;

@XmlAccessorType(XmlAccessType.PROPERTY)
public class SdekOrderPackageItem {

	private String wareKey;
	private Integer deliveryAmount;

	@XmlAttribute(name = "WareKey", required = true)
	public String getWareKey() {
		return wareKey;
	}

	public void setWareKey(String wareKey) {
		this.wareKey = wareKey;
	}

	@XmlAttribute(name = "DelivAmount", required = true)
	public Integer getDeliveryAmount() {
		return deliveryAmount;
	}

	public void setDeliveryAmount(Integer deliveryAmount) {
		this.deliveryAmount = deliveryAmount;
	}

}

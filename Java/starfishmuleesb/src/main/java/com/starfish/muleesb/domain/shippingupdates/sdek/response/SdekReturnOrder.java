package com.starfish.muleesb.domain.shippingupdates.sdek.response;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;

@XmlAccessorType(XmlAccessType.PROPERTY)
public class SdekReturnOrder {

	private String returnOrderNumber;
	private String number;
	private Integer dispatchNumber;
	private String deliveryDate;
	private String recipientName;
	private SdekOrderStatus status;
	private SdekOrderReason reason;
	private SdekReturnOrderDelayReason delayReason;

	@XmlAttribute(name = "ReturnOrderNumber", required = true)
	public String getReturnOrderNumber() {
		return returnOrderNumber;
	}

	public void setReturnOrderNumber(String returnOrderNumber) {
		this.returnOrderNumber = returnOrderNumber;
	}

	@XmlAttribute(name = "Number", required = true)
	public String getNumber() {
		return number;
	}

	public void setNumber(String number) {
		this.number = number;
	}

	@XmlAttribute(name = "DispatchNumber", required = true)
	public Integer getDispatchNumber() {
		return dispatchNumber;
	}

	public void setDispatchNumber(Integer dispatchNumber) {
		this.dispatchNumber = dispatchNumber;
	}

	@XmlAttribute(name = "DeliveryDate")
	public String getDeliveryDate() {
		return deliveryDate;
	}

	public void setDeliveryDate(String deliveryDate) {
		this.deliveryDate = deliveryDate;
	}

	@XmlAttribute(name = "RecipientName")
	public String getRecipientName() {
		return recipientName;
	}

	public void setRecipientName(String recipientName) {
		this.recipientName = recipientName;
	}

	@XmlElement(name = "Status")
	public SdekOrderStatus getStatus() {
		return status;
	}

	public void setStatus(SdekOrderStatus status) {
		this.status = status;
	}

	@XmlElement(name = "Reason")
	public SdekOrderReason getReason() {
		return reason;
	}

	public void setReason(SdekOrderReason reason) {
		this.reason = reason;
	}

	@XmlElement(name = "DelayReason")
	public SdekReturnOrderDelayReason getDelayReason() {
		return delayReason;
	}

	public void setDelayReason(SdekReturnOrderDelayReason delayReason) {
		this.delayReason = delayReason;
	}

}

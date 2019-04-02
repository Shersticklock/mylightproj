package com.starfish.muleesb.domain.shippingupdates.sdek.response;

import java.util.List;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;

@XmlAccessorType(XmlAccessType.PROPERTY)
public class SdekOrder {

	private String actNumber;
	private String number;
	private Integer dispatchNumber;
	private String deliveryDate;
	private String recipientName;
	private Integer returnDispatchNumber;
	private SdekOrderStatus status;
	private SdekOrderReason reason;
	private SdekOrderDelayReason delayReason;
	private SdekOrderPackage orderPackage;
	private SdekOrderAttempt attempt;
	private SdekOrderCallHistory calls;
	private List<SdekReturnOrder> returnOrders;

	@XmlAttribute(name = "ActNumber", required = true)
	public String getActNumber() {
		return actNumber;
	}

	public void setActNumber(String actNumber) {
		this.actNumber = actNumber;
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

	@XmlAttribute(name = "ReturnDispatchNumber")
	public Integer getReturnDispatchNumber() {
		return returnDispatchNumber;
	}

	public void setReturnDispatchNumber(Integer returnDispatchNumber) {
		this.returnDispatchNumber = returnDispatchNumber;
	}

	@XmlElement(name = "Status", required = true)
	public SdekOrderStatus getStatus() {
		return status;
	}

	public void setStatus(SdekOrderStatus status) {
		this.status = status;
	}

	@XmlElement(name = "Reason", required = true)
	public SdekOrderReason getReason() {
		return reason;
	}

	public void setReason(SdekOrderReason reason) {
		this.reason = reason;
	}

	@XmlElement(name = "DelayReason", required = true)
	public SdekOrderDelayReason getDelayReason() {
		return delayReason;
	}

	public void setDelayReason(SdekOrderDelayReason delayReason) {
		this.delayReason = delayReason;
	}

	@XmlElement(name = "Package")
	public SdekOrderPackage getOrderPackage() {
		return orderPackage;
	}

	public void setOrderPackage(SdekOrderPackage orderPackage) {
		this.orderPackage = orderPackage;
	}

	@XmlElement(name = "Attempt")
	public SdekOrderAttempt getAttempt() {
		return attempt;
	}

	public void setAttempt(SdekOrderAttempt attempt) {
		this.attempt = attempt;
	}

	@XmlElement(name = "Call")
	public SdekOrderCallHistory getCalls() {
		return calls;
	}

	public void setCalls(SdekOrderCallHistory calls) {
		this.calls = calls;
	}

	@XmlElement(name = "ReturnOrder")
	public List<SdekReturnOrder> getReturnOrders() {
		return returnOrders;
	}

	public void setReturnOrders(List<SdekReturnOrder> returnOrders) {
		this.returnOrders = returnOrders;
	}

}

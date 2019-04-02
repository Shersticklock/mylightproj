package com.starfish.muleesb.domain.shippingupdates.sdek.request;

import java.util.List;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name = "StatusReport")
@XmlAccessorType(XmlAccessType.PROPERTY)
public class SdekRequestData {

	private String date;
	private String account;
	private String secure;
	private Integer showHistory;
	private Integer showReturnOrder;
	private Integer showReturnOrderHistory;
	private ChangePeriod changePeriod;
	private List<Order> orders;

	@XmlAttribute(name = "Date", required = true)
	public String getDate() {
		return date;
	}

	public void setDate(String date) {
		this.date = date;
	}

	@XmlAttribute(name = "Account", required = true)
	public String getAccount() {
		return account;
	}

	public void setAccount(String account) {
		this.account = account;
	}

	@XmlAttribute(name = "Secure", required = true)
	public String getSecure() {
		return secure;
	}

	public void setSecure(String secure) {
		this.secure = secure;
	}

	@XmlAttribute(name = "ShowHistory")
	public Integer getShowHistory() {
		return showHistory;
	}

	public void setShowHistory(Integer showHistory) {
		this.showHistory = showHistory;
	}

	@XmlAttribute(name = "ShowReturnOrder")
	public Integer getShowReturnOrder() {
		return showReturnOrder;
	}

	public void setShowReturnOrder(Integer showReturnOrder) {
		this.showReturnOrder = showReturnOrder;
	}

	@XmlAttribute(name = "ShowReturnOrderHistory")
	public Integer getShowReturnOrderHistory() {
		return showReturnOrderHistory;
	}

	public void setShowReturnOrderHistory(Integer showReturnOrderHistory) {
		this.showReturnOrderHistory = showReturnOrderHistory;
	}

	@XmlElement(name = "ChangePeriod")
	public ChangePeriod getChangePeriod() {
		return changePeriod;
	}

	public void setChangePeriod(ChangePeriod changePeriod) {
		this.changePeriod = changePeriod;
	}

	@XmlElement(name = "Order")
	public List<Order> getOrders() {
		return orders;
	}

	public void setOrders(List<Order> orders) {
		this.orders = orders;
	}

}

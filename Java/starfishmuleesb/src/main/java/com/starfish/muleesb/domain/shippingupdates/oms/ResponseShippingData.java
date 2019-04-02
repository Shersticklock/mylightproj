package com.starfish.muleesb.domain.shippingupdates.oms;

import java.util.List;

public class ResponseShippingData {

	private String orderId;
	private String shippingId;
	private String statusId;
	private List<ResponseShippingItem> items;

	public String getOrderId() {
		return orderId;
	}

	public void setOrderId(String orderId) {
		this.orderId = orderId;
	}

	public String getShippingId() {
		return shippingId;
	}

	public void setShippingId(String shippingId) {
		this.shippingId = shippingId;
	}

	public String getStatusId() {
		return statusId;
	}

	public void setStatusId(String statusId) {
		this.statusId = statusId;
	}

	public List<ResponseShippingItem> getItems() {
		return items;
	}

	public void setItems(List<ResponseShippingItem> items) {
		this.items = items;
	}

}

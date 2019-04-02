package com.starfish.muleesb.domain.shippingupdates.oms;

import java.util.List;

public class ResponseData {

	private List<ResponseShippingData> result;
	private String message;
	private boolean success;

	public List<ResponseShippingData> getResult() {
		return result;
	}

	public void setResult(List<ResponseShippingData> result) {
		this.result = result;
	}

	public String getMessage() {
		return message;
	}

	public void setMessage(String message) {
		this.message = message;
	}

	public boolean isSuccess() {
		return success;
	}

	public void setSuccess(boolean success) {
		this.success = success;
	}

}

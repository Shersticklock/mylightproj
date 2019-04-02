package com.starfish.muleesb.domain.shippingupdates.oms;

public class RequestData {

	private String from;
	private String till;
	private String clientId;
	private String secretKey;

	public String getFrom() {
		return from;
	}

	public void setFrom(String from) {
		this.from = from;
	}

	public String getTill() {
		return till;
	}

	public void setTill(String till) {
		this.till = till;
	}

	public String getClientId() {
		return clientId;
	}

	public void setClientId(String clientId) {
		this.clientId = clientId;
	}

	public String getSecretKey() {
		return secretKey;
	}

	public void setSecretKey(String secretKey) {
		this.secretKey = secretKey;
	}

}

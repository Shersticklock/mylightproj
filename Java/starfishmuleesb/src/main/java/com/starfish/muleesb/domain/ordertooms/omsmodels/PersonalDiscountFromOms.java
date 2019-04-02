package com.starfish.muleesb.domain.ordertooms.omsmodels;

import org.codehaus.jackson.annotate.JsonProperty;

public class PersonalDiscountFromOms {

	@JsonProperty("id")
	private String id;

	@JsonProperty("code")
	private String code;


	public String getId() {
		return id;
	}

	public void setId(String id) {
		this.id = id;
	}

	public String getCode() {
		return code;
	}

	public void setCode(String code) {
		this.code = code;
	}

}
